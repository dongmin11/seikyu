using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace BillingSystem
{
    public class DbAccessor : IDisposable
    {
        /// <summary>
        /// Disposeされたかどうか
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// DB接続
        /// </summary>
        private SqlConnection sqlConnection;

        /// <summary>
        /// トランザクション
        /// </summary>
        private SqlTransaction sqlTransaction;

        /// <summary>
        /// DB開く中
        /// </summary>
        public bool IsOpend { get; private set; }

        #region DBを開く Open
        /// <summary>
        /// DBを開く　Open
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            try
            {
                if (!IsOpend)
                {
                    String connectionString = ConfigurationManager.AppSettings["connStr"] + "User ID=" + ConfigurationManager.AppSettings["uid"] + ";Password=" + ConfigurationManager.AppSettings["pwd"];
                    this.sqlConnection = new SqlConnection(connectionString);
                    this.sqlConnection.Open();
                    IsOpend = true;
                }
            }
            catch (Exception ex)
            {
                //LogFacade.Error("DB接続に失敗しました。", ex);
            }
            return IsOpend;
        }
        #endregion

        #region DBを切断 Close
        /// <summary>
        /// DBを切断
        /// </summary>
        public void Close()
        {
            this.Dispose();
        }
        #endregion

        #region 検索 ExecuteReader
        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> ExecuteReader(string sqlString)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                if (!this.IsOpend)
                {
                    this.Open();
                }
                  
                sqlCommand.Connection = this.sqlConnection;
                sqlCommand.CommandText = sqlString;

                if (sqlTransaction != null)
                {
                    sqlCommand.Transaction = sqlTransaction;
                }

                sqlCommand.Prepare();
                //クエリを実行する
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    //読み込んで格納
                    while (reader.Read())
                    {
                        result.Add(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
                    }
                }
            }
            catch (Exception ex)
            {
                //LogFacade.Error("ExecuteReaderでエラーが発生しました。", ex);
                throw;
            }
            return result;
        }
        #endregion

        #region 更新 ExecuteNonQuery
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sqlString)
        {
            SqlCommand sqlCommand = new SqlCommand();
            if (!this.IsOpend)
            {
                this.Open();
            }

            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.CommandText = sqlString;

            if (sqlTransaction != null)
            {
                sqlCommand.Transaction = sqlTransaction;
            }

            if (sqlTransaction != null)
            {
                sqlCommand.Transaction = sqlTransaction;
            }

            return sqlCommand.ExecuteNonQuery();
        }
        #endregion

        #region トランザクション更新処理開始 BeginTransaction
        /// <summary>
        /// トランザクション更新処理開始
        /// </summary>
        public void BeginTransaction()
        {
            sqlTransaction = sqlConnection.BeginTransaction();
        }
        #endregion

        #region トランザクションコミット Commit
        /// <summary>
        /// トランザクションコミット
        /// </summary>
        /// <returns></returns>
        public bool Commit()
        {
            try
            {
                if (sqlConnection != null)
                {
                    sqlTransaction.Commit();
                }
                return true;
            }
            catch (Exception ex)
            {
                //LogFacade.Error("トランザクションのコミットに失敗しました。", ex);
                Rollback();
                return false;
            }
            finally
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Dispose();
                    sqlTransaction = null;
                }
            }
        }
        #endregion 

        #region トランザクションロールバック Rollback
        /// <summary>
        /// トランザクションロールバック
        /// </summary>
        public void Rollback()
        {
            try
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                //LogFacade.Error("トランザクションのロールバックに失敗しました。", ex);
            }
            finally
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Dispose();
                    sqlTransaction = null;
                }
            }
        }
        #endregion

        #region DBを開放 Dispose
        /// <summary>
        /// DBを開放
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
        #endregion

        #region ------  protected  -----------
        #region DBを開放 Dispose
        /// <summary>
        /// DBを開放
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.sqlConnection != null)
                    {
                        this.sqlConnection.Close();
                        this.sqlConnection = null;
                    }
                }
            }
            this.disposed = true;
        }
        #endregion
        #endregion
    }
}

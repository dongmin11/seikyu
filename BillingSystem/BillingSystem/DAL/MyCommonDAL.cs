using BillingSystem.Models;
using Common.DAL;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BillingSystem.DAL
{
    public class MyCommonDAL : CommonDAL
    {
        #region ユーザ情報を取得
        /// <summary>
        /// ユーザ情報を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<AccountModel> GetAccoutInfo(AccountModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     LoginID");
            sb.Append("    ,UserName");
            sb.Append("    ,Password");
            sb.Append(" FROM");
            sb.Append("     M_User");
            sb.Append(" WHERE");
            sb.Append("     LoginID = @UserID");
            sb.Append("     AND Password = @Password");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<AccountModel>(dt);

            return result;
        }


    }
}
    #endregion

using Common;
using Common.DAL;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Text;

namespace BillingSystem.DAL
{
    public class SeikyuDAL : CommonDAL
    {
        #region サンプルメソッドです。
        /// <summary>
        /// サンプルメソッドです。
        /// </summary>
        /// <param name="inputData"></param>
        /// <param name="outputData"></param>
        public void SaveSample(Hashtable inputData, out Hashtable outputData)
        {
            outputData = new Hashtable();
            int i = -1;
            try
            {
                #region SQL文 
                StringBuilder sb = new StringBuilder();
                sb.Append(" UPDATE M_Message");
                sb.Append("    SET Message = @Message");
                sb.Append(" WHERE");
                sb.Append("     ID = @ID");
                #endregion

                // パラメータ設定
                SqlParameter[] parms = GetSqlParameters(inputData);
                // SQL文実行
                i = RunSqlInt(sb.ToString(), parms);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            outputData[ConstCommon.RESULT] = i;

        }
        #endregion
    }
}

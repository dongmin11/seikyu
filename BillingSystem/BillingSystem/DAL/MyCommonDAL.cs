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

        #region 請求一覧を取得
        /// <summary>
        /// 請求一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<BillingModel> GetBillingInfo(BillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     BillingDate");
            sb.Append("    ,BillingNo");
            sb.Append("    ,BranchNo");
            sb.Append("    ,CustomerName");
            sb.Append("    ,PaymentType");
            sb.Append("    ,BillingAmount");
            sb.Append("    ,BillingTax");
            sb.Append("    ,TransportationAmount");
            sb.Append("    ,BillingTotal");
            sb.Append(" FROM");
            sb.Append("     [dbo].[T_Billing]");
            //sb.Append(" WHERE");
            //sb.Append("     BillingDate BETWEEN '@startDate' AND 'endDate'");
            //sb.Append("    AND CustomerName = @CustomerName");


            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<BillingModel>(dt);

            return result;
        }
        #endregion

        #region 請求一覧を取得
        /// <summary>
        /// 請求一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SearchBillingModel> SearchGetBillingInfo(SearchBillingModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     BillingDate");
            sb.Append("    ,BillingNo");
            sb.Append("    ,BranchNo");
            sb.Append("    ,CustomerName");
            sb.Append("    ,PaymentType");
            sb.Append("    ,BillingAmount");
            sb.Append("    ,BillingTax");
            sb.Append("    ,TransportationAmount");
            sb.Append("    ,BillingTotal");
            sb.Append(" FROM");
            sb.Append("     [dbo].[T_Billing]");
            sb.Append(" WHERE");
            sb.Append("     BillingDate BETWEEN @StartDate AND @EndDate");
            sb.Append("    AND CustomerName = @CustomerName");


            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<SearchBillingModel>(dt);

            return result;
        }
        #endregion


        #region 顧客名一覧取得
        /// <summary>
        /// 顧客名一覧を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<CustomerModel> GetCustomerInfo(CustomerModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     CustomerName");
            sb.Append("     ,ID");
            sb.Append(" FROM");
            sb.Append("     [dbo].[M_Customer]");

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<CustomerModel>(dt);

            return result;
        }
        #endregion
    }
}
    #endregion

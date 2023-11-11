using BillingSystem.Models;
using Common;
using Common.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BillingSystem.DAL
{
    public class SeikyuDAL : CommonDAL
    {
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
            sb.Append("    WHERE DeleteFlag = 0");
         

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

        #region 請求一覧を検索
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

            // "全て" が選択された場合は CustomerName の条件を追加しない
            if (inputData.CustomerName != "全て")
            {
                sb.Append("    AND CustomerName = @CustomerName");
            }

            // 削除も表示選択時処理
            if (inputData.DeleteFlag == "False")
            {
                sb.Append("    AND DeleteFlag = 0;");
            }

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

        #region 顧客一覧総数取得用
        /// <summary>
        /// 請求一覧数
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<AllCountModel> GetAllInfo(AllCountModel inputData)
        {
            #region SQL文            
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT");
            sb.Append("     ID");
            sb.Append(" FROM");
            sb.Append("     [dbo].[T_Billing]");
            // 削除も表示選択時処理
            if (inputData.DeleteFlag == "False" || inputData.DeleteFlag == null)
            {
                sb.Append("    WHERE DeleteFlag = 0;");
            }

            #endregion
            // パラメータ設定
            SqlParameter[] parms = GetSqlParameters(inputData);
            // SQL文実行
            DataTable dt = RunSqlDataTable(sb.ToString(), parms);
            // データテーブルをクラスリストに変換する
            var result = ConvertDataTableToListClass<AllCountModel>(dt);

            return result;
        }
        #endregion
    }
}

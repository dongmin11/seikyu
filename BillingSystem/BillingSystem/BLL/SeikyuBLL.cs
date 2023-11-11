using BillingSystem.DAL;
using Common.BLL;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Configuration;
using BillingSystem.Common;
using BillingSystem.Models;
using System.Collections.Generic;

namespace BillingSystem.BLL
{
    public class SeikyuBLL : CommonBLL
    {
        SeikyuDAL dal = new SeikyuDAL();

        #region ユーザ情報を取得
        /// <summary>
        /// 請求一覧情報を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<BillingModel> GetBillingInfo(BillingModel inputData)
        {
            var selectList = new List<BillingModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<BillingModel> list = CallHeavyBusinessLogic(() => dal.GetBillingInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 請求情報を検索

        /// <summary>
        /// 請求一覧情報を検索
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<SearchBillingModel> SearchGetBillingInfo(SearchBillingModel inputData)
        {
            var selectList = new List<SearchBillingModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<SearchBillingModel> list = CallHeavyBusinessLogic(() => dal.SearchGetBillingInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion

        #region 
        /// <summary>
        ///顧客名取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<CustomerModel> GetCustomerInfo(CustomerModel inputData)
        {
            var selectList = new List<CustomerModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<CustomerModel> list = CallHeavyBusinessLogic(() => dal.GetCustomerInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion


        #region 
        /// <summary>
        ///レコード総数取得用
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public List<AllCountModel> GetAllInfo(AllCountModel inputData)
        {
            var selectList = new List<AllCountModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<AllCountModel> list = CallHeavyBusinessLogic(() => dal.GetAllInfo(inputData), context);

            if (list != null)
            {
                return list;
            }

            return null;
        }
        #endregion
    }
}

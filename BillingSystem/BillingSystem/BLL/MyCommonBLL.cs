using BillingSystem.DAL;
using BillingSystem.Models;
using Common.BLL;
using System.Collections.Generic;

namespace BillingSystem.BLL
{
    public class MyCommonBLL: CommonBLL
    {
        MyCommonDAL dal = new MyCommonDAL();

        #region ユーザ情報を取得
        /// <summary>
        /// ユーザ情報を取得
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public AccountModel GetAccoutInfo(AccountModel inputData)
        {
            var selectList = new List<AccountModel>();

            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            List<AccountModel> list = CallHeavyBusinessLogic(() => dal.GetAccoutInfo(inputData), context);

            if (list != null && list.Count == 1)
            {
                return list[0];
            }

            return null;
        }
        #endregion

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

        #region ユーザ情報を取得
        /// <summary>
        /// 請求一覧情報を取得
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
    }
}

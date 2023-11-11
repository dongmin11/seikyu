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

       
    }
}

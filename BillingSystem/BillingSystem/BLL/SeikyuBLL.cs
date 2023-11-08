using BillingSystem.DAL;
using Common.BLL;
using System.Collections;

namespace BillingSystem.BLL
{
    public class SeikyuBLL : CommonBLL
    {
        SeikyuDAL dal = new SeikyuDAL();

        #region サンプルメソッドです        
        /// <summary>
        /// サンプルメソッドです。（True:成功　False:失敗）
        /// </summary>
        /// <param name="inputData"></param>    
        /// <returns></returns>
        public bool SaveSample(Hashtable inputData)
        {
            Hashtable outputData = new Hashtable();
            CommonDelegateSetSqlContext context = new CommonDelegateSetSqlContext(dal.SetSqlContext);
            // デリゲートの生成
            CommonDelegate commonDelegate = new CommonDelegate(dal.SaveSample);
            bool result = CallHeavyBusinessLogic(context, commonDelegate, inputData, out outputData);

            return result;
        }
        #endregion
       
    }
}

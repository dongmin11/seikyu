using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    /// <summary>
    /// アカウントモデル
    /// </summary>
    public class BillingModel
    {
        /// <summary>
        /// 請求日
        /// </summary>
        public string BillingDate { get; set; }
        /// <summary>
        /// 請求番号
        /// </summary>
        public string BillingNo { get; set; }
        /// <summary>
        /// 顧客番号
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 支払い種別
        /// </summary>
        public string PaymentType { get; set; }
        /// <summary>
        /// 請求額（税抜き）
        /// </summary>
        public string BillingAmount { get; set; }
        /// <summary>
        /// 税金
        /// </summary>
        public string BillingTax { get; set; }
        /// <summary>
        /// 交通費
        /// </summary>
        public string TransportationAmount { get; set; }
        /// <summary>
        /// 請求日（税込み）
        /// </summary>
        public string BillingTotal { get; set; }



    }
}

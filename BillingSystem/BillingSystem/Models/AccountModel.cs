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
    public class AccountModel
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// ユーザー名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; set; }
    }
}

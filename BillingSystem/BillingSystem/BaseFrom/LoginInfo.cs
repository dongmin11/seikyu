using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    public sealed class LoginInfo
    {
        /// <summary>
        /// ユーザID
        /// </summary>
        public static string UserID
        {
            get;
            set;
        }

        /// <summary>
        /// パスワード
        /// </summary>
        public static string PassWord
        {
            get;
            set;
        }

        /// <summary>
        /// ユーザー名
        /// </summary>
        public static string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 権限
        /// </summary>
        public static int AuthorityFlag
        {
            get;
            set;
        }

        /// <summary>
        /// 部署ID
        /// </summary>
        public static int DepartmentID
        {
            get;
            set;
        }
    }
}

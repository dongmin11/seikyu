using BillingSystem.Common;
using System.Windows.Forms;
using Utils;

namespace BillingSystem.BaseFrom
{
    public partial class BaseFrm : Form
    {
        /// <summary>
        /// ログ
        /// </summary>
        protected ILogUtil log;
        /// <summary>
        /// INIファイル
        /// </summary>
        protected MyIniFile ini;
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;
        public BaseFrm()
        {
            InitializeComponent();
            log = new LogUtil();
            ini = new MyIniFile();
            myMsgIni = new MyMessageIniFile();
        }
        /// <summary>
        /// INIファイルの値を取得
        /// </summary>
        /// <param name="section">セクション</param>
        /// <param name="key">キー</param>
        /// <returns></returns>
        protected string GetIniFileValue(string section, string key)
        {
            return ini.GetString(section, key);
        }
        /// <summary>
        /// メッセージINIファイルの値を取得
        /// </summary>
        /// <param name="section">セクション</param>
        /// <param name="key">キー</param>
        /// <returns></returns>
        protected string GetMessageIniFileValue(string section, string key)
        {
            return myMsgIni.GetString(section, key);
        }
    }
}

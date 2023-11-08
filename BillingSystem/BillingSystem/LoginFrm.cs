using BillingSystem.BLL;
using BillingSystem.Common;
using BillingSystem.Models;
using Common;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class LoginFrm : Form
    {
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;
        public LoginFrm()
        {
            InitializeComponent();
            myMsgIni = new MyMessageIniFile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInfo.UserID = string.Empty;
                AccountInfo.UserName = string.Empty;
                AccountInfo.Password = string.Empty;
                //// DBアクセスサンプル
                //MyCommonBLL bll = new MyCommonBLL();
                //AccountModel inputData = new AccountModel();
                //inputData.UserID = this.TxtUserID.Text;
                //inputData.Password = this.TxtPassword.Text;
                //AccountModel AccountData = bll.GetAccoutInfo(inputData);

                //if(AccountData != null)
                //{
                //    // ログイン正常の場合、アカウント情報設定する
                //    AccountInfo.UserID = "DB値";
                //    AccountInfo.UserName = "DB値";
                //    AccountInfo.Password = "DB値";
                //    this.Hide();
                //    SeikyuFrm seikyu = new SeikyuFrm();
                //    seikyu.Show();
                //}
                //else
                //{
                //    string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0001);
                //    MessageBox.Show(msg); ;
                //}

                //if (this.TxtUserID.Text.Equals("test") && this.TxtPassword.Text.Equals("12345"))
                //{
                    // ログイン正常の場合、アカウント情報設定する
                    AccountInfo.UserID = "DB値";
                    AccountInfo.UserName = "DB値";
                    AccountInfo.Password = "DB値";
                    this.Hide();
                    SeikyuFrm seikyu = new SeikyuFrm();
                    seikyu.Show();
                //}
                //else
                //{
                //    string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0001);
                //    MessageBox.Show(msg); ;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }

        }
    }
}

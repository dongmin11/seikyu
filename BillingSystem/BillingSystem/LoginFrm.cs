using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BillingSystem.Common;

namespace BillingSystem
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string msg = "";
            if (TxtUserID.Text.TrimEnd() == "" || TxtPassword.Text.TrimEnd() == "")
            {
                MessageBox.Show("ログインIDまたはパスワードは不正です。");
                return;
            }
            //ログイン情報検索
            string sql = "SELECT * FROM M_User WHERE LoginID = '" + DataTypeChageUtil.ChangeString(TxtUserID.Text) + "'";
            sql += " AND Password = '" + PWDCodingUtil.Encrypt(this.TxtPassword.Text) + "'";
            DbAccessor dbAccessor = new DbAccessor();
            dbAccessor.Open();
            var userlist = dbAccessor.ExecuteReader(sql);
            if (userlist != null && userlist.Any())
            {
                LoginInfo.UserID = userlist[0]["LoginID"].ToString();
                LoginInfo.UserName = userlist[0]["UserName"].ToString();
                SeikyuFrm seikyu = new SeikyuFrm();
                seikyu.Show();
            }
            else
            {
                MessageBox.Show("ログインIDまたはパスワードは不正です。");
                return;
            }
            //DbAccessor dbAccessor = new DbAccessor();
            //dbAccessor.Open();
            //dbAccessor.BeginTransaction();

            ////sql更新
            ////sql更新            
            ////sql更新            
            ////sql更新            
            ////sql更新            
            ////sql更新            
            ////sql更新
            ////sql更新
            ////sql更新
            ////sql更新
            ////sql更新

            //dbAccessor.Commit();


            //SeikyuFrm seikyu = new SeikyuFrm();
            //seikyu.Show();
            //Form1 f = new Form1();
            //f.Show();
        }
    }
}

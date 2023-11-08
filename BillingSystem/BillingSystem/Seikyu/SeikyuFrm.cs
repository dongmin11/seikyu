using BillingSystem.BaseFrom;
using BillingSystem.Common;
using Common;
using System;

namespace BillingSystem
{
    public partial class SeikyuFrm : BaseFrm
    {
        public SeikyuFrm()
        {
            InitializeComponent();
            base.LblProcessName.Text = "請求書検索";
            base.LblLoginUserName.Text = AccountInfo.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ログ出力
            log.Info("test");
            // メッセージ取得
            string test = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0002);


        }
    }
}

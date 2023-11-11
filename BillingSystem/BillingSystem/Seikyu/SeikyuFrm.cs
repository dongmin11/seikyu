using BillingSystem.BaseFrom;
using BillingSystem.Common;
using Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static BillingSystem.Enumerations.EnumCls;
using BillingSystem.BLL;
using BillingSystem.Models;
using System.Linq;

namespace BillingSystem.Seikyu
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeikyuFrm : BillingSystem.BaseFrom.BaseFrm
    {
        SeikyuBLL BLL = new SeikyuBLL();
        int totalRecord = 0;
        int appearRecord = 0;
        public SeikyuFrm()
        {

            InitializeComponent();
            DgbBillingInfoGridView.AutoGenerateColumns = false;
            SeikyuBLL bll = new SeikyuBLL();

            // 請求先名称一覧取得
            CustomerModel customerInputData = new CustomerModel();
            List<CustomerModel> CustomerData = BLL.GetCustomerInfo(customerInputData);

            CustomerModel addData = new CustomerModel { CustomerName = "全て" };
            CustomerData.Insert(0, addData);

            CbbxBillingRecipient.DataSource = CustomerData;

            //請求一覧取得
            BillingModel inputData = new BillingModel();
            List<BillingModel> BillingData = BLL.GetBillingInfo(inputData);
            LblDisplayCount.Text =BillingData.Count.ToString();
          

            //データ成型
            dataFormat();

            //データバインド
            DgbBillingInfoGridView.DataSource = BillingData;

            base.LblProcessName.Text = "請求書検索";
            base.LblLoginUserName.Text = AccountInfo.UserName;

            //開始日時の初期値を今月の1日
            DtbBillingStartDate.Format = DateTimePickerFormat.Custom;
            DtbBillingStartDate.CustomFormat = "yyyy年MM月dd日";
            DtbBillingStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DtbBillingEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            DtbBillingStartDate.Text = DtbBillingStartDate.Value.ToString("yyyy年MM月dd日");

            //終了日時の初期値を今月の最終日に
            DtbBillingEndDate.Format = DateTimePickerFormat.Custom;
            DtbBillingEndDate.CustomFormat = "yyyy年MM月dd日";
            DateTime today = DateTime.Today;
            DtbBillingEndDate.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            DtbBillingEndDate.Text = DtbBillingEndDate.Value.ToString("yyyy年MM月dd日");

            //総表示数
            AllCountModel param = new AllCountModel();
            List<AllCountModel> AllCount = BLL.GetAllInfo(param);
            LblTotalCount.Text = AllCount.Count.ToString();

        }
        /// <summary>
        /// 検索機能ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton(object sender, EventArgs e)
        {
            //請求開始日時取得
            string billingStartDateText = DtbBillingStartDate.Text;
            DateTime billingStartDate = DateTime.Parse(billingStartDateText);
            billingStartDateText = billingStartDate.ToString("yyyy-MM-dd");

            //請求終了日時取得
            string billingEndDateText = DtbBillingEndDate.Text;
            DateTime billingEndDate = DateTime.Parse(billingEndDateText);
            billingEndDateText = billingEndDate.ToString("yyyy-MM-dd");

            //選択された請求先取得
            string selectedBillingRecipient = CbbxBillingRecipient.Text;

            //請求一覧取得
            SearchBillingModel inputData = new SearchBillingModel();
            inputData.DeleteFlag = CkbxShowDeleted.Checked.ToString();
            inputData.StartDate = billingStartDateText;
            inputData.EndDate = billingEndDateText;
            inputData.CustomerName = selectedBillingRecipient;

            List<SearchBillingModel> BillingData = BLL.SearchGetBillingInfo(inputData);
            LblDisplayCount.Text = BillingData.Count.ToString();

            DgbBillingInfoGridView.DataSource = BillingData;

        }

        /// <summary>
        /// グリットビューのデータフォーマットを整える
        /// </summary>
        public void dataFormat()
        {
            foreach (DataGridViewColumn column in DgbBillingInfoGridView.Columns)
            {
                if (column.DataPropertyName == "BillingNo" || column.DataPropertyName == "BillingAmount" || column.DataPropertyName == "BillingTax" || column.DataPropertyName == "TransportationAmount" || column.DataPropertyName == "BillingTotal" || column.DataPropertyName == "PaymentType")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = "N0";
                }
                else if (column.DataPropertyName == "CustomerName")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }


        private void changeStartDate(object sender, EventArgs e)
        {
            DateTime startDate = DtbBillingStartDate.Value;
            DtbBillingEndDate.MinDate = startDate;
        }

        private void BtnNextButton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void BtnPreviousButton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}

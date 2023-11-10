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


namespace BillingSystem.Seikyu
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeikyuFrm : BillingSystem.BaseFrom.BaseFrm
    {
        MyCommonBLL BLL = new MyCommonBLL();
        int totalRecord = 0;
        int appearRecord = 0;
        public SeikyuFrm()
        {

            InitializeComponent();
            DgbBillingInfoGridView.AutoGenerateColumns = false;
            SeikyuBLL bll = new SeikyuBLL();

            // SQLクエリ
            CustomerModel customerInputData = new CustomerModel();
            List<CustomerModel> CustomerData = BLL.GetCustomerInfo(customerInputData);

            //CustomerModel addData = new CustomerModel { CustomerName = "全て" };
            //CustomerData.Insert(0, addData);

            CbbxBillingRecipient.DataSource = CustomerData;


            //請求一覧取得
            BillingModel inputData = new BillingModel();
            List<BillingModel> BillingData = BLL.GetBillingInfo(inputData);

            //表示件数
            //LblDisplayCount.Text = (bills.Rows.Count).ToString();

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

            //query = "SELECT ID FROM T_Billing";

            //総表示数
            //DataTable total = bll.ExecuteQuery(query);
            string columnName = "ID";
            //object count = total.Compute("COUNT(" + columnName + ")", "");
            //int elementCount = Convert.ToInt32(count);
            //LblTotalCount.Text = elementCount.ToString();

        }

        private void searchButton(object sender, EventArgs e)
        {
            //請求開始日時取得
            string billingStartDateText = DtbBillingStartDate.Text;
            DateTime billingStartDate = DateTime.Parse(billingStartDateText);
            billingStartDateText = billingStartDate.ToString("yyyy-MM-d");

            //請求終了日時取得
            string billingEndDateText = DtbBillingEndDate.Text;
            DateTime billingEndDate = DateTime.Parse(billingEndDateText);
            billingEndDateText = billingEndDate.ToString("yyyy-MM-d");

            //選択された請求先取得
            string selectedBillingRecipient = CbbxBillingRecipient.Text;
            //selectedBillingRecipient = selectedBillingRecipient;

            //請求一覧取得
            SearchBillingModel inputData = new SearchBillingModel();
            inputData.StartDate = DateTime.Parse(billingStartDateText);
            inputData.EndDate = DateTime.Parse(billingEndDateText); ;
            inputData.CustomerName = selectedBillingRecipient;

            List<SearchBillingModel> BillingData = BLL.SearchGetBillingInfo(inputData);

            if (CbbxBillingRecipient.SelectedItem.ToString() == "全て")
            {
                selectedBillingRecipient = "CustomerName";
            }

            string appearCheck = null;
            string showDeleted = CkbxShowDeleted.Checked.ToString();

            DgbBillingInfoGridView.DataSource = BillingData;

            //削除済み表示確認
            if (showDeleted == disappearDeleted.Name)
            {
                appearCheck = disappearDeleted.Id.ToString();
            }else if(showDeleted == appearDeleted.Name) 
            {
                appearCheck = appearDeleted.ShortName;
            }

            //string query = $@"SELECT
            //                [BillingDate]
            //                , [BillingNo]
            //                , [BranchNo]
            //                , [CustomerName]
            //                , [PaymentType]
            //                , [BillingAmount]
            //                , [BillingTax]
            //                , [TransportationAmount]
            //                , [BillingTotal]
            //            FROM
            //                [dbo].[T_Billing] 
            //            WHERE
            //                BillingDate BETWEEN '{billingStartDateText}' AND '{billingEndDateText}' 
            //                AND DeleteFlag = '0' 
            //                AND CustomerName = {selectedBillingRecipient}";

            SeikyuBLL bll = new SeikyuBLL();
            //DataTable bills = bll.ExecuteQuery(query);
            //LblDisplayCount.Text = (bills.Rows.Count).ToString();

            //DgbBillingInfoGridView.DataSource = bills;

            // ログ出力
            log.Info("test");
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

    }
}

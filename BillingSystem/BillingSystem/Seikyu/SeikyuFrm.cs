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


namespace BillingSystem
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeikyuFrm : BaseFrm
    {
        int totalRecord = 0;
        int appearRecord = 0;
        public SeikyuFrm()
        {
            InitializeComponent();

            //コンボボックスに追加
            CbbxBillingRecipient.Items.Add("全て");
            CbbxBillingRecipient.SelectedItem = "全て";
            
            // SQLクエリ
            string query = "SELECT CustomerName FROM M_Customer";

            DataTable sql = ExecuteQuery(query);


            foreach (DataRow row in sql.Rows)
            {
                // Dictionary内の特定のキーを指定して値を取得し、コンボボックスに追加
                if (row.Table.Columns.Contains("CustomerName")) 
                {
                    CbbxBillingRecipient.Items.Add(row["CustomerName"].ToString()); 
                }
            }

            query = @"SELECT
                        [BillingDate]
                        , [BillingNo]
                        , [BranchNo]
                        , [CustomerName]
                        , [PaymentType]
                        , [BillingAmount]
                        , [BillingTax]
                        , [TransportationAmount]
                        , [BillingTotal]
                                FROM
                        [dbo].[T_Billing] ";

            DataTable bills = ExecuteQuery(query);

            //表示件数
            LblDisplayCount.Text = (bills.Rows.Count).ToString();

            dataFormat();

            //データバインド
            DgbBillingInfoGridView.DataSource =bills;

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

            query = "SELECT ID FROM T_Billing";

            //総表示数
            DataTable total = ExecuteQuery(query);
            string columnName = "ID";
            object count = total.Compute("COUNT(" + columnName + ")", "");
            int elementCount = Convert.ToInt32(count);
            LblTotalCount.Text = elementCount.ToString();

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
            var selectedBillingRecipient = CbbxBillingRecipient.SelectedItem.ToString();
            selectedBillingRecipient = $"\'{selectedBillingRecipient}\'";

            if(CbbxBillingRecipient.SelectedItem.ToString() == "全て")
            {
                selectedBillingRecipient = "CustomerName";
            }

            string appearCheck = null;
            string showDeleted = CkbxShowDeleted.Checked.ToString();

            //削除済み表示確認
            if(showDeleted == disappearDeleted.Name)
            {
                appearCheck = disappearDeleted.Id.ToString();
            }else if(showDeleted == appearDeleted.Name) 
            {
                appearCheck = appearDeleted.ShortName;
            }

            string query = $@"SELECT
                            [BillingDate]
                            , [BillingNo]
                            , [BranchNo]
                            , [CustomerName]
                            , [PaymentType]
                            , [BillingAmount]
                            , [BillingTax]
                            , [TransportationAmount]
                            , [BillingTotal]
                        FROM
                            [dbo].[T_Billing] 
                        WHERE
                            BillingDate BETWEEN '{billingStartDateText}' AND '{billingEndDateText}' 
                            AND DeleteFlag = '0' 
                            AND CustomerName = {selectedBillingRecipient}";

            DataTable bills = ExecuteQuery(query);
            LblDisplayCount.Text = (bills.Rows.Count).ToString();

            DgbBillingInfoGridView.DataSource = bills;

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

        /// <summary>
        /// SQLに接続してパラメータで受け取ったクエリを実行
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();
            string connectionString = "Data Source=10.20.1.9;Initial Catalog=SEIKYUSHO_TEST;User ID=sa;Password=meisen@2022";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //テーブルヘッダー追加
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                if (columnName == "BranchNo")
                                {
                                    continue;
                                }
                                resultTable.Columns.Add(reader.GetName(i));
                                totalRecord++;
                            }

                            while (reader.Read())
                            {
                                // データリーダーの行をデータテーブルに追加
                                DataRow row = resultTable.NewRow();
                                //テーブル中身追加
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);
                                    if(columnName == "BranchNo")
                                    {
                                        continue;
                                    }
                                    object value = reader[i];

                                    // 数値データをカンマを挿入した文字列に変換
                                    if (value is decimal || value is int)
                                    {
                                        row[columnName] = string.Format("{0:N0}", value);
                                    }
                                    else if(value is DateTime){
                                        row[columnName] = ((DateTime)value).ToString("yyyy/MM/dd");
                                        appearRecord++;
                                    }
                                    else
                                    {
                                        row[columnName] = value; // 数値以外はそのままセット
                                    }


                                }
                                appearRecord = reader.FieldCount;
                                resultTable.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // エラーハンドリング
                log.Info(ex.Message);
                Console.WriteLine("エラー: " + ex.Message);
            }

            return resultTable;
        }

        private void changeStartDate(object sender, EventArgs e)
        {
            DateTime startDate = DtbBillingStartDate.Value;
            DtbBillingEndDate.MinDate = startDate;
        }

    }
}

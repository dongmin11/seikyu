using BillingSystem.BaseFrom;
using BillingSystem.Common;
using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BillingSystem
{
    public partial class SeikyuFrm : BaseFrm
    {
        public SeikyuFrm()
        {
            InitializeComponent();

    
            
            // SQLクエリ
            string query = "SELECT CustomerName FROM M_Customer";

            List<Dictionary<string, object>> sql = ExecuteQuery(query);

            foreach (var row in sql)
            {
                // Dictionary内の特定のキーを指定して値を取得し、コンボボックスに追加
                if (row.ContainsKey("CustomerName")) 
                {
                    BillingRecipient.Items.Add(row["CustomerName"]); 
                }
            }

            query = "SELECT\r\n    [BillingDate]" +
                "                              \r\n    , [BillingNo]" +
                "                               \r\n    , [CustomerName]" +
                "                            \r\n    , [PaymentType]" +
                "                             \r\n    , [BillingAmount]" +
                "                           \r\n    , [BillingTax]" +
                "                              \r\n    , [TransportationAmount]" +
                "                    \r\n    , [BillingTotal]" +
                "                            \r\nFROM\r\n    [dbo].[T_Billing] ";

            List<Dictionary<string,object>> bills = ExecuteQuery(query);


            DataTable dataTable = new DataTable();

            // billsの最初の要素から列を作成
            if (bills.Count > 0)
            {
                foreach (var key in bills[0].Keys)
                {
                    dataTable.Columns.Add(key, typeof(object)); // 適切なデータ型を指定
                }

                // billsの各行をDataTableに追加
                foreach (var row in bills)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var key in row.Keys)
                    {
                        dataRow[key] = row[key];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            //データバインド
            BillingInfoGridView.DataSource =dataTable;

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

        /// <summary>
        /// SQLに接続してパラメータで受け取ったクエリを実行
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
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
                            while (reader.Read())
                            {
                                Dictionary<string, object> row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);
                                    object value = reader[i];
                                    row[columnName] = value;
                                }
                                result.Add(row);
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

            return result;
        }


    }
}

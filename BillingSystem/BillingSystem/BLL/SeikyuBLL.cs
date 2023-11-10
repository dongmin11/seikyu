using BillingSystem.DAL;
using Common.BLL;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Configuration;
using BillingSystem.Common;

namespace BillingSystem.BLL
{
    public class SeikyuBLL : CommonBLL
    {
        SeikyuDAL dal = new SeikyuDAL();

        public DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();
            //string connectionString = "Data Source=10.20.1.9;Initial Catalog=SEIKYUSHO_TEST;User ID=sa;Password=meisen@2022";

            try
            {
                using (SqlConnection connection = new SqlConnection())
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
                            }

                            while (reader.Read())
                            {
                                // データリーダーの行をデータテーブルに追加
                                DataRow row = resultTable.NewRow();
                                //テーブル中身追加
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);
                                    if (columnName == "BranchNo")
                                    {
                                        continue;
                                    }
                                    object value = reader[i];

                                    // 数値データをカンマを挿入した文字列に変換
                                    if (value is decimal || value is int)
                                    {
                                        row[columnName] = string.Format("{0:N0}", value);
                                    }
                                    else if (value is DateTime)
                                    {
                                        row[columnName] = ((DateTime)value).ToString("yyyy/MM/dd");

                                    }
                                    else
                                    {
                                        row[columnName] = value; // 数値以外はそのままセット
                                    }
                                }
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
    }


}

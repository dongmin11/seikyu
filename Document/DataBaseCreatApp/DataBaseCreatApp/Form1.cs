using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using System;
using System.IO;
using System.Text;

namespace DataBaseCreatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SansyoBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "エクセルファイル|*.xlsx;*.lsx";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                this.FilePathTxt.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.FilePathTxt.Text))
            {
                return;
            }

            List<string> taisyogaiSheetNames = new List<string> { "改訂履歴", "説明" };
            //既存のExcelブックを読み込む
            IWorkbook book = WorkbookFactory.Create(this.FilePathTxt.Text);
            //シート数
            int sheetCnt = book.NumberOfSheets;

            for (int cnt = 0; cnt < sheetCnt; cnt++)
            {
                //履歴、説明シート対象外
                if (!taisyogaiSheetNames.Contains(book.GetSheetAt(cnt).SheetName))
                {
                    ISheet sheet = book.GetSheetAt(cnt);
                    List<string> tableSql = this.CreatTableSql(sheet);
                    this.CreatSqlFile(sheet.SheetName, tableSql); ;
                }
            }
        }

        private List<string> CreatTableSql(ISheet sheet)
        {
            List<string> sqlStr = new List<string>();
            //スキーマ
            string schema = this.GetCellData(sheet, 5, 7);
            if (schema == "") schema = "XXXX";
            //テーブル名
            var tableNm = this.GetCellData(sheet, 6, 2);

            sqlStr.Add("USE[データベース名]");
            sqlStr.Add("GO");
            sqlStr.Add("");
            sqlStr.Add("/****** Object:  Table [" + schema + "].[" + tableNm + "]    Script Date: "+ DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +" ******/");
            sqlStr.Add("SET ANSI_NULLS ON");
            sqlStr.Add("GO");
            sqlStr.Add("");
            sqlStr.Add("SET QUOTED_IDENTIFIER ON");
            sqlStr.Add("GO");
            sqlStr.Add("");

            // テーブル定義作成
            sqlStr.Add("CREATE TABLE [" + schema + "].[" + tableNm + "](");
            for (int rowNo = 9; rowNo < 999; rowNo++)
            {
                string colunmKey = this.GetCellData(sheet, rowNo, 2);
                if (colunmKey == "") { break; }
                string tableColmninfo = CreatTabelColumnInfo(sheet, rowNo);

                colunmKey = this.GetCellData(sheet, rowNo+ 1, 2);
                sqlStr.Add("	" + tableColmninfo);
            }

            // 主キー設定
            for (int rowNo = 9; rowNo < 999; rowNo++)
            {
                string colunmKey = this.GetCellData(sheet, rowNo, 2);
                if (colunmKey == "") { break; }
                string pkFlg = this.GetCellData(sheet, rowNo, 3);
                if (pkFlg == "○")
                {
                    sqlStr.Add("	CONSTRAINT PK_" + tableNm + " PRIMARY KEY CLUSTERED ([" + colunmKey + "] ASC) WITH (");
                    sqlStr.Add("		 PAD_INDEX = OFF,");
                    sqlStr.Add("		 STATISTICS_NORECOMPUTE = OFF,");
                    sqlStr.Add("		 IGNORE_DUP_KEY = OFF,");
                    sqlStr.Add("		 ALLOW_ROW_LOCKS = ON,");
                    sqlStr.Add("		 ALLOW_PAGE_LOCKS = ON,");
                    sqlStr.Add("		 OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF");
                    sqlStr.Add("		) ON[PRIMARY]");
                    sqlStr.Add("	) ON[PRIMARY]");
                    sqlStr.Add("GO");
                }
            }

            //コメント

            // ↓↓↓↓↓↓↓↓↓↓↓↓↓↓  SQLServer　コメント作成
            // キー設定
            for (int rowNo = 9; rowNo < 999; rowNo++)
            {
                string colunmKey = this.GetCellData(sheet, rowNo, 2);
                if (colunmKey == "") { break; }

                if (this.GetCellData(sheet, rowNo, 1) != "")
                {
                    sqlStr.Add("EXEC sys.sp_addextendedproperty @name = N'MS_Description', @value = N'" + this.GetCellData(sheet, rowNo, 1) + "' , @level0type = N'SCHEMA',@level0name = N'" + schema + "', @level1type = N'TABLE',@level1name = N'" + tableNm + "', @level2type = N'COLUMN',@level2name = N'"+ colunmKey +"'");
                    sqlStr.Add("GO");
                    sqlStr.Add("");
                }

            }
            // テーブル名
            if (this.GetCellData(sheet, 5, 7) != "")
            {
                sqlStr.Add("EXEC sys.sp_addextendedproperty @name = N'MS_Description', @value = N'" + this.GetCellData(sheet, 5, 2) + "' , @level0type = N'SCHEMA',@level0name = N'" + schema + "', @level1type = N'TABLE',@level1name = N'" + tableNm + "'");
                sqlStr.Add("GO");
                sqlStr.Add("");
            }
            // ↑↑↑↑↑↑↑↑↑↑↑↑↑↑ SQLServer　コメント作成

            // ↓↓↓↓↓↓↓↓↓↓↓↓↓↓ PostgreSql　コメント作成
            //// テーブル名
            //if (this.GetCellData(sheet, 5, 7) != "")
            //{
            //    sqlStr.Add("/");
            //    sqlStr.Add("COMMENT ON TABLE [" + schema + "].[" + tableNm + "] IS '" + this.GetCellData(sheet, 5, 2) + "'");
            //}

            //// 主キー設定
            //for (int rowNo = 9; rowNo < 999; rowNo++)
            //{
            //    string colunmKey = this.GetCellData(sheet, rowNo, 2);
            //    if (colunmKey == "") { break; }

            //    if (this.GetCellData(sheet, rowNo, 1) != "")
            //    {
            //        sqlStr.Add("/");
            //        sqlStr.Add("COMMENT ON TABLE [" + schema + "].[" + tableNm + "].[" + colunmKey + "] IS '" + this.GetCellData(sheet, rowNo, 1) + "'");
            //    }

            //}
            // ↑↑↑↑↑↑↑↑↑↑↑↑↑↑ PostgreSql　コメント作成
            return sqlStr;
        }

        private string CreatTabelColumnInfo(ISheet sheet, int rowNo)
        {
            string value = "";
            // 列物理名
            value += "[" + this.GetCellData(sheet, rowNo, 2) + "]";
            // 型
            string dataType = this.GetCellData(sheet, rowNo, 4);
            value += " [" + dataType + "]";
            if (dataType == "bigint" && this.GetCellData(sheet, rowNo, 3) == "○")
            {
                value += " identity(1, 1)";
            }

            // 桁数
            if (dataType == "decimal" || dataType == "numeric")
            {
                //桁数
                string keta = this.GetCellData(sheet, rowNo, 5);
                //少数点
                string syousu = this.GetCellData(sheet, rowNo, 6);

                value += " (" + keta + "," + syousu + ")";
            }
            else
            {
                //桁数
                if (dataType != "int")
                {
                    if (this.GetCellData(sheet, rowNo, 5) != "")
                    {
                        value += " (" + this.GetCellData(sheet, rowNo, 5) + ")";
                    }
                }
            }

            // NULL許可
            string nullKyoka = this.GetCellData(sheet, rowNo, 7);
            if (nullKyoka == "○")
            {
                value += " NULL";
            }
            else
            {
                value += " NOT NULL";
            }

            //DEFAULT (0) 初期値
            string defaultVal = this.GetCellData(sheet, rowNo, 8);
            if (defaultVal != "")
            {
                value += " DEFAULT (" + defaultVal + ")";
            }
            value += ",";
            return value;
        }

        private string GetCellData(ISheet sheet, int rowNo, int colNo)
        {
            if (sheet.GetRow(rowNo) == null)
            {
                return "";
            }

            if (sheet.GetRow(rowNo).GetCell(colNo) == null)
            {
                return "";
            }

            //セルの型に応じたプロパティを参照する
            ICell cell = sheet.GetRow(rowNo).GetCell(colNo);
            switch (cell.CellType)
            {
                case CellType.String: return cell.StringCellValue;
                case CellType.Numeric:
                    return cell.NumericCellValue.ToString();
                case CellType.Boolean: return cell.BooleanCellValue.ToString();
                case CellType.Formula: return cell.StringCellValue;
                default: return "";
            }
        }

        private void CreatSqlFile(string fileNm, List<string> tableSql)
        {
            if (tableSql != null && tableSql.Any())
            {
                Encoding enc = Encoding.GetEncoding("UTF-8");
                using (StreamWriter writer = new StreamWriter("./Creat_"+ fileNm +".txt", false, enc))
                {
                    foreach (string s in tableSql)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using CodeEngne.Loader.AppDBDataSetTableAdapters;
using System.Data.SqlServerCe;

namespace CodeEngne.Loader
{
    class Program
    {
        static void Main(string[] args)
        {

            LoadExcel();

        }

        public static void LoadExcel()
        {
            #region Variables

            List<DataTable> tables = new List<DataTable>();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\mklanguage.xls;Extended Properties=""Excel 8.0;HDR=YES;""";
            string[] sheets = new string[]{
                "B-ส่วนผสมสินค้า",
                "F-เมนูแนะนำ",
                "H-Price&Promotion",
                "C-เกี่ยวกับ Mk",
                "E-สมาชิก MK",
                "G- Map",
                "G 1Map(สอบถามอื่นๆ)",
                "G 2Map(ศูนย์การค้า)",
                "G 3Map(ทีพัก)",
                "J 1คำศัพท์(Hygiene)",
                "J 2คำศัพท์(อุปกรณ์ทาน)",
                "J 3คำศัพท์(เครื่องเคียง)",
                "J 4คำศัพท์(Drink)",
                "J 5คำศัพท์(Other)",
                "D1 ข้อเสนอแนะ(สินค้า)",
                "D2ข้อเสนอนะ(ราคา)",
                "D3ข้อเสนอแนะ(บริการ)",
                "D4ข้อเสนอแนะ(สภาพ้ราน)",
                "I 5Conver(ใช้บ่อย)",
                "K- มาตรฐานสนทนาMK",
                "K 1มาตรฐานสนทนา(Well Com)",
                "K 2มาตรฐานสนทนา(แนะนำ)",
                "K 3มาตรฐานสนทนา(เสิร์ฟ)",
                "K 4 บริการบนโต๊ะ",
                "K 5 แนะนำอาหาร",
                "labels"
            };

            #endregion Variables
            List<string> commands = new List<string>();

            /*Clean data*/
            CleanData(new DataDictionaryTableAdapter().Connection.ConnectionString);
            
            /*Update data*/
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
                connection.Open();
                foreach (var i in sheets)
                {
                    DataTable tbl = new DataTable();
                    OleDbCommand cmd = new OleDbCommand(
                        string.Format("select * from [{0}$]", i), connection
                    );

                    tbl.Load(cmd.ExecuteReader());
                    int indexOfSQLBATCH = tbl.Columns.IndexOf("SQL BATCH");
                    if (indexOfSQLBATCH > -1)
                    {
                        tbl.Columns.RemoveAt(indexOfSQLBATCH);
                    }
                    tables.Add(tbl);
                }
            }

            DataDictionaryTableAdapter adapter = new DataDictionaryTableAdapter();
            CodeEngne.Loader.AppDBDataSet.DataDictionaryDataTable tblDictionary = new AppDBDataSet.DataDictionaryDataTable();
            int counter = 0;
            foreach (DataTable i in tables)
            {
                foreach (DataRow j in i.Rows)
                {
                    object[] jItems = new object[10];
                    jItems[0] = ++counter;
                    Array.ConstrainedCopy(j.ItemArray, 0, jItems, 1, 9);
                    tblDictionary.Rows.Add(jItems);
                }
            }
            adapter.Update(tblDictionary);

        }

        private static void CleanData(string connectionString)
        {
            using (SqlCeConnection con = new SqlCeConnection(connectionString))
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                con.Open();

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.Connection = con;
                cmd.Transaction = con.BeginTransaction();
                cmd.CommandText = @"delete from DataDictionary;";
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using CodeEngne.Loader.AppDBDataSetTableAdapters;
using System.Data.SqlServerCe;
using System.Configuration;

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
            string connectionString = string.Format(
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;""",
                ConfigurationManager.AppSettings["EXCEL_PATH"]
                );
            string[] sheets = ConfigurationManager.AppSettings["SHEETS"].Split(',').Select(f => f.Trim()).ToArray();

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
                    try
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
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
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

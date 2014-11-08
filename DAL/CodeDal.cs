using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class CodeDal
    {


        public static DataTable GetCodeById(int CodeId)
        {
              DataTable dt =new DataTable();

            string Sql="select * from Code Where CodeId="+CodeId.ToString();
            using (SQLiteConnection conn = new SQLiteConnection(Connection.GetConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                  

                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        dt = sh.Select(Sql);
                        //  dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        dt = new DataTable();
                        dt.Columns.Add("Error");
                        dt.Rows.Add(ex.ToString());
                        //  dataGridView1.DataSource = dt;
                    }

                    conn.Close();
                }

                return dt;
            }
        }

    }
}

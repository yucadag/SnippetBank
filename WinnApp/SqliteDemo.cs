using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinnApp
{
    public partial class SqliteDemo : Form
    {
        public SqliteDemo()
        {
            InitializeComponent();
        }

        private void SqliteDemo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

          // dt= GetDataTable("Select * from abc ; ");
            dt=CodeDal.GetCodeById(1);


           this.Text = dt.Rows[0][1].ToString();
        }

        String dbConnection=@"data source=D:\GitHub\SnippetBank\SnippetBank\WinnApp\Database.s3db";

	


        
	

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }
	
    }
}

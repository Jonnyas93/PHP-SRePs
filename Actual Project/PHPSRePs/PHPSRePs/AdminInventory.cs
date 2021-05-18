using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class adminInventory : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection sqlite_conn;
        double TotalSales = 0;

        public adminInventory()
        {
            InitializeComponent();
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= " + Environment.GetEnvironmentVariable("connString") + ";" + " Version=3;");
            //sqlite_conn = new SQLiteConnection("Data Source= {AppDir}/PHPSRePs; Version=3;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return sqlite_conn;
        }

        private void btnAdminInventoryBack_Click(object sender, EventArgs e)
        {
            AdminMenuForm admin = new AdminMenuForm();
            this.Hide();
            admin.Show();
        }
        
        //Data viewing box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminInventory_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdminInventoryDateAdded_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminInventorySearch_Click(object sender, EventArgs e)
        {
            //SQLite connection and access
            sqlite_conn = CreateConnection();
            SQLiteDataReader sqlite_dataReader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            //sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE month = '{0}' AND year ='{1}';", selectedMonth, selectedYear);
            sqlite_cmd.CommandText = String.Format("SELECT * FROM inventory;");
            SQLiteDataAdapter inventdata = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable("Inventory");
            inventdata.Fill(dt);
            grdAdminInventory.DataSource = dt.DefaultView;
        }
    }
}

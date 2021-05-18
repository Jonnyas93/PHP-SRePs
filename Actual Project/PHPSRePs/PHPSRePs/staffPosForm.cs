using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace PHPSRePs
{
    public partial class staffPosForm : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection sqlite_conn;
        DateTime dateToDisplay = new DateTime(2021, 5, 18, 8, 42, 50);

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= " + Environment.GetEnvironmentVariable("connString") + ";" + " Version=3;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
        static void AddSale(SQLiteConnection conn, int productID, int userID, DateTime saleDate, int stock, int saleNumber)
        {

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "INSERT INTO Sales([product_id], [user_id], [datetime], [quantity], [sales_number]) VALUES(@productID, @userID, @saleDate, @stock, @saleNumber);";
            sqlite_cmd.CommandText = msg;//"INSERT INTO tblActivity ([Activity_Category], [Activity_Category_Sub], [Activity_Start], [Activity_End], [Activity_Duration]) VALUES (@ActivityCategory, @ActivityCategorySub, @ActivityStart, @ActivityEnd, @ActivityDuration);";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@productID", productID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@userID", userID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleDate", saleDate));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleNumber", saleNumber));
            sqlite_cmd.ExecuteNonQuery();
        }
        static void EditSale(SQLiteConnection conn, int saleID, int productID, int userID, DateTime saleDate, int stock, int saleNumber)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "UPDATE Sales SET product_id = @productID, user_id = @userID, datetime = @saleDate, quantity = @stock, sales_number = @saleNumber WHERE sales_id = @saleID;";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@productID", productID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@userID", userID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleDate", saleDate));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleNumber", saleNumber));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleID", saleID));
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void DeleteSaleEl(SQLiteConnection conn, int ID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "DELETE FROM Sales WHERE sales_id = " + ID + ";";
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void DeleteSale(SQLiteConnection conn, int ID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "DELETE FROM Sales WHERE sales_number = " + ID + ";";
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        public staffPosForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void staffPosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPosSearchForAnItem_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = CreateConnection();

                SQLiteDataReader sqlite_dataReader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();

                //sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE month = '{0}' AND year ='{1}';", selectedMonth, selectedYear);
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE sales_id = " + txtBxSaleID.Text + ";");
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable("Sales");
                sda.Fill(dt);
                posItemsGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnStaffPosLogout_Click(object sender, EventArgs e)
        {
            AdminMenuForm adminForm = new AdminMenuForm();
            this.Hide();
            adminForm.Show();
        }

        private void lblPosItemName_Click(object sender, EventArgs e)
        {

        }

        private void btnPosItemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = CreateConnection();
                
                AddSale(sqlite_conn, Convert.ToInt32(txtPosItemNo.Text), 1, dateToDisplay, Convert.ToInt32(txtPosNumberOfItems.Text), Convert.ToInt32(txtPosSaleNumber.Text));
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {

            try
            {
                sqlite_conn = CreateConnection();

                SQLiteDataReader sqlite_dataReader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();

                //sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE month = '{0}' AND year ='{1}';", selectedMonth, selectedYear);
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE sales_number = " + txtPosSaleNumber.Text + ";");
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable("Sales");
                sda.Fill(dt);
                posItemsGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeleteSaleEl_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = CreateConnection();
                DeleteSaleEl(sqlite_conn, Convert.ToInt32(txtBxSaleID.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = CreateConnection();
                DeleteSale(sqlite_conn, Convert.ToInt32(txtPosSaleNumber.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSale_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = CreateConnection();
                EditSale(sqlite_conn, Convert.ToInt32(txtBxSaleID.Text), Convert.ToInt32(txtPosItemNo.Text), 1, dateToDisplay, Convert.ToInt32(txtPosNumberOfItems.Text), Convert.ToInt32(txtPosSaleNumber.Text));
            }
            catch (Exception ex)
            {

            }
        }
    }
}

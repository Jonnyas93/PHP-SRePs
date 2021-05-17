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
    public partial class MonthlySalesReport : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection sqlite_conn;
        string selectedMonth;
        string selectedYear;
        double TotalSales = 0;

        //public class Sales
        //{
        //  public double total { get; set; }
        //}
        public MonthlySalesReport()
        {
            InitializeComponent();
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= G:/Documents/Managing IT Project/Repo/UI Project/PHPSRePs/PHPSRePs/PHP.db;" + " Version=3;");
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

        private void btnSalesReportClear_Click(object sender, EventArgs e)
        {
            SalesReportMonth.Text = "";
            SalesReportYear.Text = "";
        }

        private void btnSalesReportBack_Click(object sender, EventArgs e)
        {
            AdminMenuForm admin = new AdminMenuForm();
            this.Hide();
            admin.Show();
        }

        private void btnSalesReportGenerate_Click(object sender, EventArgs e)
        {
            sqlite_conn = CreateConnection();

            SQLiteDataReader sqlite_dataReader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            selectedMonth = this.SalesReportMonth.GetItemText(this.SalesReportMonth.SelectedItem);
            selectedYear = this.SalesReportYear.GetItemText(this.SalesReportYear.SelectedItem);


            //sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales WHERE month = '{0}' AND year ='{1}';", selectedMonth, selectedYear);
            sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales;");
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable("Sales");
            sda.Fill(dt);
            grdSalesReport.DataSource = dt.DefaultView;



            // var sales = new List<Sales>();

            using (sqlite_conn)
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Sales;");
                using (sqlite_dataReader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_dataReader.Read())
                    {

                        TotalSales = TotalSales + Convert.ToDouble(sqlite_dataReader["quantity"]);

                    }
                }

            }

            lblTotalSales.Text = TotalSales.ToString();



        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {

           
                if (grdSalesReport.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "CSV (*.csv)|*.csv";
                    sfd.FileName = "Output.csv";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                int columnCount = grdSalesReport.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[grdSalesReport.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += grdSalesReport.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; i  < grdSalesReport.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += grdSalesReport.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }
            

        }
    }
}

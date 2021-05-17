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
    public partial class InventoryReport : MetroFramework.Forms.MetroForm
    {
        SQLiteConnection sqlite_conn;
        public InventoryReport()
        {
            InitializeComponent();
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= C:/Users/lakda/Desktop/PHPSRePs/PHPSRePs/PHPSRePs/PHP.db;" + " Version=3;");
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

        private void btnInventoryReportBack_Click(object sender, EventArgs e)
        {
            AdminMenuForm admin = new AdminMenuForm();
            this.Hide();
            admin.Show();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            sqlite_conn = CreateConnection();

            SQLiteDataReader sqlite_dataReader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = String.Format("SELECT * FROM inventory");
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable("Inventory");
            sda.Fill(dt);
            grdInventoryReport.DataSource = dt.DefaultView;

            sqlite_cmd.CommandText = String.Format("SELECT * FROM inventory WHERE quantity <= 10");
            SQLiteDataAdapter sdaLow = new SQLiteDataAdapter(sqlite_cmd);
            DataTable data = new DataTable("InventoryLowStock");
            sda.Fill(data);
            grdLowStock.DataSource = data.DefaultView;
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            if (grdInventoryReport.Rows.Count > 0)
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
                            int columnCount = grdInventoryReport.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[grdInventoryReport.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += grdInventoryReport.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < grdInventoryReport.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += grdInventoryReport.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (grdLowStock.Rows.Count > 0)
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
                            int columnCount = grdLowStock.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[grdLowStock.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += grdLowStock.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < grdLowStock.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += grdLowStock.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
   



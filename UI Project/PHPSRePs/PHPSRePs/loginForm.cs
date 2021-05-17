using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace PHPSRePs
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        string userName;
        string password;
        SQLiteConnection sqlite_conn;

       
        public loginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= C:/Users/lakda/Desktop/PHPSRePs/PHPSRePs/PHPSRePs/PHP.db;" + " Version=3;");
            try
            {
                sqlite_conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return sqlite_conn;
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            sqlite_conn = CreateConnection();

            SQLiteDataReader sqlite_dataReader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();


            userName = txtLoginUsername.Text;
            password = txtLoginPassword.Text;
            if (userName == "admin" && password == "admin")
            {
                AdminMenuForm adminForm = new AdminMenuForm();
                this.Hide();
                adminForm.Show();

            }
            else
            {
               /* sqlite_cmd.CommandText = String.Format( "SELECT count(*) FROM user WHERE user_name = {0}",userName);
                int count = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
                if (count == 1)
                {*/
                    sqlite_cmd.CommandText = String.Format("SELECT password FROM User WHERE user_name = {0};", userName);
                    sqlite_dataReader = sqlite_cmd.ExecuteReader();
                    while (sqlite_dataReader.Read())
                    {
                        string correctPassword = sqlite_dataReader.GetString(0);
                        if (correctPassword == password)
                        {
                            staffPosForm staffForm = new staffPosForm();
                            this.Hide();
                            staffForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password...!");
                        }
                    }
                sqlite_conn.Close();
                /*}
                else
                {
                    MessageBox.Show("Incorrect Username...!");
                }*/
                
            }
            
        }
    }
}

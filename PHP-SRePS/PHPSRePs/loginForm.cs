using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text == "admin" && txtLoginPassword.Text == "admin")
            {
                AdminMenuForm adminForm = new AdminMenuForm();
                this.Hide();
                adminForm.Show();

            }
            else
            {
                staffPosForm staffForm = new staffPosForm();
                this.Hide();
                staffForm.Show();
            }
            
        }
    }
}

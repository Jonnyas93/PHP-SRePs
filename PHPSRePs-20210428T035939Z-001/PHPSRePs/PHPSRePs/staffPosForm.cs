using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class staffPosForm : MetroFramework.Forms.MetroForm
    {
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
            StaffInventorySearch staffInventory = new StaffInventorySearch();
            this.Hide();
            staffInventory.Show();
        }

        private void btnStaffPosLogout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.Show();
        }
    }
}

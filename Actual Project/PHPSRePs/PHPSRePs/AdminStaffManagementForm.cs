using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class AdminStaffManagementForm : MetroFramework.Forms.MetroForm
    {
        public AdminStaffManagementForm()
        {
            InitializeComponent();
        }

        private void btnAdminSMBack_Click(object sender, EventArgs e)
        {
            AdminMenuForm admin = new AdminMenuForm();
            this.Hide();
            admin.Show();
        }
    }
}

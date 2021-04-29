using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class AdminMenuForm : MetroFramework.Forms.MetroForm

    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.Show();
        }

        private void btnAdminInventory_Click(object sender, EventArgs e)
        {
            adminInventory AdminInv = new adminInventory();
            this.Hide();
            AdminInv.Show();
        }

        private void btnAdminSalesData_Click(object sender, EventArgs e)
        {
            AdminSalesDataForm adminSales = new AdminSalesDataForm();
            this.Hide();
            adminSales.Show();

        }

        private void btnAdminStaffManagement_Click(object sender, EventArgs e)
        {
            AdminStaffManagementForm adminstaff = new AdminStaffManagementForm();
            this.Hide();
            adminstaff.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class adminInventory : MetroFramework.Forms.MetroForm
    {
        public adminInventory()
        {
            InitializeComponent();
        }

        private void btnAdminInventoryBack_Click(object sender, EventArgs e)
        {
            AdminMenuForm admin = new AdminMenuForm();
            this.Hide();
            admin.Show();
        }

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
    }
}

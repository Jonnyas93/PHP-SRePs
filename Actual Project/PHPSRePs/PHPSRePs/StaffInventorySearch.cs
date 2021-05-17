using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSRePs
{
    public partial class StaffInventorySearch : MetroFramework.Forms.MetroForm
    {
        public StaffInventorySearch()
        {
            InitializeComponent();
        }

        private void btnStaffInventoryBack_Click(object sender, EventArgs e)
        {
            staffPosForm staffPos = new staffPosForm();
            this.Hide();
            staffPos.Show();
        }
    }
}

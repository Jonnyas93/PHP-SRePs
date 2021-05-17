
namespace PHPSRePs
{
    partial class AdminMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdminSalesData = new MetroFramework.Controls.MetroTile();
            this.btnAdminInventory = new MetroFramework.Controls.MetroTile();
            this.btnAdminSalesReports = new MetroFramework.Controls.MetroTile();
            this.btnAdminLogout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnAdminSalesData
            // 
            this.btnAdminSalesData.ActiveControl = null;
            this.btnAdminSalesData.Location = new System.Drawing.Point(94, 107);
            this.btnAdminSalesData.Name = "btnAdminSalesData";
            this.btnAdminSalesData.Size = new System.Drawing.Size(227, 131);
            this.btnAdminSalesData.TabIndex = 0;
            this.btnAdminSalesData.Text = "Sales Data";
            this.btnAdminSalesData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminSalesData.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdminSalesData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdminSalesData.UseSelectable = true;
            this.btnAdminSalesData.Click += new System.EventHandler(this.btnAdminSalesData_Click);
            // 
            // btnAdminInventory
            // 
            this.btnAdminInventory.ActiveControl = null;
            this.btnAdminInventory.Location = new System.Drawing.Point(94, 257);
            this.btnAdminInventory.Name = "btnAdminInventory";
            this.btnAdminInventory.Size = new System.Drawing.Size(227, 131);
            this.btnAdminInventory.TabIndex = 1;
            this.btnAdminInventory.Text = "Inventory";
            this.btnAdminInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminInventory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdminInventory.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdminInventory.UseSelectable = true;
            this.btnAdminInventory.Click += new System.EventHandler(this.btnAdminInventory_Click);
            // 
            // btnAdminSalesReports
            // 
            this.btnAdminSalesReports.ActiveControl = null;
            this.btnAdminSalesReports.Location = new System.Drawing.Point(341, 107);
            this.btnAdminSalesReports.Name = "btnAdminSalesReports";
            this.btnAdminSalesReports.Size = new System.Drawing.Size(227, 131);
            this.btnAdminSalesReports.TabIndex = 1;
            this.btnAdminSalesReports.Text = "Sales Reports";
            this.btnAdminSalesReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminSalesReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdminSalesReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdminSalesReports.UseSelectable = true;
            this.btnAdminSalesReports.Click += new System.EventHandler(this.btnAdminSalesReports_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.ActiveControl = null;
            this.btnAdminLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdminLogout.Location = new System.Drawing.Point(341, 257);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(227, 131);
            this.btnAdminLogout.TabIndex = 3;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdminLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdminLogout.UseCustomBackColor = true;
            this.btnAdminLogout.UseSelectable = true;
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.btnAdminSalesReports);
            this.Controls.Add(this.btnAdminInventory);
            this.Controls.Add(this.btnAdminSalesData);
            this.Name = "AdminMenuForm";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnAdminSalesData;
        private MetroFramework.Controls.MetroTile btnAdminInventory;
        private MetroFramework.Controls.MetroTile btnAdminSalesReports;
        private MetroFramework.Controls.MetroTile btnAdminLogout;
    }
}
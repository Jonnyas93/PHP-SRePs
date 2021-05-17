
namespace PHPSRePs
{
    partial class AdminStaffManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdminStaffDelete = new MetroFramework.Controls.MetroButton();
            this.btnAdminStaffSearch = new MetroFramework.Controls.MetroButton();
            this.lblAdminStaffDataID = new MetroFramework.Controls.MetroLabel();
            this.txtAdminStaffID = new System.Windows.Forms.TextBox();
            this.lblAdminStaffName = new MetroFramework.Controls.MetroLabel();
            this.txtAdminStaffDataName = new System.Windows.Forms.TextBox();
            this.btnAdminSMBack = new MetroFramework.Controls.MetroTile();
            this.grdAdminStaffData = new MetroFramework.Controls.MetroGrid();
            this.lblAdminStaffPassword = new MetroFramework.Controls.MetroLabel();
            this.txtAdminStaffPassword = new System.Windows.Forms.TextBox();
            this.lblAdminStaffCPassword = new MetroFramework.Controls.MetroLabel();
            this.txtAdminStaffConPassword = new System.Windows.Forms.TextBox();
            this.btnAdminStaffUpdate = new MetroFramework.Controls.MetroButton();
            this.btnAdminStaffAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdminStaffData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminStaffDelete
            // 
            this.btnAdminStaffDelete.Location = new System.Drawing.Point(828, 588);
            this.btnAdminStaffDelete.Name = "btnAdminStaffDelete";
            this.btnAdminStaffDelete.Size = new System.Drawing.Size(104, 47);
            this.btnAdminStaffDelete.TabIndex = 31;
            this.btnAdminStaffDelete.Text = "Delete";
            this.btnAdminStaffDelete.UseSelectable = true;
            // 
            // btnAdminStaffSearch
            // 
            this.btnAdminStaffSearch.Location = new System.Drawing.Point(702, 520);
            this.btnAdminStaffSearch.Name = "btnAdminStaffSearch";
            this.btnAdminStaffSearch.Size = new System.Drawing.Size(104, 47);
            this.btnAdminStaffSearch.TabIndex = 30;
            this.btnAdminStaffSearch.Text = "Search";
            this.btnAdminStaffSearch.UseSelectable = true;
            // 
            // lblAdminStaffDataID
            // 
            this.lblAdminStaffDataID.AutoSize = true;
            this.lblAdminStaffDataID.Location = new System.Drawing.Point(702, 215);
            this.lblAdminStaffDataID.Name = "lblAdminStaffDataID";
            this.lblAdminStaffDataID.Size = new System.Drawing.Size(58, 19);
            this.lblAdminStaffDataID.TabIndex = 29;
            this.lblAdminStaffDataID.Text = "Staff ID :";
            // 
            // txtAdminStaffID
            // 
            this.txtAdminStaffID.Location = new System.Drawing.Point(702, 251);
            this.txtAdminStaffID.Name = "txtAdminStaffID";
            this.txtAdminStaffID.Size = new System.Drawing.Size(230, 23);
            this.txtAdminStaffID.TabIndex = 28;
            // 
            // lblAdminStaffName
            // 
            this.lblAdminStaffName.AutoSize = true;
            this.lblAdminStaffName.Location = new System.Drawing.Point(702, 136);
            this.lblAdminStaffName.Name = "lblAdminStaffName";
            this.lblAdminStaffName.Size = new System.Drawing.Size(52, 19);
            this.lblAdminStaffName.TabIndex = 27;
            this.lblAdminStaffName.Text = "Name :";
            // 
            // txtAdminStaffDataName
            // 
            this.txtAdminStaffDataName.Location = new System.Drawing.Point(702, 172);
            this.txtAdminStaffDataName.Name = "txtAdminStaffDataName";
            this.txtAdminStaffDataName.Size = new System.Drawing.Size(230, 23);
            this.txtAdminStaffDataName.TabIndex = 26;
            // 
            // btnAdminSMBack
            // 
            this.btnAdminSMBack.ActiveControl = null;
            this.btnAdminSMBack.Location = new System.Drawing.Point(865, 26);
            this.btnAdminSMBack.Name = "btnAdminSMBack";
            this.btnAdminSMBack.Size = new System.Drawing.Size(101, 44);
            this.btnAdminSMBack.TabIndex = 25;
            this.btnAdminSMBack.Text = "Back";
            this.btnAdminSMBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminSMBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdminSMBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdminSMBack.UseSelectable = true;
            this.btnAdminSMBack.Click += new System.EventHandler(this.btnAdminSMBack_Click);
            // 
            // grdAdminStaffData
            // 
            this.grdAdminStaffData.AllowUserToResizeRows = false;
            this.grdAdminStaffData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAdminStaffData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAdminStaffData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAdminStaffData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdminStaffData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAdminStaffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAdminStaffData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAdminStaffData.EnableHeadersVisualStyles = false;
            this.grdAdminStaffData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdAdminStaffData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdAdminStaffData.Location = new System.Drawing.Point(35, 118);
            this.grdAdminStaffData.Name = "grdAdminStaffData";
            this.grdAdminStaffData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdminStaffData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAdminStaffData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAdminStaffData.RowTemplate.Height = 25;
            this.grdAdminStaffData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAdminStaffData.Size = new System.Drawing.Size(633, 556);
            this.grdAdminStaffData.TabIndex = 24;
            // 
            // lblAdminStaffPassword
            // 
            this.lblAdminStaffPassword.AutoSize = true;
            this.lblAdminStaffPassword.Location = new System.Drawing.Point(702, 297);
            this.lblAdminStaffPassword.Name = "lblAdminStaffPassword";
            this.lblAdminStaffPassword.Size = new System.Drawing.Size(70, 19);
            this.lblAdminStaffPassword.TabIndex = 33;
            this.lblAdminStaffPassword.Text = "Password :";
            // 
            // txtAdminStaffPassword
            // 
            this.txtAdminStaffPassword.Location = new System.Drawing.Point(702, 333);
            this.txtAdminStaffPassword.Name = "txtAdminStaffPassword";
            this.txtAdminStaffPassword.Size = new System.Drawing.Size(230, 23);
            this.txtAdminStaffPassword.TabIndex = 32;
            // 
            // lblAdminStaffCPassword
            // 
            this.lblAdminStaffCPassword.AutoSize = true;
            this.lblAdminStaffCPassword.Location = new System.Drawing.Point(702, 376);
            this.lblAdminStaffCPassword.Name = "lblAdminStaffCPassword";
            this.lblAdminStaffCPassword.Size = new System.Drawing.Size(122, 19);
            this.lblAdminStaffCPassword.TabIndex = 35;
            this.lblAdminStaffCPassword.Text = "Confirm Password :";
            // 
            // txtAdminStaffConPassword
            // 
            this.txtAdminStaffConPassword.Location = new System.Drawing.Point(702, 412);
            this.txtAdminStaffConPassword.Name = "txtAdminStaffConPassword";
            this.txtAdminStaffConPassword.Size = new System.Drawing.Size(230, 23);
            this.txtAdminStaffConPassword.TabIndex = 34;
            // 
            // btnAdminStaffUpdate
            // 
            this.btnAdminStaffUpdate.Location = new System.Drawing.Point(702, 588);
            this.btnAdminStaffUpdate.Name = "btnAdminStaffUpdate";
            this.btnAdminStaffUpdate.Size = new System.Drawing.Size(104, 47);
            this.btnAdminStaffUpdate.TabIndex = 37;
            this.btnAdminStaffUpdate.Text = "Update";
            this.btnAdminStaffUpdate.UseSelectable = true;
            // 
            // btnAdminStaffAdd
            // 
            this.btnAdminStaffAdd.Location = new System.Drawing.Point(828, 520);
            this.btnAdminStaffAdd.Name = "btnAdminStaffAdd";
            this.btnAdminStaffAdd.Size = new System.Drawing.Size(104, 47);
            this.btnAdminStaffAdd.TabIndex = 36;
            this.btnAdminStaffAdd.Text = "Add";
            this.btnAdminStaffAdd.UseSelectable = true;
            // 
            // AdminStaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnAdminStaffUpdate);
            this.Controls.Add(this.btnAdminStaffAdd);
            this.Controls.Add(this.lblAdminStaffCPassword);
            this.Controls.Add(this.txtAdminStaffConPassword);
            this.Controls.Add(this.lblAdminStaffPassword);
            this.Controls.Add(this.txtAdminStaffPassword);
            this.Controls.Add(this.btnAdminStaffDelete);
            this.Controls.Add(this.btnAdminStaffSearch);
            this.Controls.Add(this.lblAdminStaffDataID);
            this.Controls.Add(this.txtAdminStaffID);
            this.Controls.Add(this.lblAdminStaffName);
            this.Controls.Add(this.txtAdminStaffDataName);
            this.Controls.Add(this.btnAdminSMBack);
            this.Controls.Add(this.grdAdminStaffData);
            this.Name = "AdminStaffManagementForm";
            this.Text = "Staff Management";
            ((System.ComponentModel.ISupportInitialize)(this.grdAdminStaffData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdminStaffDelete;
        private MetroFramework.Controls.MetroButton btnAdminStaffSearch;
        private MetroFramework.Controls.MetroLabel lblAdminStaffDataID;
        private System.Windows.Forms.TextBox txtAdminStaffID;
        private MetroFramework.Controls.MetroLabel lblAdminStaffName;
        private System.Windows.Forms.TextBox txtAdminStaffDataName;
        private MetroFramework.Controls.MetroTile btnAdminSMBack;
        private MetroFramework.Controls.MetroGrid grdAdminStaffData;
        private MetroFramework.Controls.MetroLabel lblAdminStaffPassword;
        private System.Windows.Forms.TextBox txtAdminStaffPassword;
        private MetroFramework.Controls.MetroLabel lblAdminStaffCPassword;
        private System.Windows.Forms.TextBox txtAdminStaffConPassword;
        private MetroFramework.Controls.MetroButton btnAdminStaffUpdate;
        private MetroFramework.Controls.MetroButton btnAdminStaffAdd;
    }
}
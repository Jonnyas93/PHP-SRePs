
namespace PHPSRePs
{
    partial class StaffInventorySearch
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
            this.grdStaffInventory = new MetroFramework.Controls.MetroGrid();
            this.txtStaffInventoryItemNo = new System.Windows.Forms.TextBox();
            this.txtStaffInventoryItemName = new System.Windows.Forms.TextBox();
            this.lblStaffInventoryItemNo = new MetroFramework.Controls.MetroLabel();
            this.lblStaffInventoryItemName = new MetroFramework.Controls.MetroLabel();
            this.btnStaffInventorySearch = new MetroFramework.Controls.MetroButton();
            this.lblItemFoundText = new System.Windows.Forms.Label();
            this.btnStaffInventoryBack = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStaffInventory
            // 
            this.grdStaffInventory.AllowUserToResizeRows = false;
            this.grdStaffInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStaffInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdStaffInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdStaffInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStaffInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStaffInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStaffInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdStaffInventory.EnableHeadersVisualStyles = false;
            this.grdStaffInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdStaffInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStaffInventory.Location = new System.Drawing.Point(23, 228);
            this.grdStaffInventory.Name = "grdStaffInventory";
            this.grdStaffInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStaffInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdStaffInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdStaffInventory.RowTemplate.Height = 25;
            this.grdStaffInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStaffInventory.Size = new System.Drawing.Size(954, 458);
            this.grdStaffInventory.TabIndex = 0;
            // 
            // txtStaffInventoryItemNo
            // 
            this.txtStaffInventoryItemNo.Location = new System.Drawing.Point(106, 132);
            this.txtStaffInventoryItemNo.Name = "txtStaffInventoryItemNo";
            this.txtStaffInventoryItemNo.Size = new System.Drawing.Size(174, 23);
            this.txtStaffInventoryItemNo.TabIndex = 1;
            // 
            // txtStaffInventoryItemName
            // 
            this.txtStaffInventoryItemName.Location = new System.Drawing.Point(405, 132);
            this.txtStaffInventoryItemName.Name = "txtStaffInventoryItemName";
            this.txtStaffInventoryItemName.Size = new System.Drawing.Size(174, 23);
            this.txtStaffInventoryItemName.TabIndex = 2;
            // 
            // lblStaffInventoryItemNo
            // 
            this.lblStaffInventoryItemNo.AutoSize = true;
            this.lblStaffInventoryItemNo.Location = new System.Drawing.Point(36, 132);
            this.lblStaffInventoryItemNo.Name = "lblStaffInventoryItemNo";
            this.lblStaffInventoryItemNo.Size = new System.Drawing.Size(64, 19);
            this.lblStaffInventoryItemNo.TabIndex = 3;
            this.lblStaffInventoryItemNo.Text = "Item No :";
            // 
            // lblStaffInventoryItemName
            // 
            this.lblStaffInventoryItemName.AutoSize = true;
            this.lblStaffInventoryItemName.Location = new System.Drawing.Point(317, 132);
            this.lblStaffInventoryItemName.Name = "lblStaffInventoryItemName";
            this.lblStaffInventoryItemName.Size = new System.Drawing.Size(82, 19);
            this.lblStaffInventoryItemName.TabIndex = 4;
            this.lblStaffInventoryItemName.Text = "Item Name :";
            // 
            // btnStaffInventorySearch
            // 
            this.btnStaffInventorySearch.Location = new System.Drawing.Point(479, 175);
            this.btnStaffInventorySearch.Name = "btnStaffInventorySearch";
            this.btnStaffInventorySearch.Size = new System.Drawing.Size(100, 38);
            this.btnStaffInventorySearch.TabIndex = 5;
            this.btnStaffInventorySearch.Text = "Search Item";
            this.btnStaffInventorySearch.UseSelectable = true;
            // 
            // lblItemFoundText
            // 
            this.lblItemFoundText.AutoSize = true;
            this.lblItemFoundText.Location = new System.Drawing.Point(287, 187);
            this.lblItemFoundText.Name = "lblItemFoundText";
            this.lblItemFoundText.Size = new System.Drawing.Size(186, 15);
            this.lblItemFoundText.TabIndex = 6;
            this.lblItemFoundText.Text = "remove text(Item found message)";
            // 
            // btnStaffInventoryBack
            // 
            this.btnStaffInventoryBack.ActiveControl = null;
            this.btnStaffInventoryBack.Location = new System.Drawing.Point(865, 46);
            this.btnStaffInventoryBack.Name = "btnStaffInventoryBack";
            this.btnStaffInventoryBack.Size = new System.Drawing.Size(112, 56);
            this.btnStaffInventoryBack.TabIndex = 7;
            this.btnStaffInventoryBack.Text = "Back";
            this.btnStaffInventoryBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaffInventoryBack.UseSelectable = true;
            this.btnStaffInventoryBack.Click += new System.EventHandler(this.btnStaffInventoryBack_Click);
            // 
            // StaffInventorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnStaffInventoryBack);
            this.Controls.Add(this.lblItemFoundText);
            this.Controls.Add(this.btnStaffInventorySearch);
            this.Controls.Add(this.lblStaffInventoryItemName);
            this.Controls.Add(this.lblStaffInventoryItemNo);
            this.Controls.Add(this.txtStaffInventoryItemName);
            this.Controls.Add(this.txtStaffInventoryItemNo);
            this.Controls.Add(this.grdStaffInventory);
            this.Name = "StaffInventorySearch";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdStaffInventory;
        private System.Windows.Forms.TextBox txtStaffInventoryItemNo;
        private System.Windows.Forms.TextBox txtStaffInventoryItemName;
        private MetroFramework.Controls.MetroLabel lblStaffInventoryItemNo;
        private MetroFramework.Controls.MetroLabel lblStaffInventoryItemName;
        private MetroFramework.Controls.MetroButton btnStaffInventorySearch;
        private System.Windows.Forms.Label lblItemFoundText;
        private MetroFramework.Controls.MetroTile btnStaffInventoryBack;
    }
}
using System;
using System.Data.SQLite;

namespace PHPSRePs
{
    partial class staffPosForm
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
            this.posItemsGridView = new MetroFramework.Controls.MetroGrid();
            this.lblPosItemNo = new MetroFramework.Controls.MetroLabel();
            this.lblPosItemName = new MetroFramework.Controls.MetroLabel();
            this.umberOfItems = new MetroFramework.Controls.MetroLabel();
            this.txtPosItemNo = new System.Windows.Forms.TextBox();
            this.txtPosSaleNumber = new System.Windows.Forms.TextBox();
            this.txtPosNumberOfItems = new System.Windows.Forms.TextBox();
            this.btnPosItemAdd = new MetroFramework.Controls.MetroButton();
            this.btnPosSearchForAnItem = new MetroFramework.Controls.MetroTile();
            this.btnStaffPosLogout = new MetroFramework.Controls.MetroTile();
            this.btnSearchSale = new MetroFramework.Controls.MetroTile();
            this.btnDeleteSaleEl = new MetroFramework.Controls.MetroTile();
            this.txtBxSaleID = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnEditSale = new MetroFramework.Controls.MetroButton();
            this.btnDeleteSale = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.posItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // posItemsGridView
            // 
            this.posItemsGridView.AllowUserToResizeRows = false;
            this.posItemsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.posItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.posItemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.posItemsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.posItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.posItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.posItemsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.posItemsGridView.EnableHeadersVisualStyles = false;
            this.posItemsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.posItemsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.posItemsGridView.Location = new System.Drawing.Point(23, 74);
            this.posItemsGridView.Name = "posItemsGridView";
            this.posItemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.posItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.posItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.posItemsGridView.RowTemplate.Height = 25;
            this.posItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.posItemsGridView.Size = new System.Drawing.Size(706, 467);
            this.posItemsGridView.TabIndex = 0;
            // 
            // lblPosItemNo
            // 
            this.lblPosItemNo.AutoSize = true;
            this.lblPosItemNo.Location = new System.Drawing.Point(749, 100);
            this.lblPosItemNo.Name = "lblPosItemNo";
            this.lblPosItemNo.Size = new System.Drawing.Size(64, 19);
            this.lblPosItemNo.TabIndex = 10;
            this.lblPosItemNo.Text = "Item No :";
            // 
            // lblPosItemName
            // 
            this.lblPosItemName.AutoSize = true;
            this.lblPosItemName.Location = new System.Drawing.Point(749, 182);
            this.lblPosItemName.Name = "lblPosItemName";
            this.lblPosItemName.Size = new System.Drawing.Size(62, 19);
            this.lblPosItemName.TabIndex = 11;
            this.lblPosItemName.Text = "Sale No :";
            this.lblPosItemName.Click += new System.EventHandler(this.lblPosItemName_Click);
            // 
            // umberOfItems
            // 
            this.umberOfItems.AutoSize = true;
            this.umberOfItems.Location = new System.Drawing.Point(749, 264);
            this.umberOfItems.Name = "umberOfItems";
            this.umberOfItems.Size = new System.Drawing.Size(116, 19);
            this.umberOfItems.TabIndex = 12;
            this.umberOfItems.Text = "Number of Items :";
            // 
            // txtPosItemNo
            // 
            this.txtPosItemNo.Location = new System.Drawing.Point(749, 136);
            this.txtPosItemNo.Name = "txtPosItemNo";
            this.txtPosItemNo.Size = new System.Drawing.Size(228, 23);
            this.txtPosItemNo.TabIndex = 13;
            // 
            // txtPosSaleNumber
            // 
            this.txtPosSaleNumber.Location = new System.Drawing.Point(749, 216);
            this.txtPosSaleNumber.Name = "txtPosSaleNumber";
            this.txtPosSaleNumber.Size = new System.Drawing.Size(228, 23);
            this.txtPosSaleNumber.TabIndex = 14;
            // 
            // txtPosNumberOfItems
            // 
            this.txtPosNumberOfItems.Location = new System.Drawing.Point(749, 298);
            this.txtPosNumberOfItems.Name = "txtPosNumberOfItems";
            this.txtPosNumberOfItems.Size = new System.Drawing.Size(228, 23);
            this.txtPosNumberOfItems.TabIndex = 15;
            // 
            // btnPosItemAdd
            // 
            this.btnPosItemAdd.Location = new System.Drawing.Point(749, 402);
            this.btnPosItemAdd.Name = "btnPosItemAdd";
            this.btnPosItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPosItemAdd.TabIndex = 16;
            this.btnPosItemAdd.Text = "Add Sale";
            this.btnPosItemAdd.UseSelectable = true;
            this.btnPosItemAdd.Click += new System.EventHandler(this.btnPosItemAdd_Click);
            // 
            // btnPosSearchForAnItem
            // 
            this.btnPosSearchForAnItem.ActiveControl = null;
            this.btnPosSearchForAnItem.Location = new System.Drawing.Point(749, 445);
            this.btnPosSearchForAnItem.Name = "btnPosSearchForAnItem";
            this.btnPosSearchForAnItem.Size = new System.Drawing.Size(163, 48);
            this.btnPosSearchForAnItem.TabIndex = 18;
            this.btnPosSearchForAnItem.Text = "Search For an Item";
            this.btnPosSearchForAnItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPosSearchForAnItem.UseSelectable = true;
            this.btnPosSearchForAnItem.Click += new System.EventHandler(this.btnPosSearchForAnItem_Click);
            // 
            // btnStaffPosLogout
            // 
            this.btnStaffPosLogout.ActiveControl = null;
            this.btnStaffPosLogout.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStaffPosLogout.Location = new System.Drawing.Point(902, 46);
            this.btnStaffPosLogout.Name = "btnStaffPosLogout";
            this.btnStaffPosLogout.Size = new System.Drawing.Size(75, 48);
            this.btnStaffPosLogout.TabIndex = 19;
            this.btnStaffPosLogout.Text = "Back";
            this.btnStaffPosLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaffPosLogout.UseCustomBackColor = true;
            this.btnStaffPosLogout.UseSelectable = true;
            this.btnStaffPosLogout.UseVisualStyleBackColor = false;
            this.btnStaffPosLogout.Click += new System.EventHandler(this.btnStaffPosLogout_Click);
            // 
            // btnSearchSale
            // 
            this.btnSearchSale.ActiveControl = null;
            this.btnSearchSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchSale.Location = new System.Drawing.Point(749, 512);
            this.btnSearchSale.Name = "btnSearchSale";
            this.btnSearchSale.Size = new System.Drawing.Size(163, 48);
            this.btnSearchSale.TabIndex = 20;
            this.btnSearchSale.Text = "Search For a Sale ";
            this.btnSearchSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchSale.UseSelectable = true;
            this.btnSearchSale.UseVisualStyleBackColor = false;
            this.btnSearchSale.Click += new System.EventHandler(this.btnSearchSale_Click);
            // 
            // btnDeleteSaleEl
            // 
            this.btnDeleteSaleEl.ActiveControl = null;
            this.btnDeleteSaleEl.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSaleEl.Location = new System.Drawing.Point(749, 577);
            this.btnDeleteSaleEl.Name = "btnDeleteSaleEl";
            this.btnDeleteSaleEl.Size = new System.Drawing.Size(163, 48);
            this.btnDeleteSaleEl.TabIndex = 21;
            this.btnDeleteSaleEl.Text = "Delete a Sale Element";
            this.btnDeleteSaleEl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteSaleEl.UseCustomBackColor = true;
            this.btnDeleteSaleEl.UseSelectable = true;
            this.btnDeleteSaleEl.UseVisualStyleBackColor = false;
            this.btnDeleteSaleEl.Click += new System.EventHandler(this.btnDeleteSaleEl_Click);
            // 
            // txtBxSaleID
            // 
            this.txtBxSaleID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxSaleID.Location = new System.Drawing.Point(749, 363);
            this.txtBxSaleID.Name = "txtBxSaleID";
            this.txtBxSaleID.Size = new System.Drawing.Size(228, 23);
            this.txtBxSaleID.TabIndex = 22;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 25;
            // 
            // btnEditSale
            // 
            this.btnEditSale.Location = new System.Drawing.Point(837, 402);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(75, 23);
            this.btnEditSale.TabIndex = 24;
            this.btnEditSale.Text = "Edit Sale";
            this.btnEditSale.UseSelectable = true;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.ActiveControl = null;
            this.btnDeleteSale.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSale.Location = new System.Drawing.Point(749, 641);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(163, 48);
            this.btnDeleteSale.TabIndex = 22;
            this.btnDeleteSale.Text = "Delete a Sale";
            this.btnDeleteSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteSale.UseCustomBackColor = true;
            this.btnDeleteSale.UseSelectable = true;
            this.btnDeleteSale.UseVisualStyleBackColor = false;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(749, 341);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(162, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Sale Element ID (Sales_ID):";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // staffPosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnDeleteSale);
            this.Controls.Add(this.btnEditSale);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtBxSaleID);
            this.Controls.Add(this.btnDeleteSaleEl);
            this.Controls.Add(this.btnSearchSale);
            this.Controls.Add(this.btnStaffPosLogout);
            this.Controls.Add(this.btnPosSearchForAnItem);
            this.Controls.Add(this.btnPosItemAdd);
            this.Controls.Add(this.txtPosNumberOfItems);
            this.Controls.Add(this.txtPosSaleNumber);
            this.Controls.Add(this.txtPosItemNo);
            this.Controls.Add(this.umberOfItems);
            this.Controls.Add(this.lblPosItemName);
            this.Controls.Add(this.lblPosItemNo);
            this.Controls.Add(this.posItemsGridView);
            this.Name = "staffPosForm";
            this.Load += new System.EventHandler(this.staffPosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid posItemsGridView;
        private MetroFramework.Controls.MetroLabel lblPosItemNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtxPosItemNo;
        private System.Windows.Forms.TextBox txtPosSaleNumber;
        private System.Windows.Forms.TextBox txtPosNumberOfItems;
        private MetroFramework.Controls.MetroButton btnPosItemAdd;
        private MetroFramework.Controls.MetroTile btnPosSearchForAnItem;
        private MetroFramework.Controls.MetroTile btnStaffPosLogout;
        private MetroFramework.Controls.MetroLabel PosItemName;
        private System.Windows.Forms.TextBox txtPosItemNo;
        private MetroFramework.Controls.MetroLabel lblPosItemName;
        private MetroFramework.Controls.MetroLabel umberOfItems;
        private MetroFramework.Controls.MetroTile btnSearchSale;
        private MetroFramework.Controls.MetroTile btnDeleteSaleEl;
        private System.Windows.Forms.TextBox txtBxSaleID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnEditSale;
        private MetroFramework.Controls.MetroTile btnDeleteSale;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
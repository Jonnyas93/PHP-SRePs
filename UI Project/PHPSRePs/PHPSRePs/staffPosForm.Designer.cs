
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
            this.lblSubtotalText = new MetroFramework.Controls.MetroLabel();
            this.lblTaxText = new MetroFramework.Controls.MetroLabel();
            this.lblTotalText = new MetroFramework.Controls.MetroLabel();
            this.lblPosTotal = new MetroFramework.Controls.MetroLabel();
            this.lblPosSubtotal = new MetroFramework.Controls.MetroLabel();
            this.lblPosTax = new MetroFramework.Controls.MetroLabel();
            this.btnPosPay = new MetroFramework.Controls.MetroTile();
            this.btnPosCancelSale = new MetroFramework.Controls.MetroButton();
            this.btnPosRemoveItem = new MetroFramework.Controls.MetroButton();
            this.lblPosItemNo = new MetroFramework.Controls.MetroLabel();
            this.lblPosItemName = new MetroFramework.Controls.MetroLabel();
            this.umberOfItems = new MetroFramework.Controls.MetroLabel();
            this.txtPosItemNo = new System.Windows.Forms.TextBox();
            this.txtPosItemName = new System.Windows.Forms.TextBox();
            this.txtPosNumberOfItems = new System.Windows.Forms.TextBox();
            this.btnPosItemAdd = new MetroFramework.Controls.MetroButton();
            this.lblPosItemAddMessage = new MetroFramework.Controls.MetroLabel();
            this.btnPosSearchForAnItem = new MetroFramework.Controls.MetroTile();
            this.btnStaffPosLogout = new MetroFramework.Controls.MetroTile();
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
            // lblSubtotalText
            // 
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Location = new System.Drawing.Point(47, 560);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(76, 19);
            this.lblSubtotalText.TabIndex = 1;
            this.lblSubtotalText.Text = "Subtotal    :";
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(47, 590);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(46, 19);
            this.lblTaxText.TabIndex = 2;
            this.lblTaxText.Text = "Tax    :";
            this.lblTaxText.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalText.Location = new System.Drawing.Point(47, 629);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(69, 25);
            this.lblTotalText.TabIndex = 3;
            this.lblTotalText.Text = "Total  :";
            // 
            // lblPosTotal
            // 
            this.lblPosTotal.AutoSize = true;
            this.lblPosTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPosTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPosTotal.Location = new System.Drawing.Point(207, 629);
            this.lblPosTotal.Name = "lblPosTotal";
            this.lblPosTotal.Size = new System.Drawing.Size(115, 25);
            this.lblPosTotal.TabIndex = 4;
            this.lblPosTotal.Text = "remove text";
            // 
            // lblPosSubtotal
            // 
            this.lblPosSubtotal.AutoSize = true;
            this.lblPosSubtotal.Location = new System.Drawing.Point(207, 560);
            this.lblPosSubtotal.Name = "lblPosSubtotal";
            this.lblPosSubtotal.Size = new System.Drawing.Size(79, 19);
            this.lblPosSubtotal.TabIndex = 5;
            this.lblPosSubtotal.Text = "remove text";
            // 
            // lblPosTax
            // 
            this.lblPosTax.AutoSize = true;
            this.lblPosTax.Location = new System.Drawing.Point(207, 590);
            this.lblPosTax.Name = "lblPosTax";
            this.lblPosTax.Size = new System.Drawing.Size(79, 19);
            this.lblPosTax.TabIndex = 6;
            this.lblPosTax.Text = "remove text";
            // 
            // btnPosPay
            // 
            this.btnPosPay.ActiveControl = null;
            this.btnPosPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPosPay.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPosPay.Location = new System.Drawing.Point(524, 629);
            this.btnPosPay.Name = "btnPosPay";
            this.btnPosPay.Size = new System.Drawing.Size(205, 68);
            this.btnPosPay.TabIndex = 7;
            this.btnPosPay.Text = "Pay";
            this.btnPosPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPosPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPosPay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPosPay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPosPay.UseCustomBackColor = true;
            this.btnPosPay.UseSelectable = true;
            this.btnPosPay.UseVisualStyleBackColor = false;
            // 
            // btnPosCancelSale
            // 
            this.btnPosCancelSale.Location = new System.Drawing.Point(524, 560);
            this.btnPosCancelSale.Name = "btnPosCancelSale";
            this.btnPosCancelSale.Size = new System.Drawing.Size(87, 49);
            this.btnPosCancelSale.TabIndex = 8;
            this.btnPosCancelSale.Text = "Cancel sale";
            this.btnPosCancelSale.UseSelectable = true;
            // 
            // btnPosRemoveItem
            // 
            this.btnPosRemoveItem.Location = new System.Drawing.Point(629, 560);
            this.btnPosRemoveItem.Name = "btnPosRemoveItem";
            this.btnPosRemoveItem.Size = new System.Drawing.Size(100, 49);
            this.btnPosRemoveItem.TabIndex = 9;
            this.btnPosRemoveItem.Text = "Remove Item";
            this.btnPosRemoveItem.UseSelectable = true;
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
            this.lblPosItemName.Size = new System.Drawing.Size(82, 19);
            this.lblPosItemName.TabIndex = 11;
            this.lblPosItemName.Text = "Item Name :";
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
            // txtPosItemName
            // 
            this.txtPosItemName.Location = new System.Drawing.Point(749, 216);
            this.txtPosItemName.Name = "txtPosItemName";
            this.txtPosItemName.Size = new System.Drawing.Size(228, 23);
            this.txtPosItemName.TabIndex = 14;
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
            this.btnPosItemAdd.Location = new System.Drawing.Point(893, 380);
            this.btnPosItemAdd.Name = "btnPosItemAdd";
            this.btnPosItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPosItemAdd.TabIndex = 16;
            this.btnPosItemAdd.Text = "Add Item";
            this.btnPosItemAdd.UseSelectable = true;
            // 
            // lblPosItemAddMessage
            // 
            this.lblPosItemAddMessage.AutoSize = true;
            this.lblPosItemAddMessage.Location = new System.Drawing.Point(749, 424);
            this.lblPosItemAddMessage.Name = "lblPosItemAddMessage";
            this.lblPosItemAddMessage.Size = new System.Drawing.Size(80, 19);
            this.lblPosItemAddMessage.TabIndex = 17;
            this.lblPosItemAddMessage.Text = "remove Text";
            // 
            // btnPosSearchForAnItem
            // 
            this.btnPosSearchForAnItem.ActiveControl = null;
            this.btnPosSearchForAnItem.Location = new System.Drawing.Point(717, 11);
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
            this.btnStaffPosLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStaffPosLogout.Location = new System.Drawing.Point(923, 11);
            this.btnStaffPosLogout.Name = "btnStaffPosLogout";
            this.btnStaffPosLogout.Size = new System.Drawing.Size(75, 44);
            this.btnStaffPosLogout.TabIndex = 19;
            this.btnStaffPosLogout.Text = "Logout";
            this.btnStaffPosLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaffPosLogout.UseCustomBackColor = true;
            this.btnStaffPosLogout.UseSelectable = true;
            this.btnStaffPosLogout.UseVisualStyleBackColor = false;
            this.btnStaffPosLogout.Click += new System.EventHandler(this.btnStaffPosLogout_Click);
            // 
            // staffPosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnStaffPosLogout);
            this.Controls.Add(this.btnPosSearchForAnItem);
            this.Controls.Add(this.lblPosItemAddMessage);
            this.Controls.Add(this.btnPosItemAdd);
            this.Controls.Add(this.txtPosNumberOfItems);
            this.Controls.Add(this.txtPosItemName);
            this.Controls.Add(this.txtPosItemNo);
            this.Controls.Add(this.umberOfItems);
            this.Controls.Add(this.lblPosItemName);
            this.Controls.Add(this.lblPosItemNo);
            this.Controls.Add(this.btnPosRemoveItem);
            this.Controls.Add(this.btnPosCancelSale);
            this.Controls.Add(this.btnPosPay);
            this.Controls.Add(this.lblPosTax);
            this.Controls.Add(this.lblPosSubtotal);
            this.Controls.Add(this.lblPosTotal);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTaxText);
            this.Controls.Add(this.lblSubtotalText);
            this.Controls.Add(this.posItemsGridView);
            this.Name = "staffPosForm";
            this.Text = "Make a Sale ";
            this.Load += new System.EventHandler(this.staffPosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid posItemsGridView;
        private MetroFramework.Controls.MetroLabel lblSubtotalText;
        private MetroFramework.Controls.MetroLabel lblTaxText;
        private MetroFramework.Controls.MetroLabel lblTotalText;
        private MetroFramework.Controls.MetroLabel lblPosTotal;
        private MetroFramework.Controls.MetroLabel lblPosSubtotal;
        private MetroFramework.Controls.MetroLabel lblPosTax;
        private MetroFramework.Controls.MetroTile btnPosPay;
        private MetroFramework.Controls.MetroButton btnPosCancelSale;
        private MetroFramework.Controls.MetroButton btnPosRemoveItem;
        private MetroFramework.Controls.MetroLabel lblPosItemNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtxPosItemNo;
        private System.Windows.Forms.TextBox txtPosItemName;
        private System.Windows.Forms.TextBox txtPosNumberOfItems;
        private MetroFramework.Controls.MetroButton btnPosItemAdd;
        private MetroFramework.Controls.MetroLabel lblPosItemAddMessage;
        private MetroFramework.Controls.MetroTile btnPosSearchForAnItem;
        private MetroFramework.Controls.MetroTile btnStaffPosLogout;
        private MetroFramework.Controls.MetroLabel PosItemName;
        private System.Windows.Forms.TextBox txtPosItemNo;
        private MetroFramework.Controls.MetroLabel lblPosItemName;
        private MetroFramework.Controls.MetroLabel umberOfItems;
    }
}
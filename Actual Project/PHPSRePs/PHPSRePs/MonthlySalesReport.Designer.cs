
namespace PHPSRePs
{
    partial class MonthlySalesReport
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
            this.btnSalesReportGenerate = new System.Windows.Forms.Button();
            this.btnSalesReportBack = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestSellingItem = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSales = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSalesText = new MetroFramework.Controls.MetroLabel();
            this.grdSalesReport = new MetroFramework.Controls.MetroGrid();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalesReportGenerate
            // 
            this.btnSalesReportGenerate.Location = new System.Drawing.Point(830, 209);
            this.btnSalesReportGenerate.Name = "btnSalesReportGenerate";
            this.btnSalesReportGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnSalesReportGenerate.TabIndex = 5;
            this.btnSalesReportGenerate.Text = "Generate";
            this.btnSalesReportGenerate.UseVisualStyleBackColor = true;
            this.btnSalesReportGenerate.Click += new System.EventHandler(this.btnSalesReportGenerate_Click);
            // 
            // btnSalesReportBack
            // 
            this.btnSalesReportBack.ActiveControl = null;
            this.btnSalesReportBack.Location = new System.Drawing.Point(876, 49);
            this.btnSalesReportBack.Name = "btnSalesReportBack";
            this.btnSalesReportBack.Size = new System.Drawing.Size(101, 44);
            this.btnSalesReportBack.TabIndex = 17;
            this.btnSalesReportBack.Text = "Back";
            this.btnSalesReportBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalesReportBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSalesReportBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSalesReportBack.UseSelectable = true;
            this.btnSalesReportBack.Click += new System.EventHandler(this.btnSalesReportBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestSellingItem);
            this.groupBox1.Controls.Add(this.lblTotalSales);
            this.groupBox1.Controls.Add(this.lblTotalSalesText);
            this.groupBox1.Controls.Add(this.grdSalesReport);
            this.groupBox1.Location = new System.Drawing.Point(23, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 439);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lblBestSellingItem
            // 
            this.lblBestSellingItem.AutoSize = true;
            this.lblBestSellingItem.Location = new System.Drawing.Point(814, 164);
            this.lblBestSellingItem.Name = "lblBestSellingItem";
            this.lblBestSellingItem.Size = new System.Drawing.Size(0, 0);
            this.lblBestSellingItem.TabIndex = 30;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(814, 93);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(0, 0);
            this.lblTotalSales.TabIndex = 29;
            // 
            // lblTotalSalesText
            // 
            this.lblTotalSalesText.AutoSize = true;
            this.lblTotalSalesText.Location = new System.Drawing.Point(648, 22);
            this.lblTotalSalesText.Name = "lblTotalSalesText";
            this.lblTotalSalesText.Size = new System.Drawing.Size(76, 19);
            this.lblTotalSalesText.TabIndex = 27;
            this.lblTotalSalesText.Text = "Total Sales :";
            // 
            // grdSalesReport
            // 
            this.grdSalesReport.AllowUserToResizeRows = false;
            this.grdSalesReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdSalesReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdSalesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSalesReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSalesReport.EnableHeadersVisualStyles = false;
            this.grdSalesReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdSalesReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSalesReport.Location = new System.Drawing.Point(37, 22);
            this.grdSalesReport.Name = "grdSalesReport";
            this.grdSalesReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalesReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSalesReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSalesReport.RowTemplate.Height = 25;
            this.grdSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalesReport.Size = new System.Drawing.Size(605, 386);
            this.grdSalesReport.TabIndex = 26;
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.Location = new System.Drawing.Point(911, 209);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(75, 23);
            this.btnImportCSV.TabIndex = 27;
            this.btnImportCSV.Text = "Export CSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);
            // 
            // MonthlySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnImportCSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalesReportBack);
            this.Controls.Add(this.btnSalesReportGenerate);
            this.Name = "MonthlySalesReport";
            this.Text = "Monthly Sales Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalesReportGenerate;
        private MetroFramework.Controls.MetroTile btnSalesReportBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblBestSellingItem;
        private MetroFramework.Controls.MetroLabel lblTotalSales;
        private MetroFramework.Controls.MetroLabel lblTotalSalesText;
        private MetroFramework.Controls.MetroGrid grdSalesReport;
        private System.Windows.Forms.Button btnImportCSV;
    }
}
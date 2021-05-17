
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
            this.SalesReportMonth = new System.Windows.Forms.ComboBox();
            this.SalesReportYear = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSalesReportClear = new System.Windows.Forms.Button();
            this.btnSalesReportGenerate = new System.Windows.Forms.Button();
            this.btnSalesReportBack = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestSellingItem = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSales = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSalesText = new MetroFramework.Controls.MetroLabel();
            this.grdSalesReport = new MetroFramework.Controls.MetroGrid();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesReportMonth
            // 
            this.SalesReportMonth.FormattingEnabled = true;
            this.SalesReportMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.SalesReportMonth.Location = new System.Drawing.Point(206, 139);
            this.SalesReportMonth.Name = "SalesReportMonth";
            this.SalesReportMonth.Size = new System.Drawing.Size(121, 23);
            this.SalesReportMonth.TabIndex = 0;
            // 
            // SalesReportYear
            // 
            this.SalesReportYear.FormattingEnabled = true;
            this.SalesReportYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.SalesReportYear.Location = new System.Drawing.Point(451, 139);
            this.SalesReportYear.Name = "SalesReportYear";
            this.SalesReportYear.Size = new System.Drawing.Size(121, 23);
            this.SalesReportYear.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(362, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Year :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(111, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Month :";
            // 
            // btnSalesReportClear
            // 
            this.btnSalesReportClear.Location = new System.Drawing.Point(351, 191);
            this.btnSalesReportClear.Name = "btnSalesReportClear";
            this.btnSalesReportClear.Size = new System.Drawing.Size(75, 23);
            this.btnSalesReportClear.TabIndex = 4;
            this.btnSalesReportClear.Text = "Clear";
            this.btnSalesReportClear.UseVisualStyleBackColor = true;
            this.btnSalesReportClear.Click += new System.EventHandler(this.btnSalesReportClear_Click);
            // 
            // btnSalesReportGenerate
            // 
            this.btnSalesReportGenerate.Location = new System.Drawing.Point(497, 191);
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
            this.btnSalesReportBack.Location = new System.Drawing.Point(876, 19);
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
            this.groupBox1.Controls.Add(this.metroLabel4);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.Location = new System.Drawing.Point(668, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Best Selling Item :";
            // 
            // lblTotalSalesText
            // 
            this.lblTotalSalesText.AutoSize = true;
            this.lblTotalSalesText.Location = new System.Drawing.Point(668, 93);
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
            this.btnImportCSV.Text = "Import CSV";
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
            this.Controls.Add(this.btnSalesReportClear);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SalesReportYear);
            this.Controls.Add(this.SalesReportMonth);
            this.Name = "MonthlySalesReport";
            this.Text = "Monthly Sales Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SalesReportMonth;
        private System.Windows.Forms.ComboBox SalesReportYear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnSalesReportClear;
        private System.Windows.Forms.Button btnSalesReportGenerate;
        private MetroFramework.Controls.MetroTile btnSalesReportBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblBestSellingItem;
        private MetroFramework.Controls.MetroLabel lblTotalSales;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotalSalesText;
        private MetroFramework.Controls.MetroGrid grdSalesReport;
        private System.Windows.Forms.Button btnImportCSV;
    }
}
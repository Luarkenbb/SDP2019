namespace SDP2019.uControl
{
    partial class reportTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnListAll = new System.Windows.Forms.Button();
            this.dtPickerMonthSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstSpare = new System.Windows.Forms.ListView();
            this.r_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_pPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtPickerMonthReport = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSelectedSpare = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSales = new System.Windows.Forms.RadioButton();
            this.rbtnQty = new System.Windows.Forms.RadioButton();
            this.cboxPreviousMonth = new System.Windows.Forms.CheckBox();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnListAll);
            this.groupBox10.Controls.Add(this.dtPickerMonthSearch);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.btnSearch);
            this.groupBox10.Location = new System.Drawing.Point(574, 215);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(191, 133);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Search Options";
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(7, 98);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(178, 23);
            this.btnListAll.TabIndex = 32;
            this.btnListAll.Text = "List All Spares";
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // dtPickerMonthSearch
            // 
            this.dtPickerMonthSearch.CustomFormat = "MMM yyyy";
            this.dtPickerMonthSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerMonthSearch.Location = new System.Drawing.Point(6, 17);
            this.dtPickerMonthSearch.Name = "dtPickerMonthSearch";
            this.dtPickerMonthSearch.Size = new System.Drawing.Size(178, 20);
            this.dtPickerMonthSearch.TabIndex = 31;
            this.dtPickerMonthSearch.Value = new System.DateTime(2019, 6, 4, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "SpareID: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(580, 373);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(178, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstSpare
            // 
            this.lstSpare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_SpareID,
            this.r_date,
            this.r_pPrice,
            this.r_tPrice,
            this.r_qty});
            this.lstSpare.FullRowSelect = true;
            this.lstSpare.GridLines = true;
            this.lstSpare.HideSelection = false;
            this.lstSpare.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lstSpare.Location = new System.Drawing.Point(1, 215);
            this.lstSpare.Name = "lstSpare";
            this.lstSpare.Size = new System.Drawing.Size(567, 184);
            this.lstSpare.TabIndex = 26;
            this.lstSpare.UseCompatibleStateImageBehavior = false;
            this.lstSpare.View = System.Windows.Forms.View.Details;
            this.lstSpare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSpare_MouseDoubleClick);
            // 
            // r_SpareID
            // 
            this.r_SpareID.Text = "SpareID";
            this.r_SpareID.Width = 67;
            // 
            // r_date
            // 
            this.r_date.Text = "QTY";
            this.r_date.Width = 71;
            // 
            // r_pPrice
            // 
            this.r_pPrice.Text = "Price Per Item";
            this.r_pPrice.Width = 92;
            // 
            // r_tPrice
            // 
            this.r_tPrice.Text = "QTY Safe Line";
            this.r_tPrice.Width = 102;
            // 
            // r_qty
            // 
            this.r_qty.Text = "Description";
            this.r_qty.Width = 74;
            // 
            // dtPickerMonthReport
            // 
            this.dtPickerMonthReport.CustomFormat = "MMM yyyy";
            this.dtPickerMonthReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerMonthReport.Location = new System.Drawing.Point(583, 22);
            this.dtPickerMonthReport.Name = "dtPickerMonthReport";
            this.dtPickerMonthReport.Size = new System.Drawing.Size(178, 20);
            this.dtPickerMonthReport.TabIndex = 30;
            this.dtPickerMonthReport.Value = new System.DateTime(2019, 6, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Selected Spares";
            // 
            // lstSelectedSpare
            // 
            this.lstSelectedSpare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstSelectedSpare.FullRowSelect = true;
            this.lstSelectedSpare.GridLines = true;
            this.lstSelectedSpare.HideSelection = false;
            this.lstSelectedSpare.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.lstSelectedSpare.Location = new System.Drawing.Point(1, 22);
            this.lstSelectedSpare.Name = "lstSelectedSpare";
            this.lstSelectedSpare.Size = new System.Drawing.Size(567, 171);
            this.lstSelectedSpare.TabIndex = 30;
            this.lstSelectedSpare.UseCompatibleStateImageBehavior = false;
            this.lstSelectedSpare.View = System.Windows.Forms.View.Details;
            this.lstSelectedSpare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSelectedSpare_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SpareID";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "QTY";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price Per Item";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "QTY Safe Line";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSales);
            this.groupBox1.Controls.Add(this.rbtnQty);
            this.groupBox1.Location = new System.Drawing.Point(580, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 60);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chart Options";
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoSize = true;
            this.rbtnSales.Location = new System.Drawing.Point(6, 37);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.Size = new System.Drawing.Size(51, 17);
            this.rbtnSales.TabIndex = 1;
            this.rbtnSales.TabStop = true;
            this.rbtnSales.Text = "Sales";
            this.rbtnSales.UseVisualStyleBackColor = true;
            // 
            // rbtnQty
            // 
            this.rbtnQty.AutoSize = true;
            this.rbtnQty.Checked = true;
            this.rbtnQty.Location = new System.Drawing.Point(6, 19);
            this.rbtnQty.Name = "rbtnQty";
            this.rbtnQty.Size = new System.Drawing.Size(64, 17);
            this.rbtnQty.TabIndex = 0;
            this.rbtnQty.TabStop = true;
            this.rbtnQty.Text = "Quantity";
            this.rbtnQty.UseVisualStyleBackColor = true;
            // 
            // cboxPreviousMonth
            // 
            this.cboxPreviousMonth.AutoSize = true;
            this.cboxPreviousMonth.Location = new System.Drawing.Point(583, 48);
            this.cboxPreviousMonth.Name = "cboxPreviousMonth";
            this.cboxPreviousMonth.Size = new System.Drawing.Size(130, 17);
            this.cboxPreviousMonth.TabIndex = 33;
            this.cboxPreviousMonth.Text = "Show Previous Month";
            this.cboxPreviousMonth.UseVisualStyleBackColor = true;
            this.cboxPreviousMonth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reportTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxPreviousMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSelectedSpare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerMonthReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstSpare);
            this.Name = "reportTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.reportTab_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstSpare;
        private System.Windows.Forms.ColumnHeader r_SpareID;
        private System.Windows.Forms.ColumnHeader r_date;
        private System.Windows.Forms.ColumnHeader r_pPrice;
        private System.Windows.Forms.ColumnHeader r_tPrice;
        private System.Windows.Forms.ColumnHeader r_qty;
        private System.Windows.Forms.DateTimePicker dtPickerMonthReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstSelectedSpare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.DateTimePicker dtPickerMonthSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.RadioButton rbtnQty;
        private System.Windows.Forms.CheckBox cboxPreviousMonth;
    }
}

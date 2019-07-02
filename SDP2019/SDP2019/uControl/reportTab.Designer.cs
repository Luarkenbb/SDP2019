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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            this.btnShow = new System.Windows.Forms.Button();
            this.dtPickerMonthReport = new System.Windows.Forms.DateTimePicker();
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
            this.btnSpareSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            listViewItem1});
            this.lstSelectedSpare.Location = new System.Drawing.Point(1, 22);
            this.lstSelectedSpare.Name = "lstSelectedSpare";
            this.lstSelectedSpare.Size = new System.Drawing.Size(567, 374);
            this.lstSelectedSpare.TabIndex = 30;
            this.lstSelectedSpare.UseCompatibleStateImageBehavior = false;
            this.lstSelectedSpare.View = System.Windows.Forms.View.Details;
            this.lstSelectedSpare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSpare_MouseDoubleClick);
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
            // btnSpareSelect
            // 
            this.btnSpareSelect.Location = new System.Drawing.Point(580, 137);
            this.btnSpareSelect.Name = "btnSpareSelect";
            this.btnSpareSelect.Size = new System.Drawing.Size(178, 23);
            this.btnSpareSelect.TabIndex = 34;
            this.btnSpareSelect.Text = "Select Spare";
            this.btnSpareSelect.UseVisualStyleBackColor = true;
            this.btnSpareSelect.Click += new System.EventHandler(this.btnSpareSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(580, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSpareSelect);
            this.Controls.Add(this.cboxPreviousMonth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSelectedSpare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerMonthReport);
            this.Controls.Add(this.btnShow);
            this.Name = "reportTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.reportTab_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtPickerMonthReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstSelectedSpare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSales;
        private System.Windows.Forms.RadioButton rbtnQty;
        private System.Windows.Forms.CheckBox cboxPreviousMonth;
        private System.Windows.Forms.Button btnSpareSelect;
        private System.Windows.Forms.Button btnClear;
    }
}

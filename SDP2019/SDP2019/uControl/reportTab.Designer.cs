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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstSpare = new System.Windows.Forms.ListView();
            this.r_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_pPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtPickerMonth = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.dtPickerMonth);
            this.groupBox10.Controls.Add(this.button21);
            this.groupBox10.Controls.Add(this.btnSearch);
            this.groupBox10.Location = new System.Drawing.Point(574, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(191, 268);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Data control";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(6, 236);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(178, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "Print";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            listViewItem3});
            this.lstSpare.Location = new System.Drawing.Point(1, 0);
            this.lstSpare.Name = "lstSpare";
            this.lstSpare.Size = new System.Drawing.Size(567, 399);
            this.lstSpare.TabIndex = 26;
            this.lstSpare.UseCompatibleStateImageBehavior = false;
            this.lstSpare.View = System.Windows.Forms.View.Details;
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
            // dtPickerMonth
            // 
            this.dtPickerMonth.CustomFormat = "MMM yyyy";
            this.dtPickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerMonth.Location = new System.Drawing.Point(6, 19);
            this.dtPickerMonth.Name = "dtPickerMonth";
            this.dtPickerMonth.Size = new System.Drawing.Size(178, 20);
            this.dtPickerMonth.TabIndex = 30;
            this.dtPickerMonth.Value = new System.DateTime(2019, 6, 4, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 29;
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
            // reportTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.lstSpare);
            this.Name = "reportTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.reportTab_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstSpare;
        private System.Windows.Forms.ColumnHeader r_SpareID;
        private System.Windows.Forms.ColumnHeader r_date;
        private System.Windows.Forms.ColumnHeader r_pPrice;
        private System.Windows.Forms.ColumnHeader r_tPrice;
        private System.Windows.Forms.ColumnHeader r_qty;
        private System.Windows.Forms.DateTimePicker dtPickerMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

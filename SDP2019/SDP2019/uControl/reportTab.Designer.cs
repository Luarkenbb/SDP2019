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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.listView6 = new System.Windows.Forms.ListView();
            this.r_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_pPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button21);
            this.groupBox10.Controls.Add(this.button23);
            this.groupBox10.Location = new System.Drawing.Point(574, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(191, 83);
            this.groupBox10.TabIndex = 27;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Data control";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(7, 49);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(178, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "Print";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(7, 19);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(178, 23);
            this.button23.TabIndex = 0;
            this.button23.Text = "Search";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_SpareID,
            this.r_date,
            this.r_pPrice,
            this.r_tPrice,
            this.r_qty});
            this.listView6.FullRowSelect = true;
            this.listView6.GridLines = true;
            this.listView6.HideSelection = false;
            this.listView6.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView6.Location = new System.Drawing.Point(1, 0);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(567, 399);
            this.listView6.TabIndex = 26;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // r_SpareID
            // 
            this.r_SpareID.Text = "SpareID";
            this.r_SpareID.Width = 67;
            // 
            // r_date
            // 
            this.r_date.Text = "Date";
            this.r_date.Width = 71;
            // 
            // r_pPrice
            // 
            this.r_pPrice.Text = "Pre Item Price";
            this.r_pPrice.Width = 92;
            // 
            // r_tPrice
            // 
            this.r_tPrice.Text = "Total Price";
            this.r_tPrice.Width = 79;
            // 
            // r_qty
            // 
            this.r_qty.Text = "Quantity";
            this.r_qty.Width = 74;
            // 
            // reportTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.listView6);
            this.Name = "reportTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader r_SpareID;
        private System.Windows.Forms.ColumnHeader r_date;
        private System.Windows.Forms.ColumnHeader r_pPrice;
        private System.Windows.Forms.ColumnHeader r_tPrice;
        private System.Windows.Forms.ColumnHeader r_qty;
    }
}

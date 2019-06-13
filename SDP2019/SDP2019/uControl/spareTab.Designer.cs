namespace SDP2019.uControl
{
    partial class spareTab
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSpareModify = new System.Windows.Forms.Button();
            this.btnSpareAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpareFrmAddToOrder = new System.Windows.Forms.Button();
            this.lstSpare = new System.Windows.Forms.ListView();
            this.s_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_QtySafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpareModify);
            this.groupBox2.Controls.Add(this.btnSpareAdd);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(574, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data control";
            // 
            // btnSpareModify
            // 
            this.btnSpareModify.Location = new System.Drawing.Point(6, 78);
            this.btnSpareModify.Name = "btnSpareModify";
            this.btnSpareModify.Size = new System.Drawing.Size(178, 23);
            this.btnSpareModify.TabIndex = 2;
            this.btnSpareModify.Text = "Spare Modify / Detail";
            this.btnSpareModify.UseVisualStyleBackColor = true;
            this.btnSpareModify.Click += new System.EventHandler(this.btnSpareModify_Click);
            // 
            // btnSpareAdd
            // 
            this.btnSpareAdd.Location = new System.Drawing.Point(7, 49);
            this.btnSpareAdd.Name = "btnSpareAdd";
            this.btnSpareAdd.Size = new System.Drawing.Size(178, 23);
            this.btnSpareAdd.TabIndex = 1;
            this.btnSpareAdd.Text = "Add New item";
            this.btnSpareAdd.UseVisualStyleBackColor = true;
            this.btnSpareAdd.Click += new System.EventHandler(this.btnSpareAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpareFrmAddToOrder);
            this.groupBox1.Location = new System.Drawing.Point(574, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Contral";
            // 
            // btnSpareFrmAddToOrder
            // 
            this.btnSpareFrmAddToOrder.Location = new System.Drawing.Point(7, 19);
            this.btnSpareFrmAddToOrder.Name = "btnSpareFrmAddToOrder";
            this.btnSpareFrmAddToOrder.Size = new System.Drawing.Size(178, 23);
            this.btnSpareFrmAddToOrder.TabIndex = 1;
            this.btnSpareFrmAddToOrder.Text = "Add Spare to Order";
            this.btnSpareFrmAddToOrder.UseVisualStyleBackColor = true;
            this.btnSpareFrmAddToOrder.Click += new System.EventHandler(this.btnSpareFrmAddToOrder_Click);
            // 
            // lstSpare
            // 
            this.lstSpare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.s_SpareID,
            this.s_QTY,
            this.s_Price,
            this.s_QtySafeLine,
            this.s_Description});
            this.lstSpare.FullRowSelect = true;
            this.lstSpare.GridLines = true;
            this.lstSpare.HideSelection = false;
            this.lstSpare.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstSpare.Location = new System.Drawing.Point(1, 0);
            this.lstSpare.Name = "lstSpare";
            this.lstSpare.Size = new System.Drawing.Size(567, 399);
            this.lstSpare.TabIndex = 4;
            this.lstSpare.UseCompatibleStateImageBehavior = false;
            this.lstSpare.View = System.Windows.Forms.View.Details;
            // 
            // s_SpareID
            // 
            this.s_SpareID.Text = "SpareID";
            this.s_SpareID.Width = 67;
            // 
            // s_QTY
            // 
            this.s_QTY.Text = "QTY";
            this.s_QTY.Width = 71;
            // 
            // s_Price
            // 
            this.s_Price.Text = "Price Per Item";
            this.s_Price.Width = 86;
            // 
            // s_QtySafeLine
            // 
            this.s_QtySafeLine.Text = "QTYSafeLine";
            this.s_QtySafeLine.Width = 79;
            // 
            // s_Description
            // 
            this.s_Description.Text = "Description";
            this.s_Description.Width = 74;
            // 
            // spareTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSpare);
            this.Name = "spareTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.spareTab_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSpareModify;
        private System.Windows.Forms.Button btnSpareAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpareFrmAddToOrder;
        private System.Windows.Forms.ListView lstSpare;
        private System.Windows.Forms.ColumnHeader s_SpareID;
        private System.Windows.Forms.ColumnHeader s_QTY;
        private System.Windows.Forms.ColumnHeader s_Price;
        private System.Windows.Forms.ColumnHeader s_QtySafeLine;
        private System.Windows.Forms.ColumnHeader s_Description;
    }
}

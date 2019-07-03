namespace SDP2019.uControl
{
    partial class dealerTab
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
            "1",
            "5",
            "2",
            "3",
            "4"}, -1);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModDealer = new System.Windows.Forms.Button();
            this.btnNewDealer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gboxOrder = new System.Windows.Forms.GroupBox();
            this.btnDealerFrmAddToOrder = new System.Windows.Forms.Button();
            this.lstDealer = new System.Windows.Forms.ListView();
            this.d_DealerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_DealerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.gboxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnModDealer);
            this.groupBox3.Controls.Add(this.btnNewDealer);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(574, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 189);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data control";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(178, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModDealer
            // 
            this.btnModDealer.Location = new System.Drawing.Point(5, 105);
            this.btnModDealer.Name = "btnModDealer";
            this.btnModDealer.Size = new System.Drawing.Size(178, 23);
            this.btnModDealer.TabIndex = 2;
            this.btnModDealer.Text = "Dealer Modify / Detail";
            this.btnModDealer.UseVisualStyleBackColor = true;
            this.btnModDealer.Click += new System.EventHandler(this.btnModDealer_Click);
            // 
            // btnNewDealer
            // 
            this.btnNewDealer.Location = new System.Drawing.Point(6, 76);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(178, 23);
            this.btnNewDealer.TabIndex = 1;
            this.btnNewDealer.Text = "Add New Dealer";
            this.btnNewDealer.UseVisualStyleBackColor = true;
            this.btnNewDealer.Click += new System.EventHandler(this.btnNewDealer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gboxOrder
            // 
            this.gboxOrder.Controls.Add(this.btnDealerFrmAddToOrder);
            this.gboxOrder.Location = new System.Drawing.Point(574, 3);
            this.gboxOrder.Name = "gboxOrder";
            this.gboxOrder.Size = new System.Drawing.Size(191, 52);
            this.gboxOrder.TabIndex = 7;
            this.gboxOrder.TabStop = false;
            this.gboxOrder.Text = "Dealer Contral";
            // 
            // btnDealerFrmAddToOrder
            // 
            this.btnDealerFrmAddToOrder.Location = new System.Drawing.Point(7, 19);
            this.btnDealerFrmAddToOrder.Name = "btnDealerFrmAddToOrder";
            this.btnDealerFrmAddToOrder.Size = new System.Drawing.Size(178, 23);
            this.btnDealerFrmAddToOrder.TabIndex = 1;
            this.btnDealerFrmAddToOrder.Text = "Add Dealer to Order";
            this.btnDealerFrmAddToOrder.UseVisualStyleBackColor = true;
            this.btnDealerFrmAddToOrder.Click += new System.EventHandler(this.btnDealerFrmAddToOrder_Click);
            // 
            // lstDealer
            // 
            this.lstDealer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.d_DealerID,
            this.d_DealerName,
            this.d_Address,
            this.d_Phone});
            this.lstDealer.FullRowSelect = true;
            this.lstDealer.GridLines = true;
            this.lstDealer.HideSelection = false;
            this.lstDealer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstDealer.Location = new System.Drawing.Point(1, 0);
            this.lstDealer.MultiSelect = false;
            this.lstDealer.Name = "lstDealer";
            this.lstDealer.Size = new System.Drawing.Size(567, 399);
            this.lstDealer.TabIndex = 6;
            this.lstDealer.UseCompatibleStateImageBehavior = false;
            this.lstDealer.View = System.Windows.Forms.View.Details;
            // 
            // d_DealerID
            // 
            this.d_DealerID.Text = "DealID";
            this.d_DealerID.Width = 74;
            // 
            // d_DealerName
            // 
            this.d_DealerName.Text = "Name";
            this.d_DealerName.Width = 91;
            // 
            // d_Address
            // 
            this.d_Address.Text = "Company Address";
            this.d_Address.Width = 172;
            // 
            // d_Phone
            // 
            this.d_Phone.Text = "Phone";
            this.d_Phone.Width = 97;
            // 
            // dealerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gboxOrder);
            this.Controls.Add(this.lstDealer);
            this.Name = "dealerTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.dealerTab_Load);
            this.groupBox3.ResumeLayout(false);
            this.gboxOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModDealer;
        private System.Windows.Forms.Button btnNewDealer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboxOrder;
        private System.Windows.Forms.Button btnDealerFrmAddToOrder;
        private System.Windows.Forms.ListView lstDealer;
        private System.Windows.Forms.ColumnHeader d_DealerID;
        private System.Windows.Forms.ColumnHeader d_DealerName;
        private System.Windows.Forms.ColumnHeader d_Address;
        private System.Windows.Forms.ColumnHeader d_Phone;
        private System.Windows.Forms.Button btnRefresh;
    }
}

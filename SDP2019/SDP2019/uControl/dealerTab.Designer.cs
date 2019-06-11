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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "5",
            "2",
            "3",
            "4"}, -1);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDealerFrmAddToOrder = new System.Windows.Forms.Button();
            this.lstDealer = new System.Windows.Forms.ListView();
            this.d_DealerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_DealerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(574, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 113);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data control";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Dealer Modify / Detail";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Add New Dealer";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDealerFrmAddToOrder);
            this.groupBox4.Location = new System.Drawing.Point(574, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 52);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dealer Contral";
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
            listViewItem2});
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
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lstDealer);
            this.Name = "dealerTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.dealerTab_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDealerFrmAddToOrder;
        private System.Windows.Forms.ListView lstDealer;
        private System.Windows.Forms.ColumnHeader d_DealerID;
        private System.Windows.Forms.ColumnHeader d_DealerName;
        private System.Windows.Forms.ColumnHeader d_Address;
        private System.Windows.Forms.ColumnHeader d_Phone;
    }
}

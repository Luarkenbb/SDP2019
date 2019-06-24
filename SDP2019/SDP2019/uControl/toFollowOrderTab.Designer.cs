namespace SDP2019.uControl
{
    partial class toFollowOrderTab
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.lstFollowOrder = new System.Windows.Forms.ListView();
            this.t_followOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_orderSpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_dealer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_dealerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_dateCreate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_FollowBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_spareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button25);
            this.groupBox9.Controls.Add(this.button26);
            this.groupBox9.Location = new System.Drawing.Point(656, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(109, 100);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data control";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(6, 48);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(94, 28);
            this.button25.TabIndex = 1;
            this.button25.Text = "Delete";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(6, 19);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(94, 28);
            this.button26.TabIndex = 0;
            this.button26.Text = "Search";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // lstFollowOrder
            // 
            this.lstFollowOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.t_followOrderID,
            this.t_orderSpareID,
            this.t_spareID,
            this.t_quantity,
            this.t_status,
            this.t_FollowBy,
            this.t_dealer,
            this.t_dealerName,
            this.t_dateCreate});
            this.lstFollowOrder.HideSelection = false;
            this.lstFollowOrder.Location = new System.Drawing.Point(1, 0);
            this.lstFollowOrder.Name = "lstFollowOrder";
            this.lstFollowOrder.Size = new System.Drawing.Size(655, 399);
            this.lstFollowOrder.TabIndex = 25;
            this.lstFollowOrder.UseCompatibleStateImageBehavior = false;
            this.lstFollowOrder.View = System.Windows.Forms.View.Details;
            this.lstFollowOrder.SelectedIndexChanged += new System.EventHandler(this.lstFollowOrder_SelectedIndexChanged);
            // 
            // t_followOrderID
            // 
            this.t_followOrderID.Text = "Follow OrderID";
            this.t_followOrderID.Width = 83;
            // 
            // t_orderSpareID
            // 
            this.t_orderSpareID.Text = "order SpareID";
            this.t_orderSpareID.Width = 81;
            // 
            // t_quantity
            // 
            this.t_quantity.Text = "quantity";
            // 
            // t_status
            // 
            this.t_status.Text = "status";
            // 
            // t_dealer
            // 
            this.t_dealer.Text = "DealerID";
            // 
            // t_dealerName
            // 
            this.t_dealerName.Text = "Dealer Name";
            this.t_dealerName.Width = 81;
            // 
            // t_dateCreate
            // 
            this.t_dateCreate.Text = "Date Created";
            this.t_dateCreate.Width = 134;
            // 
            // t_FollowBy
            // 
            this.t_FollowBy.Text = "FollowBy";
            // 
            // t_spareID
            // 
            this.t_spareID.Text = "SpareID";
            // 
            // toFollowOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.lstFollowOrder);
            this.Name = "toFollowOrderTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.toFollowOrderTab_Load);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.ListView lstFollowOrder;
        private System.Windows.Forms.ColumnHeader t_followOrderID;
        private System.Windows.Forms.ColumnHeader t_orderSpareID;
        private System.Windows.Forms.ColumnHeader t_quantity;
        private System.Windows.Forms.ColumnHeader t_status;
        private System.Windows.Forms.ColumnHeader t_dealer;
        private System.Windows.Forms.ColumnHeader t_dealerName;
        private System.Windows.Forms.ColumnHeader t_dateCreate;
        private System.Windows.Forms.ColumnHeader t_FollowBy;
        private System.Windows.Forms.ColumnHeader t_spareID;
    }
}

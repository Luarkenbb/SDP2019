namespace SDP2019.uControl
{
    partial class orderList
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.oL_OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_DealerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_DealerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_OrderCompleteDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_SpareList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRefresh);
            this.groupBox7.Controls.Add(this.btnOrderDetail);
            this.groupBox7.Controls.Add(this.btnSearch);
            this.groupBox7.Location = new System.Drawing.Point(574, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 106);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data control";
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.Location = new System.Drawing.Point(6, 75);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(178, 23);
            this.btnOrderDetail.TabIndex = 2;
            this.btnOrderDetail.Text = "Order Modify / Detail";
            this.btnOrderDetail.UseVisualStyleBackColor = true;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
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
            // lstOrder
            // 
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oL_OrderID,
            this.oL_OrderDate,
            this.oL_DealerID,
            this.oL_DealerName,
            this.oL_OrderCompleteDateTime,
            this.oL_SpareList});
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(1, 0);
            this.lstOrder.MultiSelect = false;
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(567, 399);
            this.lstOrder.TabIndex = 19;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // oL_OrderID
            // 
            this.oL_OrderID.Text = "OrderID";
            // 
            // oL_OrderDate
            // 
            this.oL_OrderDate.Text = "Order Date";
            this.oL_OrderDate.Width = 130;
            // 
            // oL_DealerID
            // 
            this.oL_DealerID.Text = "DealerID";
            // 
            // oL_DealerName
            // 
            this.oL_DealerName.Text = "dealerName";
            this.oL_DealerName.Width = 72;
            // 
            // oL_OrderCompleteDateTime
            // 
            this.oL_OrderCompleteDateTime.Text = "Complete Date";
            this.oL_OrderCompleteDateTime.Width = 96;
            // 
            // oL_SpareList
            // 
            this.oL_SpareList.Text = "Spare List";
            this.oL_SpareList.Width = 724;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(178, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lstOrder);
            this.Name = "orderList";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.orderList_Load);
            this.TabIndexChanged += new System.EventHandler(this.orderList_Load);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnOrderDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader oL_OrderID;
        private System.Windows.Forms.ColumnHeader oL_OrderDate;
        private System.Windows.Forms.ColumnHeader oL_SpareList;
        private System.Windows.Forms.ColumnHeader oL_DealerID;
        private System.Windows.Forms.ColumnHeader oL_DealerName;
        private System.Windows.Forms.ColumnHeader oL_OrderCompleteDateTime;
        private System.Windows.Forms.Button btnRefresh;
    }
}

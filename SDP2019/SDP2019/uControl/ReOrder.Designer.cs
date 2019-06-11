namespace SDP2019.uControl
{
    partial class ReOrder
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
            this.bt_Detail = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.listViewReOrder = new System.Windows.Forms.ListView();
            this.reOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantitySafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bt_Detail);
            this.groupBox7.Controls.Add(this.bt_Delete);
            this.groupBox7.Controls.Add(this.bt_search);
            this.groupBox7.Location = new System.Drawing.Point(576, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 112);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data control";
            // 
            // bt_Detail
            // 
            this.bt_Detail.Enabled = false;
            this.bt_Detail.Location = new System.Drawing.Point(7, 48);
            this.bt_Detail.Name = "bt_Detail";
            this.bt_Detail.Size = new System.Drawing.Size(178, 23);
            this.bt_Detail.TabIndex = 2;
            this.bt_Detail.Text = "Order Modify / Detail";
            this.bt_Detail.UseVisualStyleBackColor = true;
            this.bt_Detail.Click += new System.EventHandler(this.Bt_Detail_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Location = new System.Drawing.Point(6, 77);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(178, 23);
            this.bt_Delete.TabIndex = 1;
            this.bt_Delete.Text = "Delete Order";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(7, 19);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(178, 23);
            this.bt_search.TabIndex = 0;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // listViewReOrder
            // 
            this.listViewReOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reOrderID,
            this.spareID,
            this.quantitySafeLine,
            this.status});
            this.listViewReOrder.FullRowSelect = true;
            this.listViewReOrder.HideSelection = false;
            this.listViewReOrder.Location = new System.Drawing.Point(3, 3);
            this.listViewReOrder.Name = "listViewReOrder";
            this.listViewReOrder.Size = new System.Drawing.Size(567, 399);
            this.listViewReOrder.TabIndex = 21;
            this.listViewReOrder.UseCompatibleStateImageBehavior = false;
            this.listViewReOrder.View = System.Windows.Forms.View.Details;
            this.listViewReOrder.SelectedIndexChanged += new System.EventHandler(this.ListViewReOrder_SelectedIndexChanged);
            // 
            // reOrderID
            // 
            this.reOrderID.Text = "ReOrder ID";
            this.reOrderID.Width = 70;
            // 
            // spareID
            // 
            this.spareID.Text = "Spare ID";
            // 
            // quantitySafeLine
            // 
            this.quantitySafeLine.Text = "QuantitySafeLine";
            // 
            // status
            // 
            this.status.Text = "status";
            // 
            // ReOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.listViewReOrder);
            this.Name = "ReOrder";
            this.Size = new System.Drawing.Size(781, 418);
            this.Load += new System.EventHandler(this.ReOrder_Load);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bt_Detail;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ListView listViewReOrder;
        private System.Windows.Forms.ColumnHeader reOrderID;
        private System.Windows.Forms.ColumnHeader spareID;
        private System.Windows.Forms.ColumnHeader quantitySafeLine;
        private System.Windows.Forms.ColumnHeader status;
    }
}

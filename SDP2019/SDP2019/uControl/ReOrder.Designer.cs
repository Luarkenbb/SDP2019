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
            this.bt_Status = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.listViewReOrder = new System.Windows.Forms.ListView();
            this.reOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantitySafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_check = new System.Windows.Forms.Button();
            this.lstSpare = new System.Windows.Forms.ListView();
            this.s_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_QtySafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_QTYofSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.calledQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_setcalledQty = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bt_setcalledQty);
            this.groupBox7.Controls.Add(this.bt_delete);
            this.groupBox7.Controls.Add(this.bt_Detail);
            this.groupBox7.Controls.Add(this.bt_Status);
            this.groupBox7.Controls.Add(this.bt_search);
            this.groupBox7.Location = new System.Drawing.Point(576, 241);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 174);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data control";
            // 
            // bt_Detail
            // 
            this.bt_Detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Detail.Location = new System.Drawing.Point(7, 48);
            this.bt_Detail.Name = "bt_Detail";
            this.bt_Detail.Size = new System.Drawing.Size(178, 23);
            this.bt_Detail.TabIndex = 2;
            this.bt_Detail.Text = "Order Modify / Detail";
            this.bt_Detail.UseVisualStyleBackColor = true;
            this.bt_Detail.Click += new System.EventHandler(this.Bt_Detail_Click);
            // 
            // bt_Status
            // 
            this.bt_Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Status.Location = new System.Drawing.Point(6, 77);
            this.bt_Status.Name = "bt_Status";
            this.bt_Status.Size = new System.Drawing.Size(178, 23);
            this.bt_Status.TabIndex = 1;
            this.bt_Status.Text = "Change Status";
            this.bt_Status.UseVisualStyleBackColor = true;
            this.bt_Status.Click += new System.EventHandler(this.Bt_Status_Click);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(7, 19);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(178, 23);
            this.bt_search.TabIndex = 0;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.Bt_search_Click);
            // 
            // listViewReOrder
            // 
            this.listViewReOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reOrderID,
            this.spareID,
            this.quantitySafeLine,
            this.status,
            this.calledQty});
            this.listViewReOrder.FullRowSelect = true;
            this.listViewReOrder.HideSelection = false;
            this.listViewReOrder.Location = new System.Drawing.Point(3, 276);
            this.listViewReOrder.Name = "listViewReOrder";
            this.listViewReOrder.Size = new System.Drawing.Size(567, 139);
            this.listViewReOrder.TabIndex = 21;
            this.listViewReOrder.UseCompatibleStateImageBehavior = false;
            this.listViewReOrder.View = System.Windows.Forms.View.Details;
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
            this.quantitySafeLine.Width = 111;
            // 
            // status
            // 
            this.status.Text = "status";
            // 
            // bt_check
            // 
            this.bt_check.Location = new System.Drawing.Point(583, 3);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(178, 23);
            this.bt_check.TabIndex = 3;
            this.bt_check.Text = "refetsh";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.Bt_check_Click);
            // 
            // lstSpare
            // 
            this.lstSpare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.s_SpareID,
            this.s_QTY,
            this.s_QtySafeLine,
            this.s_Price,
            this.s_Status,
            this.s_QTYofSL,
            this.s_Description});
            this.lstSpare.FullRowSelect = true;
            this.lstSpare.GridLines = true;
            this.lstSpare.HideSelection = false;
            this.lstSpare.Location = new System.Drawing.Point(3, 3);
            this.lstSpare.Name = "lstSpare";
            this.lstSpare.Size = new System.Drawing.Size(567, 267);
            this.lstSpare.TabIndex = 23;
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
            // s_QtySafeLine
            // 
            this.s_QtySafeLine.Text = "QTYSafeLine";
            this.s_QtySafeLine.Width = 79;
            // 
            // s_Price
            // 
            this.s_Price.Text = "Price Per Item";
            this.s_Price.Width = 86;
            // 
            // s_Status
            // 
            this.s_Status.Text = "Status";
            // 
            // s_QTYofSL
            // 
            this.s_QTYofSL.Text = "QTYofSL";
            // 
            // s_Description
            // 
            this.s_Description.Text = "Description";
            this.s_Description.Width = 358;
            // 
            // bt_setting
            // 
            this.bt_setting.Location = new System.Drawing.Point(583, 32);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(178, 23);
            this.bt_setting.TabIndex = 3;
            this.bt_setting.Text = "Add to ReOrder";
            this.bt_setting.UseVisualStyleBackColor = true;
            this.bt_setting.Click += new System.EventHandler(this.Bt_setting_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_delete.Location = new System.Drawing.Point(6, 135);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(178, 23);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // calledQty
            // 
            this.calledQty.Text = "calledQty";
            // 
            // bt_setcalledQty
            // 
            this.bt_setcalledQty.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_setcalledQty.Location = new System.Drawing.Point(7, 106);
            this.bt_setcalledQty.Name = "bt_setcalledQty";
            this.bt_setcalledQty.Size = new System.Drawing.Size(178, 23);
            this.bt_setcalledQty.TabIndex = 4;
            this.bt_setcalledQty.Text = "setcalledQty";
            this.bt_setcalledQty.UseVisualStyleBackColor = true;
            this.bt_setcalledQty.Click += new System.EventHandler(this.Bt_setcalledQty_Click);
            // 
            // ReOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_setting);
            this.Controls.Add(this.lstSpare);
            this.Controls.Add(this.bt_check);
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
        private System.Windows.Forms.Button bt_Status;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ListView listViewReOrder;
        private System.Windows.Forms.ColumnHeader reOrderID;
        private System.Windows.Forms.ColumnHeader spareID;
        private System.Windows.Forms.ColumnHeader quantitySafeLine;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.ListView lstSpare;
        private System.Windows.Forms.ColumnHeader s_SpareID;
        private System.Windows.Forms.ColumnHeader s_QTY;
        private System.Windows.Forms.ColumnHeader s_Price;
        private System.Windows.Forms.ColumnHeader s_QtySafeLine;
        private System.Windows.Forms.ColumnHeader s_Description;
        private System.Windows.Forms.ColumnHeader s_Status;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.ColumnHeader s_QTYofSL;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ColumnHeader calledQty;
        private System.Windows.Forms.Button bt_setcalledQty;
    }
}

﻿namespace SDP2019.Dialog
{
    partial class OrderDetail
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

        #region Windows Form Designer generated code

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
            this.rtxtDeliverAddress = new System.Windows.Forms.RichTextBox();
            this.rtxtInvoiceAddress = new System.Windows.Forms.RichTextBox();
            this.txtOrderStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSpareStatus = new System.Windows.Forms.Button();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            this.btnAddSpare = new System.Windows.Forms.Button();
            this.btnSetQuantity = new System.Windows.Forms.Button();
            this.btnDelSpare = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstSpare = new System.Windows.Forms.ListView();
            this.o_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_QTYSafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDealerPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStoremanID = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtDeliverAddress
            // 
            this.rtxtDeliverAddress.Location = new System.Drawing.Point(240, 61);
            this.rtxtDeliverAddress.Name = "rtxtDeliverAddress";
            this.rtxtDeliverAddress.Size = new System.Drawing.Size(198, 69);
            this.rtxtDeliverAddress.TabIndex = 26;
            this.rtxtDeliverAddress.Text = "";
            // 
            // rtxtInvoiceAddress
            // 
            this.rtxtInvoiceAddress.Location = new System.Drawing.Point(15, 61);
            this.rtxtInvoiceAddress.Name = "rtxtInvoiceAddress";
            this.rtxtInvoiceAddress.Size = new System.Drawing.Size(198, 69);
            this.rtxtInvoiceAddress.TabIndex = 25;
            this.rtxtInvoiceAddress.Text = "";
            // 
            // txtOrderStaff
            // 
            this.txtOrderStaff.Location = new System.Drawing.Point(688, 12);
            this.txtOrderStaff.Name = "txtOrderStaff";
            this.txtOrderStaff.ReadOnly = true;
            this.txtOrderStaff.Size = new System.Drawing.Size(100, 20);
            this.txtOrderStaff.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Order Staff ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Deliver Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Invoice Address:";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(113, 12);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.ReadOnly = true;
            this.txtDealerID.Size = new System.Drawing.Size(100, 20);
            this.txtDealerID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DealerID:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUpdateSpareStatus);
            this.groupBox6.Controls.Add(this.btnUpdateOrderStatus);
            this.groupBox6.Controls.Add(this.btnAddSpare);
            this.groupBox6.Controls.Add(this.btnSetQuantity);
            this.groupBox6.Controls.Add(this.btnDelSpare);
            this.groupBox6.Location = new System.Drawing.Point(600, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 167);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Order control";
            // 
            // btnUpdateSpareStatus
            // 
            this.btnUpdateSpareStatus.Location = new System.Drawing.Point(7, 136);
            this.btnUpdateSpareStatus.Name = "btnUpdateSpareStatus";
            this.btnUpdateSpareStatus.Size = new System.Drawing.Size(176, 23);
            this.btnUpdateSpareStatus.TabIndex = 4;
            this.btnUpdateSpareStatus.Text = "Update Item Status";
            this.btnUpdateSpareStatus.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(7, 107);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(176, 23);
            this.btnUpdateOrderStatus.TabIndex = 3;
            this.btnUpdateOrderStatus.Text = "Update Order Status";
            this.btnUpdateOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnAddSpare
            // 
            this.btnAddSpare.Location = new System.Drawing.Point(7, 20);
            this.btnAddSpare.Name = "btnAddSpare";
            this.btnAddSpare.Size = new System.Drawing.Size(175, 23);
            this.btnAddSpare.TabIndex = 2;
            this.btnAddSpare.Text = "Add item";
            this.btnAddSpare.UseVisualStyleBackColor = true;
            this.btnAddSpare.Click += new System.EventHandler(this.btnAddSpare_Click);
            // 
            // btnSetQuantity
            // 
            this.btnSetQuantity.Location = new System.Drawing.Point(7, 78);
            this.btnSetQuantity.Name = "btnSetQuantity";
            this.btnSetQuantity.Size = new System.Drawing.Size(176, 23);
            this.btnSetQuantity.TabIndex = 1;
            this.btnSetQuantity.Text = "Reset quantity";
            this.btnSetQuantity.UseVisualStyleBackColor = true;
            // 
            // btnDelSpare
            // 
            this.btnDelSpare.Location = new System.Drawing.Point(7, 49);
            this.btnDelSpare.Name = "btnDelSpare";
            this.btnDelSpare.Size = new System.Drawing.Size(175, 23);
            this.btnDelSpare.TabIndex = 0;
            this.btnDelSpare.Text = "Remove item";
            this.btnDelSpare.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(707, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(626, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lstSpare
            // 
            this.lstSpare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.o_SpareID,
            this.o_QTY,
            this.o_Price,
            this.o_QTYSafeLine,
            this.o_Description,
            this.o_Status});
            this.lstSpare.FullRowSelect = true;
            this.lstSpare.GridLines = true;
            this.lstSpare.HideSelection = false;
            this.lstSpare.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstSpare.Location = new System.Drawing.Point(12, 155);
            this.lstSpare.Name = "lstSpare";
            this.lstSpare.Size = new System.Drawing.Size(575, 283);
            this.lstSpare.TabIndex = 15;
            this.lstSpare.UseCompatibleStateImageBehavior = false;
            this.lstSpare.View = System.Windows.Forms.View.Details;
            // 
            // o_SpareID
            // 
            this.o_SpareID.Text = "SpareID";
            this.o_SpareID.Width = 67;
            // 
            // o_QTY
            // 
            this.o_QTY.Text = "QTY";
            this.o_QTY.Width = 71;
            // 
            // o_Price
            // 
            this.o_Price.Text = "Price Per Item";
            this.o_Price.Width = 82;
            // 
            // o_QTYSafeLine
            // 
            this.o_QTYSafeLine.Text = "QTYSafeLine";
            this.o_QTYSafeLine.Width = 79;
            // 
            // o_Description
            // 
            this.o_Description.Text = "Description";
            this.o_Description.Width = 74;
            // 
            // o_Status
            // 
            this.o_Status.Text = "Status";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(688, 41);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "OrderID:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(688, 67);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Created By:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(688, 93);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Completed Date:";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(278, 12);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(100, 20);
            this.txtDealerName.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Phone:";
            // 
            // txtDealerPhone
            // 
            this.txtDealerPhone.Location = new System.Drawing.Point(486, 12);
            this.txtDealerPhone.Name = "txtDealerPhone";
            this.txtDealerPhone.ReadOnly = true;
            this.txtDealerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtDealerPhone.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Storeman ID:";
            // 
            // txtStoremanID
            // 
            this.txtStoremanID.Location = new System.Drawing.Point(688, 117);
            this.txtStoremanID.Name = "txtStoremanID";
            this.txtStoremanID.ReadOnly = true;
            this.txtStoremanID.Size = new System.Drawing.Size(100, 20);
            this.txtStoremanID.TabIndex = 38;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStoremanID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDealerPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtDeliverAddress);
            this.Controls.Add(this.rtxtInvoiceAddress);
            this.Controls.Add(this.txtOrderStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDealerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstSpare);
            this.Name = "OrderDetail";
            this.Text = "s";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDeliverAddress;
        private System.Windows.Forms.RichTextBox rtxtInvoiceAddress;
        private System.Windows.Forms.TextBox txtOrderStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAddSpare;
        private System.Windows.Forms.Button btnSetQuantity;
        private System.Windows.Forms.Button btnDelSpare;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView lstSpare;
        private System.Windows.Forms.ColumnHeader o_SpareID;
        private System.Windows.Forms.ColumnHeader o_QTY;
        private System.Windows.Forms.ColumnHeader o_Price;
        private System.Windows.Forms.ColumnHeader o_QTYSafeLine;
        private System.Windows.Forms.ColumnHeader o_Description;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
        private System.Windows.Forms.Button btnUpdateSpareStatus;
        private System.Windows.Forms.ColumnHeader o_Status;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDealerPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStoremanID;
    }
}
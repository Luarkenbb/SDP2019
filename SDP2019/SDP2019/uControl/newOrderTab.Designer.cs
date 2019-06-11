namespace SDP2019.uControl
{
    partial class newOrderTab
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOrderFrmSelectDealer = new System.Windows.Forms.Button();
            this.txtOrderFrmDealerPhone = new System.Windows.Forms.TextBox();
            this.txtOrderFrmDealerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtOrderFrmDeliverAddress = new System.Windows.Forms.RichTextBox();
            this.rtxtOrderFrmInvoiceAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderFrmDealerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnOrderFrmDelAllSpares = new System.Windows.Forms.Button();
            this.btnOrderFrmAddSpare = new System.Windows.Forms.Button();
            this.btnSetQuantity = new System.Windows.Forms.Button();
            this.btnOrderFrmDelSpare = new System.Windows.Forms.Button();
            this.btnOrderFrmClear = new System.Windows.Forms.Button();
            this.btnOrderFrmNewOrder = new System.Windows.Forms.Button();
            this.lstOrderFrmSpares = new System.Windows.Forms.ListView();
            this.o_SpareID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_QTYSafeLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.o_Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderFrmSelectDealer
            // 
            this.btnOrderFrmSelectDealer.Location = new System.Drawing.Point(583, 1);
            this.btnOrderFrmSelectDealer.Name = "btnOrderFrmSelectDealer";
            this.btnOrderFrmSelectDealer.Size = new System.Drawing.Size(175, 23);
            this.btnOrderFrmSelectDealer.TabIndex = 34;
            this.btnOrderFrmSelectDealer.Text = "Select Dealer";
            this.btnOrderFrmSelectDealer.UseVisualStyleBackColor = true;
            this.btnOrderFrmSelectDealer.Click += new System.EventHandler(this.btnOrderFrmSelectDealer_Click);
            // 
            // txtOrderFrmDealerPhone
            // 
            this.txtOrderFrmDealerPhone.Location = new System.Drawing.Point(473, 3);
            this.txtOrderFrmDealerPhone.Name = "txtOrderFrmDealerPhone";
            this.txtOrderFrmDealerPhone.ReadOnly = true;
            this.txtOrderFrmDealerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtOrderFrmDealerPhone.TabIndex = 33;
            // 
            // txtOrderFrmDealerName
            // 
            this.txtOrderFrmDealerName.Location = new System.Drawing.Point(278, 3);
            this.txtOrderFrmDealerName.Name = "txtOrderFrmDealerName";
            this.txtOrderFrmDealerName.ReadOnly = true;
            this.txtOrderFrmDealerName.Size = new System.Drawing.Size(100, 20);
            this.txtOrderFrmDealerName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name:";
            // 
            // rtxtOrderFrmDeliverAddress
            // 
            this.rtxtOrderFrmDeliverAddress.Location = new System.Drawing.Point(237, 49);
            this.rtxtOrderFrmDeliverAddress.Name = "rtxtOrderFrmDeliverAddress";
            this.rtxtOrderFrmDeliverAddress.Size = new System.Drawing.Size(198, 69);
            this.rtxtOrderFrmDeliverAddress.TabIndex = 29;
            this.rtxtOrderFrmDeliverAddress.Text = "";
            // 
            // rtxtOrderFrmInvoiceAddress
            // 
            this.rtxtOrderFrmInvoiceAddress.Location = new System.Drawing.Point(12, 49);
            this.rtxtOrderFrmInvoiceAddress.Name = "rtxtOrderFrmInvoiceAddress";
            this.rtxtOrderFrmInvoiceAddress.ReadOnly = true;
            this.rtxtOrderFrmInvoiceAddress.Size = new System.Drawing.Size(198, 69);
            this.rtxtOrderFrmInvoiceAddress.TabIndex = 28;
            this.rtxtOrderFrmInvoiceAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Deliver Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Invoice Address:";
            // 
            // txtOrderFrmDealerID
            // 
            this.txtOrderFrmDealerID.Location = new System.Drawing.Point(110, 3);
            this.txtOrderFrmDealerID.Name = "txtOrderFrmDealerID";
            this.txtOrderFrmDealerID.ReadOnly = true;
            this.txtOrderFrmDealerID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderFrmDealerID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "DealerID:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnOrderFrmDelAllSpares);
            this.groupBox6.Controls.Add(this.btnOrderFrmAddSpare);
            this.groupBox6.Controls.Add(this.btnSetQuantity);
            this.groupBox6.Controls.Add(this.btnOrderFrmDelSpare);
            this.groupBox6.Location = new System.Drawing.Point(576, 128);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 149);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data control";
            // 
            // btnOrderFrmDelAllSpares
            // 
            this.btnOrderFrmDelAllSpares.Location = new System.Drawing.Point(7, 78);
            this.btnOrderFrmDelAllSpares.Name = "btnOrderFrmDelAllSpares";
            this.btnOrderFrmDelAllSpares.Size = new System.Drawing.Size(175, 23);
            this.btnOrderFrmDelAllSpares.TabIndex = 3;
            this.btnOrderFrmDelAllSpares.Text = "Remove All item";
            this.btnOrderFrmDelAllSpares.UseVisualStyleBackColor = true;
            this.btnOrderFrmDelAllSpares.Click += new System.EventHandler(this.btnOrderFrmDelAllSpares_Click);
            // 
            // btnOrderFrmAddSpare
            // 
            this.btnOrderFrmAddSpare.Location = new System.Drawing.Point(7, 20);
            this.btnOrderFrmAddSpare.Name = "btnOrderFrmAddSpare";
            this.btnOrderFrmAddSpare.Size = new System.Drawing.Size(175, 23);
            this.btnOrderFrmAddSpare.TabIndex = 2;
            this.btnOrderFrmAddSpare.Text = "Add item";
            this.btnOrderFrmAddSpare.UseVisualStyleBackColor = true;
            this.btnOrderFrmAddSpare.Click += new System.EventHandler(this.btnOrderFrmAddSpare_Click);
            // 
            // btnSetQuantity
            // 
            this.btnSetQuantity.Location = new System.Drawing.Point(6, 107);
            this.btnSetQuantity.Name = "btnSetQuantity";
            this.btnSetQuantity.Size = new System.Drawing.Size(176, 23);
            this.btnSetQuantity.TabIndex = 1;
            this.btnSetQuantity.Text = "Set quantity";
            this.btnSetQuantity.UseVisualStyleBackColor = true;
            this.btnSetQuantity.Click += new System.EventHandler(this.btnSetQuantity_Click);
            // 
            // btnOrderFrmDelSpare
            // 
            this.btnOrderFrmDelSpare.Location = new System.Drawing.Point(7, 49);
            this.btnOrderFrmDelSpare.Name = "btnOrderFrmDelSpare";
            this.btnOrderFrmDelSpare.Size = new System.Drawing.Size(175, 23);
            this.btnOrderFrmDelSpare.TabIndex = 0;
            this.btnOrderFrmDelSpare.Text = "Remove item";
            this.btnOrderFrmDelSpare.UseVisualStyleBackColor = true;
            this.btnOrderFrmDelSpare.Click += new System.EventHandler(this.btnOrderFrmDelSpare_Click);
            // 
            // btnOrderFrmClear
            // 
            this.btnOrderFrmClear.Location = new System.Drawing.Point(608, 367);
            this.btnOrderFrmClear.Name = "btnOrderFrmClear";
            this.btnOrderFrmClear.Size = new System.Drawing.Size(75, 23);
            this.btnOrderFrmClear.TabIndex = 22;
            this.btnOrderFrmClear.Text = "Clear";
            this.btnOrderFrmClear.UseVisualStyleBackColor = true;
            this.btnOrderFrmClear.Click += new System.EventHandler(this.btnOrderFrmClear_Click);
            // 
            // btnOrderFrmNewOrder
            // 
            this.btnOrderFrmNewOrder.Location = new System.Drawing.Point(689, 367);
            this.btnOrderFrmNewOrder.Name = "btnOrderFrmNewOrder";
            this.btnOrderFrmNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrderFrmNewOrder.TabIndex = 21;
            this.btnOrderFrmNewOrder.Text = "Order";
            this.btnOrderFrmNewOrder.UseVisualStyleBackColor = true;
            this.btnOrderFrmNewOrder.Click += new System.EventHandler(this.btnOrderFrmNewOrder_Click);
            // 
            // lstOrderFrmSpares
            // 
            this.lstOrderFrmSpares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.o_SpareID,
            this.o_QTY,
            this.o_Price,
            this.o_QTYSafeLine,
            this.o_Description,
            this.o_Total});
            this.lstOrderFrmSpares.FullRowSelect = true;
            this.lstOrderFrmSpares.GridLines = true;
            this.lstOrderFrmSpares.HideSelection = false;
            this.lstOrderFrmSpares.Location = new System.Drawing.Point(3, 128);
            this.lstOrderFrmSpares.Name = "lstOrderFrmSpares";
            this.lstOrderFrmSpares.Size = new System.Drawing.Size(567, 269);
            this.lstOrderFrmSpares.TabIndex = 20;
            this.lstOrderFrmSpares.UseCompatibleStateImageBehavior = false;
            this.lstOrderFrmSpares.View = System.Windows.Forms.View.Details;
            this.lstOrderFrmSpares.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstOrderFrmSpares_MouseDoubleClick);
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
            this.o_Price.Width = 47;
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
            // o_Total
            // 
            this.o_Total.Text = "Total";
            // 
            // newOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOrderFrmSelectDealer);
            this.Controls.Add(this.txtOrderFrmDealerPhone);
            this.Controls.Add(this.txtOrderFrmDealerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtOrderFrmDeliverAddress);
            this.Controls.Add(this.rtxtOrderFrmInvoiceAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderFrmDealerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnOrderFrmClear);
            this.Controls.Add(this.btnOrderFrmNewOrder);
            this.Controls.Add(this.lstOrderFrmSpares);
            this.Name = "newOrderTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.newOrderTab_Load);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOrderFrmSelectDealer;
        private System.Windows.Forms.TextBox txtOrderFrmDealerPhone;
        private System.Windows.Forms.TextBox txtOrderFrmDealerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtOrderFrmDeliverAddress;
        private System.Windows.Forms.RichTextBox rtxtOrderFrmInvoiceAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderFrmDealerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnOrderFrmDelAllSpares;
        private System.Windows.Forms.Button btnOrderFrmAddSpare;
        private System.Windows.Forms.Button btnSetQuantity;
        private System.Windows.Forms.Button btnOrderFrmDelSpare;
        private System.Windows.Forms.Button btnOrderFrmClear;
        private System.Windows.Forms.Button btnOrderFrmNewOrder;
        private System.Windows.Forms.ListView lstOrderFrmSpares;
        private System.Windows.Forms.ColumnHeader o_SpareID;
        private System.Windows.Forms.ColumnHeader o_QTY;
        private System.Windows.Forms.ColumnHeader o_Price;
        private System.Windows.Forms.ColumnHeader o_QTYSafeLine;
        private System.Windows.Forms.ColumnHeader o_Description;
        private System.Windows.Forms.ColumnHeader o_Total;
    }
}

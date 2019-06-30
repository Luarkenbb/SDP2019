namespace SDP2019.Dialog
{
    partial class SpareUpdateStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpareUpdateStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.txtSpareName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpareStockBefore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.txtSpareSafeLine = new System.Windows.Forms.TextBox();
            this.SafeLine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpareStockAfter = new System.Windows.Forms.TextBox();
            this.lblToFollow = new System.Windows.Forms.Label();
            this.txtToFollowQuantity = new System.Windows.Forms.TextBox();
            this.txtDeliverQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderSerial = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpareID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spare Name";
            // 
            // txtSpareID
            // 
            this.txtSpareID.Location = new System.Drawing.Point(88, 3);
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.ReadOnly = true;
            this.txtSpareID.Size = new System.Drawing.Size(100, 20);
            this.txtSpareID.TabIndex = 2;
            // 
            // txtSpareName
            // 
            this.txtSpareName.Location = new System.Drawing.Point(88, 29);
            this.txtSpareName.Name = "txtSpareName";
            this.txtSpareName.ReadOnly = true;
            this.txtSpareName.Size = new System.Drawing.Size(100, 20);
            this.txtSpareName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Stock";
            // 
            // txtSpareStockBefore
            // 
            this.txtSpareStockBefore.Location = new System.Drawing.Point(88, 65);
            this.txtSpareStockBefore.Name = "txtSpareStockBefore";
            this.txtSpareStockBefore.ReadOnly = true;
            this.txtSpareStockBefore.Size = new System.Drawing.Size(53, 20);
            this.txtSpareStockBefore.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(316, 65);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.ReadOnly = true;
            this.txtOrderQuantity.Size = new System.Drawing.Size(55, 20);
            this.txtOrderQuantity.TabIndex = 7;
            // 
            // txtSpareSafeLine
            // 
            this.txtSpareSafeLine.Location = new System.Drawing.Point(88, 91);
            this.txtSpareSafeLine.Name = "txtSpareSafeLine";
            this.txtSpareSafeLine.ReadOnly = true;
            this.txtSpareSafeLine.Size = new System.Drawing.Size(55, 20);
            this.txtSpareSafeLine.TabIndex = 8;
            // 
            // SafeLine
            // 
            this.SafeLine.AutoSize = true;
            this.SafeLine.Location = new System.Drawing.Point(30, 94);
            this.SafeLine.Name = "SafeLine";
            this.SafeLine.Size = new System.Drawing.Size(52, 13);
            this.SafeLine.TabIndex = 9;
            this.SafeLine.Text = "Safe Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "After Package";
            // 
            // txtSpareStockAfter
            // 
            this.txtSpareStockAfter.Location = new System.Drawing.Point(88, 117);
            this.txtSpareStockAfter.Name = "txtSpareStockAfter";
            this.txtSpareStockAfter.ReadOnly = true;
            this.txtSpareStockAfter.Size = new System.Drawing.Size(55, 20);
            this.txtSpareStockAfter.TabIndex = 11;
            // 
            // lblToFollow
            // 
            this.lblToFollow.AutoSize = true;
            this.lblToFollow.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToFollow.Location = new System.Drawing.Point(215, 120);
            this.lblToFollow.Name = "lblToFollow";
            this.lblToFollow.Size = new System.Drawing.Size(95, 13);
            this.lblToFollow.TabIndex = 12;
            this.lblToFollow.Text = "To Follow Quantity";
            // 
            // txtToFollowQuantity
            // 
            this.txtToFollowQuantity.Location = new System.Drawing.Point(316, 117);
            this.txtToFollowQuantity.Name = "txtToFollowQuantity";
            this.txtToFollowQuantity.ReadOnly = true;
            this.txtToFollowQuantity.Size = new System.Drawing.Size(55, 20);
            this.txtToFollowQuantity.TabIndex = 13;
            // 
            // txtDeliverQuantity
            // 
            this.txtDeliverQuantity.Location = new System.Drawing.Point(316, 91);
            this.txtDeliverQuantity.Name = "txtDeliverQuantity";
            this.txtDeliverQuantity.ReadOnly = true;
            this.txtDeliverQuantity.Size = new System.Drawing.Size(55, 20);
            this.txtDeliverQuantity.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Deliver Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Order Serial";
            // 
            // txtOrderSerial
            // 
            this.txtOrderSerial.Location = new System.Drawing.Point(259, 3);
            this.txtOrderSerial.Name = "txtOrderSerial";
            this.txtOrderSerial.ReadOnly = true;
            this.txtOrderSerial.Size = new System.Drawing.Size(100, 20);
            this.txtOrderSerial.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Packaged and Update!";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SpareUpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtOrderSerial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeliverQuantity);
            this.Controls.Add(this.txtToFollowQuantity);
            this.Controls.Add(this.lblToFollow);
            this.Controls.Add(this.txtSpareStockAfter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SafeLine);
            this.Controls.Add(this.txtSpareSafeLine);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpareStockBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpareName);
            this.Controls.Add(this.txtSpareID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpareUpdateStatus";
            this.Text = "SpareUpdateStatus";
            this.Load += new System.EventHandler(this.SpareUpdateStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpareID;
        private System.Windows.Forms.TextBox txtSpareName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpareStockBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.TextBox txtSpareSafeLine;
        private System.Windows.Forms.Label SafeLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpareStockAfter;
        private System.Windows.Forms.Label lblToFollow;
        private System.Windows.Forms.TextBox txtToFollowQuantity;
        private System.Windows.Forms.TextBox txtDeliverQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderSerial;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}
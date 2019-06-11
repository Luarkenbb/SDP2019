namespace SDP2019.Dialog
{
    partial class ReOrderDetail
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
            this.tb_desc = new System.Windows.Forms.RichTextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_quantitySL = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_spareID = new System.Windows.Forms.TextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_reorderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(156, 116);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.ReadOnly = true;
            this.tb_desc.Size = new System.Drawing.Size(202, 69);
            this.tb_desc.TabIndex = 37;
            this.tb_desc.Text = "";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(156, 90);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(202, 20);
            this.tb_price.TabIndex = 36;
            // 
            // tb_quantitySL
            // 
            this.tb_quantitySL.Location = new System.Drawing.Point(156, 64);
            this.tb_quantitySL.Name = "tb_quantitySL";
            this.tb_quantitySL.ReadOnly = true;
            this.tb_quantitySL.Size = new System.Drawing.Size(202, 20);
            this.tb_quantitySL.TabIndex = 35;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(156, 38);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.ReadOnly = true;
            this.tb_quantity.Size = new System.Drawing.Size(202, 20);
            this.tb_quantity.TabIndex = 34;
            // 
            // tb_spareID
            // 
            this.tb_spareID.Location = new System.Drawing.Point(156, 12);
            this.tb_spareID.Name = "tb_spareID";
            this.tb_spareID.ReadOnly = true;
            this.tb_spareID.Size = new System.Drawing.Size(202, 20);
            this.tb_spareID.TabIndex = 33;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(476, 205);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 32;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description / Key Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantity Safe Line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity(NOW):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "SpareID: ";
            // 
            // tb_reorderID
            // 
            this.tb_reorderID.Location = new System.Drawing.Point(437, 12);
            this.tb_reorderID.Name = "tb_reorderID";
            this.tb_reorderID.ReadOnly = true;
            this.tb_reorderID.Size = new System.Drawing.Size(114, 20);
            this.tb_reorderID.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "reOrderID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Status: ";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "NULL",
            "ReOrdered"});
            this.cb_status.Location = new System.Drawing.Point(437, 41);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(114, 21);
            this.cb_status.TabIndex = 43;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(383, 205);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 44;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // ReOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 240);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_reorderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_quantitySL);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.tb_spareID);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReOrderDetail";
            this.Text = "ReOrderDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tb_desc;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_quantitySL;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_spareID;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_reorderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button bt_update;
    }
}
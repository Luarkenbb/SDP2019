﻿namespace SDP2019.Dialog
{
    partial class ReOrderStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change your select Status";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "NULL",
            "ReOrdered"});
            this.cb_status.Location = new System.Drawing.Point(120, 151);
            this.cb_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(169, 28);
            this.cb_status.TabIndex = 44;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(75, 225);
            this.bt_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(112, 35);
            this.bt_update.TabIndex = 46;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(214, 225);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(112, 35);
            this.bt_close.TabIndex = 45;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(82, 92);
            this.lb_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(36, 20);
            this.lb_count.TabIndex = 47;
            this.lb_count.Text = "test";
            this.lb_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 297);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReOrderStatus";
            this.Text = "ReOrderStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_count;
    }
}
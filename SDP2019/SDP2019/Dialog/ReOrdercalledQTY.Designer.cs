namespace SDP2019.Dialog
{
    partial class ReOrdercalledQTY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReOrdercalledQTY));
            this.lb_count = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(56, 80);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(24, 13);
            this.lb_count.TabIndex = 52;
            this.lb_count.Text = "test";
            this.lb_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(51, 166);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 51;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(144, 166);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 50;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Enter your item qty";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(85, 118);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 20);
            this.tb_num.TabIndex = 53;
            // 
            // ReOrdercalledQTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 233);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReOrdercalledQTY";
            this.Text = "ReOrdercalledQTY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_num;
    }
}
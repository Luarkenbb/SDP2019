namespace SDP2019.Dialog
{
    partial class ReOrderSearch
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
            this.bt_search = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_reorderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_spareID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(62, 164);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(83, 28);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.Bt_search_Click);
            // 
            // cb_status
            // 
            this.cb_status.DisplayMember = "0";
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Disable",
            "NULL",
            "ReOrdered"});
            this.cb_status.Location = new System.Drawing.Point(114, 104);
            this.cb_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(169, 28);
            this.cb_status.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Status: ";
            // 
            // tb_reorderID
            // 
            this.tb_reorderID.Location = new System.Drawing.Point(114, 59);
            this.tb_reorderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_reorderID.Name = "tb_reorderID";
            this.tb_reorderID.Size = new System.Drawing.Size(169, 26);
            this.tb_reorderID.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "reOrderID:";
            // 
            // tb_spareID
            // 
            this.tb_spareID.Location = new System.Drawing.Point(114, 14);
            this.tb_spareID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_spareID.Name = "tb_spareID";
            this.tb_spareID.Size = new System.Drawing.Size(169, 26);
            this.tb_spareID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "SpareID: ";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(175, 164);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(83, 28);
            this.bt_cancel.TabIndex = 50;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.Bt_cancel_Click);
            // 
            // ReOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 221);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_reorderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_spareID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_search);
            this.Name = "ReOrderSearch";
            this.Text = "ReOrderSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_reorderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_spareID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancel;
    }
}
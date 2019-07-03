namespace SDP2019.Dialog
{
    partial class ToFollowSearch
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
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtFollowID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnLessThan = new System.Windows.Forms.RadioButton();
            this.rbtnMoreThan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxStatus
            // 
            this.cboxStatus.DisplayMember = "0";
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Items.AddRange(new object[] {
            "followed",
            "awaiting"});
            this.cboxStatus.Location = new System.Drawing.Point(156, 119);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(202, 21);
            this.cboxStatus.TabIndex = 24;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(156, 93);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(58, 20);
            this.txtQuantity.TabIndex = 21;
            // 
            // txtFollowID
            // 
            this.txtFollowID.Location = new System.Drawing.Point(156, 12);
            this.txtFollowID.Name = "txtFollowID";
            this.txtFollowID.Size = new System.Drawing.Size(202, 20);
            this.txtFollowID.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "FollowID: ";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(156, 67);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(202, 20);
            this.txtDealerID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dealer ID:";
            // 
            // rbtnLessThan
            // 
            this.rbtnLessThan.AutoSize = true;
            this.rbtnLessThan.Checked = true;
            this.rbtnLessThan.Location = new System.Drawing.Point(220, 96);
            this.rbtnLessThan.Name = "rbtnLessThan";
            this.rbtnLessThan.Size = new System.Drawing.Size(31, 17);
            this.rbtnLessThan.TabIndex = 27;
            this.rbtnLessThan.TabStop = true;
            this.rbtnLessThan.Text = "<";
            this.rbtnLessThan.UseVisualStyleBackColor = true;
            // 
            // rbtnMoreThan
            // 
            this.rbtnMoreThan.AutoSize = true;
            this.rbtnMoreThan.Location = new System.Drawing.Point(267, 96);
            this.rbtnMoreThan.Name = "rbtnMoreThan";
            this.rbtnMoreThan.Size = new System.Drawing.Size(31, 17);
            this.rbtnMoreThan.TabIndex = 28;
            this.rbtnMoreThan.Text = ">";
            this.rbtnMoreThan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "SpareID";
            // 
            // txtSpareID
            // 
            this.txtSpareID.Location = new System.Drawing.Point(156, 38);
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.Size = new System.Drawing.Size(202, 20);
            this.txtSpareID.TabIndex = 30;
            // 
            // ToFollowSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 192);
            this.Controls.Add(this.txtSpareID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnMoreThan);
            this.Controls.Add(this.rbtnLessThan);
            this.Controls.Add(this.txtDealerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtFollowID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ToFollowSearch";
            this.Text = "ToFollowSearch";
            this.Load += new System.EventHandler(this.ToFollowSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtFollowID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnLessThan;
        private System.Windows.Forms.RadioButton rbtnMoreThan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpareID;
    }
}
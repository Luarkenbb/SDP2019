namespace SDP2019.Dialog
{
    partial class OrderSearch
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
            this.gbxDealer = new System.Windows.Forms.GroupBox();
            this.rbtnDealerID = new System.Windows.Forms.RadioButton();
            this.rbtnDealerName = new System.Windows.Forms.RadioButton();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.dTimeSearchDate = new System.Windows.Forms.DateTimePicker();
            this.gbxDate = new System.Windows.Forms.GroupBox();
            this.rbtnDateBefore = new System.Windows.Forms.RadioButton();
            this.rbtnDateAfter = new System.Windows.Forms.RadioButton();
            this.numOrderSerial = new System.Windows.Forms.NumericUpDown();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.rbtnCompleted = new System.Windows.Forms.RadioButton();
            this.rbtnAwaiting = new System.Windows.Forms.RadioButton();
            this.rbtnOrderSerial = new System.Windows.Forms.RadioButton();
            this.rbtnInformation = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.cbxDealer = new System.Windows.Forms.CheckBox();
            this.cbxDate = new System.Windows.Forms.CheckBox();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.gbxDealer.SuspendLayout();
            this.gbxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderSerial)).BeginInit();
            this.gbxStatus.SuspendLayout();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // gbxDealer
            // 
            this.gbxDealer.Controls.Add(this.txtDealerName);
            this.gbxDealer.Controls.Add(this.txtDealerID);
            this.gbxDealer.Controls.Add(this.rbtnDealerName);
            this.gbxDealer.Controls.Add(this.rbtnDealerID);
            this.gbxDealer.Location = new System.Drawing.Point(74, 19);
            this.gbxDealer.Name = "gbxDealer";
            this.gbxDealer.Size = new System.Drawing.Size(214, 70);
            this.gbxDealer.TabIndex = 1;
            this.gbxDealer.TabStop = false;
            this.gbxDealer.Text = "Dealer";
            // 
            // rbtnDealerID
            // 
            this.rbtnDealerID.AutoSize = true;
            this.rbtnDealerID.Checked = true;
            this.rbtnDealerID.Location = new System.Drawing.Point(6, 19);
            this.rbtnDealerID.Name = "rbtnDealerID";
            this.rbtnDealerID.Size = new System.Drawing.Size(70, 17);
            this.rbtnDealerID.TabIndex = 0;
            this.rbtnDealerID.TabStop = true;
            this.rbtnDealerID.Text = "Dealer ID";
            this.rbtnDealerID.UseVisualStyleBackColor = true;
            // 
            // rbtnDealerName
            // 
            this.rbtnDealerName.AutoSize = true;
            this.rbtnDealerName.Location = new System.Drawing.Point(6, 42);
            this.rbtnDealerName.Name = "rbtnDealerName";
            this.rbtnDealerName.Size = new System.Drawing.Size(87, 17);
            this.rbtnDealerName.TabIndex = 1;
            this.rbtnDealerName.Text = "Dealer Name";
            this.rbtnDealerName.UseVisualStyleBackColor = true;
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(94, 16);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(100, 20);
            this.txtDealerID.TabIndex = 2;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(94, 42);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(100, 20);
            this.txtDealerName.TabIndex = 3;
            // 
            // dTimeSearchDate
            // 
            this.dTimeSearchDate.Location = new System.Drawing.Point(6, 19);
            this.dTimeSearchDate.Name = "dTimeSearchDate";
            this.dTimeSearchDate.Size = new System.Drawing.Size(200, 20);
            this.dTimeSearchDate.TabIndex = 2;
            // 
            // gbxDate
            // 
            this.gbxDate.Controls.Add(this.rbtnDateAfter);
            this.gbxDate.Controls.Add(this.rbtnDateBefore);
            this.gbxDate.Controls.Add(this.dTimeSearchDate);
            this.gbxDate.Location = new System.Drawing.Point(74, 95);
            this.gbxDate.Name = "gbxDate";
            this.gbxDate.Size = new System.Drawing.Size(214, 73);
            this.gbxDate.TabIndex = 3;
            this.gbxDate.TabStop = false;
            this.gbxDate.Text = "CreateDate";
            // 
            // rbtnDateBefore
            // 
            this.rbtnDateBefore.AutoSize = true;
            this.rbtnDateBefore.Checked = true;
            this.rbtnDateBefore.Location = new System.Drawing.Point(6, 45);
            this.rbtnDateBefore.Name = "rbtnDateBefore";
            this.rbtnDateBefore.Size = new System.Drawing.Size(55, 17);
            this.rbtnDateBefore.TabIndex = 3;
            this.rbtnDateBefore.TabStop = true;
            this.rbtnDateBefore.Text = "before";
            this.rbtnDateBefore.UseVisualStyleBackColor = true;
            // 
            // rbtnDateAfter
            // 
            this.rbtnDateAfter.AutoSize = true;
            this.rbtnDateAfter.Location = new System.Drawing.Point(160, 45);
            this.rbtnDateAfter.Name = "rbtnDateAfter";
            this.rbtnDateAfter.Size = new System.Drawing.Size(46, 17);
            this.rbtnDateAfter.TabIndex = 4;
            this.rbtnDateAfter.Text = "after";
            this.rbtnDateAfter.UseVisualStyleBackColor = true;
            // 
            // numOrderSerial
            // 
            this.numOrderSerial.Location = new System.Drawing.Point(160, 7);
            this.numOrderSerial.Name = "numOrderSerial";
            this.numOrderSerial.Size = new System.Drawing.Size(120, 20);
            this.numOrderSerial.TabIndex = 5;
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.rbtnAwaiting);
            this.gbxStatus.Controls.Add(this.rbtnCompleted);
            this.gbxStatus.Location = new System.Drawing.Point(74, 174);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(214, 48);
            this.gbxStatus.TabIndex = 6;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status";
            // 
            // rbtnCompleted
            // 
            this.rbtnCompleted.AutoSize = true;
            this.rbtnCompleted.Checked = true;
            this.rbtnCompleted.Location = new System.Drawing.Point(8, 19);
            this.rbtnCompleted.Name = "rbtnCompleted";
            this.rbtnCompleted.Size = new System.Drawing.Size(74, 17);
            this.rbtnCompleted.TabIndex = 0;
            this.rbtnCompleted.TabStop = true;
            this.rbtnCompleted.Text = "completed";
            this.rbtnCompleted.UseVisualStyleBackColor = true;
            // 
            // rbtnAwaiting
            // 
            this.rbtnAwaiting.AutoSize = true;
            this.rbtnAwaiting.Location = new System.Drawing.Point(142, 19);
            this.rbtnAwaiting.Name = "rbtnAwaiting";
            this.rbtnAwaiting.Size = new System.Drawing.Size(64, 17);
            this.rbtnAwaiting.TabIndex = 1;
            this.rbtnAwaiting.Text = "awaiting";
            this.rbtnAwaiting.UseVisualStyleBackColor = true;
            // 
            // rbtnOrderSerial
            // 
            this.rbtnOrderSerial.AutoSize = true;
            this.rbtnOrderSerial.Checked = true;
            this.rbtnOrderSerial.Location = new System.Drawing.Point(68, 10);
            this.rbtnOrderSerial.Name = "rbtnOrderSerial";
            this.rbtnOrderSerial.Size = new System.Drawing.Size(77, 17);
            this.rbtnOrderSerial.TabIndex = 7;
            this.rbtnOrderSerial.TabStop = true;
            this.rbtnOrderSerial.Text = "OrderSerial";
            this.rbtnOrderSerial.UseVisualStyleBackColor = true;
            this.rbtnOrderSerial.CheckedChanged += new System.EventHandler(this.rbtnOrderSerial_CheckedChanged);
            // 
            // rbtnInformation
            // 
            this.rbtnInformation.AutoSize = true;
            this.rbtnInformation.Location = new System.Drawing.Point(68, 29);
            this.rbtnInformation.Name = "rbtnInformation";
            this.rbtnInformation.Size = new System.Drawing.Size(77, 17);
            this.rbtnInformation.TabIndex = 8;
            this.rbtnInformation.Text = "Information";
            this.rbtnInformation.UseVisualStyleBackColor = true;
            this.rbtnInformation.CheckedChanged += new System.EventHandler(this.rbtnInformation_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 286);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.cbxStatus);
            this.gbxInformation.Controls.Add(this.cbxDate);
            this.gbxInformation.Controls.Add(this.cbxDealer);
            this.gbxInformation.Controls.Add(this.gbxDealer);
            this.gbxInformation.Controls.Add(this.gbxDate);
            this.gbxInformation.Controls.Add(this.gbxStatus);
            this.gbxInformation.Location = new System.Drawing.Point(68, 52);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(294, 228);
            this.gbxInformation.TabIndex = 11;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Search Option";
            // 
            // cbxDealer
            // 
            this.cbxDealer.AutoSize = true;
            this.cbxDealer.Location = new System.Drawing.Point(53, 19);
            this.cbxDealer.Name = "cbxDealer";
            this.cbxDealer.Size = new System.Drawing.Size(15, 14);
            this.cbxDealer.TabIndex = 7;
            this.cbxDealer.UseVisualStyleBackColor = true;
            // 
            // cbxDate
            // 
            this.cbxDate.AutoSize = true;
            this.cbxDate.Location = new System.Drawing.Point(53, 95);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(15, 14);
            this.cbxDate.TabIndex = 8;
            this.cbxDate.UseVisualStyleBackColor = true;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(53, 174);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(15, 14);
            this.cbxStatus.TabIndex = 9;
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // OrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 325);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbtnInformation);
            this.Controls.Add(this.rbtnOrderSerial);
            this.Controls.Add(this.numOrderSerial);
            this.Controls.Add(this.label1);
            this.Name = "OrderSearch";
            this.Text = "OrderSearch";
            this.Load += new System.EventHandler(this.OrderSearch_Load);
            this.gbxDealer.ResumeLayout(false);
            this.gbxDealer.PerformLayout();
            this.gbxDate.ResumeLayout(false);
            this.gbxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderSerial)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDealer;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.RadioButton rbtnDealerName;
        private System.Windows.Forms.RadioButton rbtnDealerID;
        private System.Windows.Forms.DateTimePicker dTimeSearchDate;
        private System.Windows.Forms.GroupBox gbxDate;
        private System.Windows.Forms.RadioButton rbtnDateAfter;
        private System.Windows.Forms.RadioButton rbtnDateBefore;
        private System.Windows.Forms.NumericUpDown numOrderSerial;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.RadioButton rbtnAwaiting;
        private System.Windows.Forms.RadioButton rbtnCompleted;
        private System.Windows.Forms.RadioButton rbtnOrderSerial;
        private System.Windows.Forms.RadioButton rbtnInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Windows.Forms.CheckBox cbxDate;
        private System.Windows.Forms.CheckBox cbxDealer;
    }
}
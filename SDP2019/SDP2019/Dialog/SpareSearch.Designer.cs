namespace SDP2019.Dialog
{
    partial class SpareSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpareSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSpareID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.rbtnQuantityBigger = new System.Windows.Forms.RadioButton();
            this.rbtnQuantitySmaller = new System.Windows.Forms.RadioButton();
            this.rbtnPriceSmaller = new System.Windows.Forms.RadioButton();
            this.rbtnPriceBigger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpareID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description / Key Word";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSpareID
            // 
            this.txtSpareID.Location = new System.Drawing.Point(155, 12);
            this.txtSpareID.Name = "txtSpareID";
            this.txtSpareID.Size = new System.Drawing.Size(202, 20);
            this.txtSpareID.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(155, 38);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(155, 90);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(202, 69);
            this.rtxtDesc.TabIndex = 10;
            this.rtxtDesc.Text = "";
            // 
            // rbtnQuantityBigger
            // 
            this.rbtnQuantityBigger.AutoSize = true;
            this.rbtnQuantityBigger.Location = new System.Drawing.Point(39, 10);
            this.rbtnQuantityBigger.Name = "rbtnQuantityBigger";
            this.rbtnQuantityBigger.Size = new System.Drawing.Size(31, 17);
            this.rbtnQuantityBigger.TabIndex = 11;
            this.rbtnQuantityBigger.Text = ">";
            this.rbtnQuantityBigger.UseVisualStyleBackColor = true;
            // 
            // rbtnQuantitySmaller
            // 
            this.rbtnQuantitySmaller.AutoSize = true;
            this.rbtnQuantitySmaller.Checked = true;
            this.rbtnQuantitySmaller.Location = new System.Drawing.Point(2, 10);
            this.rbtnQuantitySmaller.Name = "rbtnQuantitySmaller";
            this.rbtnQuantitySmaller.Size = new System.Drawing.Size(31, 17);
            this.rbtnQuantitySmaller.TabIndex = 12;
            this.rbtnQuantitySmaller.TabStop = true;
            this.rbtnQuantitySmaller.Text = "<";
            this.rbtnQuantitySmaller.UseVisualStyleBackColor = true;
            // 
            // rbtnPriceSmaller
            // 
            this.rbtnPriceSmaller.AutoSize = true;
            this.rbtnPriceSmaller.Checked = true;
            this.rbtnPriceSmaller.Location = new System.Drawing.Point(0, 8);
            this.rbtnPriceSmaller.Name = "rbtnPriceSmaller";
            this.rbtnPriceSmaller.Size = new System.Drawing.Size(31, 17);
            this.rbtnPriceSmaller.TabIndex = 13;
            this.rbtnPriceSmaller.TabStop = true;
            this.rbtnPriceSmaller.Text = "<";
            this.rbtnPriceSmaller.UseVisualStyleBackColor = true;
            // 
            // rbtnPriceBigger
            // 
            this.rbtnPriceBigger.AutoSize = true;
            this.rbtnPriceBigger.Location = new System.Drawing.Point(37, 8);
            this.rbtnPriceBigger.Name = "rbtnPriceBigger";
            this.rbtnPriceBigger.Size = new System.Drawing.Size(31, 17);
            this.rbtnPriceBigger.TabIndex = 14;
            this.rbtnPriceBigger.Text = ">";
            this.rbtnPriceBigger.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnQuantitySmaller);
            this.groupBox1.Controls.Add(this.rbtnQuantityBigger);
            this.groupBox1.Location = new System.Drawing.Point(261, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 28);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnPriceSmaller);
            this.groupBox2.Controls.Add(this.rbtnPriceBigger);
            this.groupBox2.Location = new System.Drawing.Point(260, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 28);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // SpareSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 203);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSpareID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpareSearch";
            this.Text = "SpareSearch";
            this.Load += new System.EventHandler(this.SpareSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSpareID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.RadioButton rbtnQuantityBigger;
        private System.Windows.Forms.RadioButton rbtnQuantitySmaller;
        private System.Windows.Forms.RadioButton rbtnPriceSmaller;
        private System.Windows.Forms.RadioButton rbtnPriceBigger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
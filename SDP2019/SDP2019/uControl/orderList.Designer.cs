namespace SDP2019.uControl
{
    partial class orderList
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.oL_OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_SpareList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_DealerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oL_DealerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button15);
            this.groupBox7.Controls.Add(this.button16);
            this.groupBox7.Controls.Add(this.button17);
            this.groupBox7.Location = new System.Drawing.Point(574, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 112);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data control";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(7, 48);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(178, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "Order Modify / Detail";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 77);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(178, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Delete Order";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(7, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(178, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "Search";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oL_OrderID,
            this.oL_OrderDate,
            this.oL_SpareList,
            this.oL_DealerID,
            this.oL_DealerName});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(1, 0);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(567, 399);
            this.listView4.TabIndex = 19;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // oL_OrderID
            // 
            this.oL_OrderID.Text = "OrderID";
            // 
            // oL_OrderDate
            // 
            this.oL_OrderDate.Text = "Order Date";
            this.oL_OrderDate.Width = 76;
            // 
            // oL_SpareList
            // 
            this.oL_SpareList.DisplayIndex = 3;
            this.oL_SpareList.Text = "Spare List";
            this.oL_SpareList.Width = 724;
            // 
            // oL_DealerID
            // 
            this.oL_DealerID.DisplayIndex = 2;
            this.oL_DealerID.Text = "DealerID";
            // 
            // oL_DealerName
            // 
            this.oL_DealerName.Text = "dealerName";
            // 
            // orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.listView4);
            this.Name = "orderList";
            this.Size = new System.Drawing.Size(767, 399);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader oL_OrderID;
        private System.Windows.Forms.ColumnHeader oL_OrderDate;
        private System.Windows.Forms.ColumnHeader oL_SpareList;
        private System.Windows.Forms.ColumnHeader oL_DealerID;
        private System.Windows.Forms.ColumnHeader oL_DealerName;
    }
}

namespace SDP2019
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtLogonID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabTopBar = new System.Windows.Forms.TabControl();
            this.Setting = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.u_UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_UserType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.UserInfo = new System.Windows.Forms.TabPage();
            this.Password = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.tabTopBar.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogonID
            // 
            this.txtLogonID.Location = new System.Drawing.Point(697, 0);
            this.txtLogonID.Name = "txtLogonID";
            this.txtLogonID.ReadOnly = true;
            this.txtLogonID.Size = new System.Drawing.Size(100, 20);
            this.txtLogonID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Staff ID:";
            // 
            // tabTopBar
            // 
            this.tabTopBar.Controls.Add(this.Setting);
            this.tabTopBar.Location = new System.Drawing.Point(13, 13);
            this.tabTopBar.Name = "tabTopBar";
            this.tabTopBar.SelectedIndex = 0;
            this.tabTopBar.Size = new System.Drawing.Size(775, 425);
            this.tabTopBar.TabIndex = 0;
            this.tabTopBar.SelectedIndexChanged += new System.EventHandler(this.tabTopBar_SelectedIndexChanged);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.tabControl2);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(767, 399);
            this.Setting.TabIndex = 4;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(761, 393);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 367);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "User List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(0, 0);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(567, 367);
            this.listView5.TabIndex = 1;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // u_UserID
            // 
            this.u_UserID.DisplayIndex = 0;
            this.u_UserID.Text = "UserID";
            this.u_UserID.Width = 67;
            // 
            // u_Password
            // 
            this.u_Password.DisplayIndex = 1;
            this.u_Password.Text = "Password";
            this.u_Password.Width = 71;
            // 
            // u_Department
            // 
            this.u_Department.DisplayIndex = 2;
            this.u_Department.Text = "Department";
            this.u_Department.Width = 47;
            // 
            // u_UserType
            // 
            this.u_UserType.DisplayIndex = 3;
            this.u_UserType.Text = "UserType";
            this.u_UserType.Width = 79;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(573, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(174, 110);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(7, 19);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(161, 23);
            this.button18.TabIndex = 1;
            this.button18.Text = "Add User";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(7, 48);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(161, 23);
            this.button19.TabIndex = 2;
            this.button19.Text = "Change Password";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(7, 77);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(161, 23);
            this.button20.TabIndex = 3;
            this.button20.Text = "Delete User";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // UserInfo
            // 
            this.UserInfo.Location = new System.Drawing.Point(4, 22);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfo.Size = new System.Drawing.Size(753, 367);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Text = "User Info";
            this.UserInfo.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(4, 22);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(3);
            this.Password.Size = new System.Drawing.Size(753, 367);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password";
            this.Password.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(205, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 184);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(261, 141);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLogonID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabTopBar.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogonID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabTopBar;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader u_UserID;
        private System.Windows.Forms.ColumnHeader u_Password;
        private System.Windows.Forms.ColumnHeader u_Department;
        private System.Windows.Forms.ColumnHeader u_UserType;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TabPage UserInfo;
        private System.Windows.Forms.TabPage Password;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
    }
}
namespace SDP2019.uControl
{
    partial class settingTab
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "AA12345",
            "1",
            "2",
            "3",
            "4",
            "5"}, -1);
            this.tabTopBar = new System.Windows.Forms.TabControl();
            this.Password = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.TabPage();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.rtxtDepartmentDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnUserPwdReset = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.listView5 = new System.Windows.Forms.ListView();
            this.u_UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.u_UserType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.tabTopBar.SuspendLayout();
            this.Password.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTopBar
            // 
            this.tabTopBar.Controls.Add(this.Password);
            this.tabTopBar.Controls.Add(this.UserInfo);
            this.tabTopBar.Controls.Add(this.tabPage1);
            this.tabTopBar.Location = new System.Drawing.Point(3, 3);
            this.tabTopBar.Name = "tabTopBar";
            this.tabTopBar.SelectedIndex = 0;
            this.tabTopBar.Size = new System.Drawing.Size(761, 393);
            this.tabTopBar.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Controls.Add(this.groupBox5);
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
            this.groupBox5.Controls.Add(this.txtOldPwd);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btnUpdatePassword);
            this.groupBox5.Controls.Add(this.txtConfirmPwd);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtNewPwd);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(205, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 184);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Change Password";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(188, 33);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(125, 20);
            this.txtOldPwd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter old password:";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(238, 142);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePassword.TabIndex = 4;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(188, 100);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(125, 20);
            this.txtConfirmPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "enter new password again:";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(188, 64);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(125, 20);
            this.txtNewPwd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new password:";
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.btnUpdateInfo);
            this.UserInfo.Controls.Add(this.txtUserType);
            this.UserInfo.Controls.Add(this.txtUserName);
            this.UserInfo.Controls.Add(this.txtDepartmentName);
            this.UserInfo.Controls.Add(this.rtxtDepartmentDesc);
            this.UserInfo.Controls.Add(this.label7);
            this.UserInfo.Controls.Add(this.label6);
            this.UserInfo.Controls.Add(this.label5);
            this.UserInfo.Controls.Add(this.label4);
            this.UserInfo.Location = new System.Drawing.Point(4, 22);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfo.Size = new System.Drawing.Size(753, 367);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Text = "User Info";
            this.UserInfo.UseVisualStyleBackColor = true;
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(95, 164);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.Size = new System.Drawing.Size(146, 20);
            this.txtUserType.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 82);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(146, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(337, 82);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.ReadOnly = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(146, 20);
            this.txtDepartmentName.TabIndex = 5;
            // 
            // rtxtDepartmentDesc
            // 
            this.rtxtDepartmentDesc.Location = new System.Drawing.Point(337, 164);
            this.rtxtDepartmentDesc.Name = "rtxtDepartmentDesc";
            this.rtxtDepartmentDesc.ReadOnly = true;
            this.rtxtDepartmentDesc.Size = new System.Drawing.Size(146, 55);
            this.rtxtDepartmentDesc.TabIndex = 4;
            this.rtxtDepartmentDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Department Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Department Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.listView5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 367);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "User List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnUserDel);
            this.groupBox8.Controls.Add(this.btnUserPwdReset);
            this.groupBox8.Controls.Add(this.btnUserAdd);
            this.groupBox8.Location = new System.Drawing.Point(573, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(174, 110);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "User Contral";
            // 
            // btnUserDel
            // 
            this.btnUserDel.Location = new System.Drawing.Point(7, 77);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(161, 23);
            this.btnUserDel.TabIndex = 3;
            this.btnUserDel.Text = "Delete User";
            this.btnUserDel.UseVisualStyleBackColor = true;
            // 
            // btnUserPwdReset
            // 
            this.btnUserPwdReset.Location = new System.Drawing.Point(7, 48);
            this.btnUserPwdReset.Name = "btnUserPwdReset";
            this.btnUserPwdReset.Size = new System.Drawing.Size(161, 23);
            this.btnUserPwdReset.TabIndex = 2;
            this.btnUserPwdReset.Text = "Reset Password";
            this.btnUserPwdReset.UseVisualStyleBackColor = true;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(7, 19);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(161, 23);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "Add User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.u_UserID,
            this.u_Password,
            this.u_Department,
            this.u_UserType});
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.HideSelection = false;
            this.listView5.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView5.Location = new System.Drawing.Point(0, 0);
            this.listView5.MultiSelect = false;
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(567, 367);
            this.listView5.TabIndex = 1;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // u_UserID
            // 
            this.u_UserID.Text = "UserID";
            this.u_UserID.Width = 67;
            // 
            // u_Password
            // 
            this.u_Password.Text = "Password";
            this.u_Password.Width = 71;
            // 
            // u_Department
            // 
            this.u_Department.Text = "Department";
            this.u_Department.Width = 75;
            // 
            // u_UserType
            // 
            this.u_UserType.Text = "UserType";
            this.u_UserType.Width = 79;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(166, 108);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateInfo.TabIndex = 8;
            this.btnUpdateInfo.Text = "Update";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // settingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabTopBar);
            this.Name = "settingTab";
            this.Size = new System.Drawing.Size(767, 399);
            this.Load += new System.EventHandler(this.settingTab_Load);
            this.tabTopBar.ResumeLayout(false);
            this.Password.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.UserInfo.ResumeLayout(false);
            this.UserInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTopBar;
        private System.Windows.Forms.TabPage Password;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage UserInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.Button btnUserPwdReset;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader u_UserID;
        private System.Windows.Forms.ColumnHeader u_Password;
        private System.Windows.Forms.ColumnHeader u_Department;
        private System.Windows.Forms.ColumnHeader u_UserType;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.RichTextBox rtxtDepartmentDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateInfo;
    }
}

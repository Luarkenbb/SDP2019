using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP2019.uControl
{
    public partial class settingTab : UserControl
    {
        string frmLogonID;
        string frmUserType;


        DBConnection conn;
        

        public settingTab(string frmLogonID , string frmUserType)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.frmUserType = frmUserType;
        }

        private void settingTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            permissionHandle(frmUserType);

            getUserInfo();
        }


        private void permissionHandle(string userType)
        {
            if (!userType.Equals("admin"))
            {
                tabTopBar.TabPages.Remove(tabTopBar.TabPages[2]);
            }
        }

        private void getUserInfo()
        {
            string sql = "SELECT user.name, user.userType, department.departmentName, department.description ";
            sql += "FROM user, department ";
            sql += "WHERE user.departmentID = department.departmentID ";
            sql += "AND user.logonID = " + frmLogonID;

            conn.OpenConnection();
            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            txtUserName.Text = row[0].ToString();
            txtUserType.Text = row[1].ToString();
            txtDepartmentName.Text = row[2].ToString();
            rtxtDepartmentDesc.Text = row[3].ToString();

            conn.CloseConnection();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (isCorrectPassword(txtOldPwd.Text))
            {
                if (txtNewPwd.Text.Equals(txtConfirmPwd.Text))
                {
                    updatePassword(txtNewPwd.Text);
                    MessageBox.Show("Update Successful!");
                }
                else
                {
                    MessageBox.Show("Confirmation Fail!\n Please Make sure you have type in the same password in confirmation box!");
                }
            }
            else
            {
                MessageBox.Show("Your password is wrong!");
            }
        }
        private void updatePassword(string input)
        {
            string encrypted = Cryptography.Encrypt(input);
            string sql = "UPDATE user SET logonPassword = '" + encrypted + "' WHERE logonID = " + frmLogonID;
            conn.OpenConnection();
            conn.ExecuteUpdateQuery(sql);

            conn.CloseConnection();
        }
        private Boolean isCorrectPassword(string input)
        {
            Boolean isValid = false;
            string passwordFromDatabase;
            string encrypted = Cryptography.Encrypt(input);
            
            string sql = "SELECT logonPassword FROM user WHERE logonID = " + frmLogonID;
            conn.OpenConnection();
            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            passwordFromDatabase = row[0].ToString();

            conn.CloseConnection();

            if (passwordFromDatabase.Equals(encrypted))
            {
                isValid = true;
            }
            return isValid;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE user set name = '" + txtUserName.Text + "' WHERE logonID = " + frmLogonID;
            conn.OpenConnection();
            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
            MessageBox.Show("Successful Updated Your Name!");

        }
    }
}

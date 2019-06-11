using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP2019
{
    public partial class LoginForm : Form
    {
        DBConnection conn;
        string frmLogonID;
        string frmName;
        string frmUserType;
        string frmDepartmentID;

        public LoginForm()
        {
            InitializeComponent();
            conn = new DBConnection();
            lblLogonFail.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string logonID = "";
            string logonpassword = "";
            logonpassword = Cryptography.Encrypt(txtPassword.Text.ToString());
            logonID = txtLoginName.Text.ToString();

            if (logonChecking(logonID, logonpassword)) {//Check if input is missing
                if (logon(logonID, logonpassword))
                {
                    lblLogonFail.Hide();
                    MessageBox.Show("Welcome," + frmName);

                    Main main = new Main(frmLogonID,frmName,frmUserType,frmDepartmentID);
                    main.ShowDialog();
                }
                else
                {
                    lblLogonFail.Show();
                }
            }
        }

        private Boolean logon(string logonID, string logonpassword)
        {
            Boolean isValid = false;
            conn.OpenConnection();

            string sql = "Select * from user Where logonID = " + logonID + " AND logonPassword = '" + logonpassword + "'";
            DataTable dt = conn.ExecuteSelectQuery(sql);
            if (dt.Rows.Count == 1)
            {
                isValid = true;

                DataRow row = dt.Rows[0];
                frmLogonID = row[0].ToString();
                frmName = row[2].ToString();
                frmUserType = row[3].ToString();
                frmDepartmentID = row[4].ToString();
            }


            conn.CloseConnection();
            return isValid;
        }

        private Boolean logonChecking(string logonID, string logonpassword)
        {
            Boolean isValid = false;
            if (logonID != "" && logonpassword != "")
            {
                isValid = true;
            }
            return isValid;
        }
    }
}


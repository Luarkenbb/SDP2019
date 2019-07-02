using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP2019.Dialog
{
    public partial class UserAdd : Form
    {
        DBConnection conn;
        int logonID;

        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getNextID();
            getDepartments();
        }

        private void getNextID()
        {
            string sql = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'sdp' AND TABLE_NAME = 'user'";
            conn.OpenConnection();
            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            logonID = Convert.ToInt32(row[0].ToString());

            conn.CloseConnection();
            txtLogonID.Text = logonID.ToString();

        }
        private void getDepartments()
        {
            /*
              ComboboxItem item = new ComboboxItem();
    item.Text = "Item text1";
    item.Value = 12;

    comboBox1.Items.Add(item);
             */
            string sql = "SELECT departmentID, departmentName FROM department";
            conn.OpenConnection();
            DataTable dt = conn.ExecuteSelectQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row[1].ToString();
                item.Value = row[0].ToString();

                cboxDepartment.Items.Add(item);
                
            }

            conn.CloseConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cboxType.Text;
            string department = (cboxDepartment.SelectedItem as ComboboxItem).Value;
            string sql = "INSERT INTO user(logonPassword,name,userType,departmentID) VALUES(";
            sql += "'" + Cryptography.Encrypt("123456") + "',";
            sql += "'" + txtName.Text + "',";
            sql += "'" + type + "',";
            sql += department;
            sql += ")";
            
            
            
            conn.OpenConnection();
            conn.ExecuteInsertQuery(sql);

            conn.CloseConnection();
            MessageBox.Show("The new ID:" + txtLogonID.Text + "\n password: 123456");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}

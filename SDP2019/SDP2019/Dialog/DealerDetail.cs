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
    public partial class DealerDetail : Form
    {
        string dealerID;
        DBConnection conn;
        

        public DealerDetail(string dealerID)
        {
            InitializeComponent();
            this.dealerID = dealerID;
        }

        private void DealerDetail_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getDealerDetail();
        }

        private void getDealerDetail()
        {
            conn.OpenConnection();
            // id name address phone;
            string sql = "SELECT * FROM dealer WHERE dealerID = " + dealerID;

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];

            txtDealerID.Text = row[0].ToString();
            txtName.Text = row[1].ToString();
            rtxtAddress.Text = row[2].ToString();
            txtPhone.Text = row[3].ToString();


            conn.CloseConnection();
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhone.Text,out int n))
            {
                MessageBox.Show("This is not a valid phone!");
                return;
            }

            conn.OpenConnection();
            string sql = "UPDATE dealer SET ";
            sql += "name = '" + txtName.Text + "', ";
            sql += "address = '" + rtxtAddress.Text + "', ";
            sql += "phone = " + txtPhone.Text + " ";            
            sql += "WHERE dealerID = '" + dealerID + "'";

            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SpareDetail : Form
    {
        string spareID;
        DBConnection conn;
        public SpareDetail()
        {
            InitializeComponent();
        }
        public SpareDetail(string spareID)
        {
            InitializeComponent();
            this.spareID = spareID;
        }

        private void SpareDetail_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            txtSpareID.Text = spareID;
            getSpareInfo();

            try
            {
                txtQuantity.Text = Convert.ToInt32(txtQuantity.Text).ToString();
            }
            catch
            {
                txtQuantity.Text = "0";
            }
            try
            {
                txtQuantitySafeLine.Text = Convert.ToInt32(txtQuantitySafeLine.Text).ToString();
            }
            catch
            {
                txtQuantitySafeLine.Text = "0";
            }
        }

        private void getSpareInfo()
        {
            conn.OpenConnection();
            string sql = "SELECT SpareId,quantity,quantitySafeLine,description,price FROM spare WHERE SpareID = '" + spareID + "'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            txtQuantity.Text = row[1].ToString();
            txtQuantitySafeLine.Text = row[2].ToString();
            rtxtDesc.Text = row[3].ToString();
            txtPrice.Text = row[4].ToString();

            conn.CloseConnection();

        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            updateNewQuantity(true);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            updateNewQuantity(false);
        }

        private void updateNewQuantity(Boolean isAdd)
        {
            int quantity = 0;
            int amount = Convert.ToInt32(numQuantity.Value);
            
                quantity += Convert.ToInt32(txtQuantity.Text);
            
            if (isAdd)
            {
                quantity += amount;
            }
            else
            {
                if (quantity < amount)
                {
                    MessageBox.Show("You can't reduce that much!");
                }
                else
                {
                    quantity -= amount;
                }
            }

            txtQuantity.Text = quantity.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string spareID = txtSpareID.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int quantitySafeLine;
            string description = rtxtDesc.Text;
            int price = Convert.ToInt32(txtPrice.Text);

            try
            {
                quantitySafeLine = Convert.ToInt32(txtQuantitySafeLine.Text);
            }
            catch
            {
                MessageBox.Show("Safe Line is not a number!");
                return;
            }

            conn.OpenConnection();
            string sql = "UPDATE spare SET ";
            sql += "quantity = " + quantity + ", ";
            sql += "quantitySafeLine = " + quantitySafeLine + ", ";
            sql += "description = '" + description +"',";
            sql += "price = " + price + " ";
            sql += "WHERE SpareID = '" + spareID + "'";

            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}

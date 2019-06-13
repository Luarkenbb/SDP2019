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
    public partial class SpareNewItem : Form
    {
        DBConnection conn;
        public SpareNewItem()
        {
            InitializeComponent();
        }

        private void SpareNewItem_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string spareID;
            int price;
            string desc;
            if (isNullStr(txtSpareID.Text) || !isInt(txtPrice.Text) || isNullStr(rtxtDesc.Text))
            {
                return;
            }
            else
            {
                spareID = txtSpareID.Text;
                price = Convert.ToInt32(txtPrice.Text);
                desc = rtxtDesc.Text;

                conn.OpenConnection();
                string sql = "INSERT INTO spare(SpareID,price,description) VALUES('"+spareID+"',"+price+ ",'"+desc+"')";
                conn.ExecuteUpdateQuery(sql);
                conn.CloseConnection();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private Boolean isNullStr(string str)
        {
            Boolean isValid = false;
            if (str.Trim() == "")
            {
                return true;
            }
            return isValid;
        }
        private Boolean isInt(string str)
        {
            Boolean isValid = true;
            try
            {
                Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }
            return isValid;
        }
    }
}

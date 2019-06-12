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
    public partial class EditSpareQuantity : Form
    {
        DBConnection conn;

        private string spareID;
        private int quantity;
        private int total;
        private int previousPricePerItem = 0;
        //getter setter
        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getTotal()
        {
            return this.total;
        }
        public void setTotal(int total)
        {
            this.total = total;
        }
        //end of getter and setter



        public EditSpareQuantity()
        {
            InitializeComponent();
        }
        public EditSpareQuantity(string spareID, int quantity)
        {
            InitializeComponent();

            setQuantity(quantity);
            this.spareID = spareID;
            
        }
        public EditSpareQuantity(string spareID, int quantity, int previousPricePerItem)
        {
            InitializeComponent();
            setQuantity(quantity);
            this.spareID = spareID;
            this.previousPricePerItem = previousPricePerItem;
        }

        private void EditSpareQuantity_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            if (spareID != null)
            {
                getSpareInfo();
            }
        }

        private void getSpareInfo()
        {
            conn.OpenConnection();

            string sql = "Select SpareID, description, quantity, price from spare Where SpareID = '" + spareID +"'";
            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            showSpareInfo(row);

            conn.CloseConnection();
        }
        private void showSpareInfo(DataRow row)
        {
            txtSpareID.Text = row[0].ToString();
            txtSpareDesc.Text = row[1].ToString();
            txtSpareStock.Text = row[2].ToString();

            if (this.previousPricePerItem == 0) {
                txtSparePrice.Text = row[3].ToString();
            }else{
                txtSparePrice.Text = this.previousPricePerItem.ToString();
            }
            numQuantity.Value = this.quantity;
        }
        

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = Decimal.ToInt32(numQuantity.Value);
            total = Convert.ToInt32(txtSparePrice.Text) * quantity;
            txtTotal.Text = total.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

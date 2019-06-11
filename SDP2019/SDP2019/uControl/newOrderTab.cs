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
    public partial class newOrderTab : UserControl
    {
        DBConnection conn;
        string frmLogonID;


        public newOrderTab()
        {
            InitializeComponent();
        }
        public newOrderTab(string frmLogonID)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
        }

        public void addNewOrderSpare(ListViewItem item)
        {
            lstOrderFrmSpares.Items.Add(item);
        }
        public void addDealer(string id,string name,string address,string phone)
        {
            txtOrderFrmDealerID.Text = id;
            txtOrderFrmDealerName.Text = name;
            rtxtOrderFrmInvoiceAddress.Text = address;
            txtOrderFrmDealerPhone.Text = phone;
        }


        private void newOrderTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
        }
        private void btnOrderFrmSelectDealer_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderFrmDelAllSpares_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderFrmAddSpare_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderFrmDelSpare_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Remove All Selected spares?", "Clear Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstOrderFrmSpares.SelectedItems)
                {
                    lstOrderFrmSpares.Items.Remove(item);
                }
            }
        }

        private void btnOrderFrmClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to clear all the information in this form?", "Clear Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                txtOrderFrmDealerID.Clear();
                txtOrderFrmDealerName.Clear();
                rtxtOrderFrmInvoiceAddress.Clear();
                txtOrderFrmDealerPhone.Clear();

                lstOrderFrmSpares.Items.Clear();
            }

        }
        

        private void lstOrderFrmSpares_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                string spareID = clickedItem.SubItems[0].Text;
                int quantity = Convert.ToInt32(clickedItem.SubItems[1].Text);

                using (Dialog.EditSpareQuantity dlg = new Dialog.EditSpareQuantity(spareID, quantity))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        clickedItem.SubItems[1].Text = dlg.getQuantity().ToString();
                        clickedItem.SubItems[5].Text = dlg.getTotal().ToString();
                    }
                }
            }
        }
        private void btnOrderFrmNewOrder_Click(object sender, EventArgs e)
        {
            if (isValidOrderForm())
            {
                orderFromCreateOrder();
            }
            else
            {
                MessageBox.Show("You have information missing!Please check your form");
            }

        }
        private void orderFromCreateOrder()
        {
            DateTime localDate = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string time = "'" + localDate.ToString(format) + "'";

            conn.OpenConnection();
            string sql = "Insert into orderlist(dealerID,invoiceAddress,deliverAddress,createDateTime,orderClerkID) VALUES (";
            sql += txtOrderFrmDealerID.Text + ",'" + rtxtOrderFrmInvoiceAddress.Text + "','" + rtxtOrderFrmDeliverAddress.Text + "'," + time + "," + frmLogonID;
            sql += ")";
            MessageBox.Show(sql);
            int key = conn.ExecuteInsertQuery(sql);
            orderFromCreateOrderSpare(key);

            conn.CloseConnection();
        }
        private void orderFromCreateOrderSpare(int orderSerial)
        {
            /*require connection existing!!!!*/
            foreach (ListViewItem item in lstOrderFrmSpares.Items)
            {
                string spareID = item.SubItems[0].Text;
                int quantityTotal = Convert.ToInt32(item.SubItems[1].Text);
                int pricePerItem = Convert.ToInt32(item.SubItems[2].Text);
                string status = "awaiting";
                string sql = "Insert into orderspare(orderSerial,spareID,quantityTotal,pricePerItem,status) VAlUES(";
                sql += orderSerial + ",'" + spareID + "'," + quantityTotal + "," + pricePerItem + ",'" + status + "'";
                sql += ")";
                conn.ExecuteInsertQuery(sql);
            }

        }
        private Boolean isValidOrderForm()
        {
            Boolean isValid = true;
            if (txtOrderFrmDealerID.Text.Trim() == null)
            {
                isValid = false;
            }
            if (txtOrderFrmDealerName.Text.Trim() == null)
            {
                isValid = false;
            }
            if (txtOrderFrmDealerPhone.Text.Trim() == null)
            {
                isValid = false;
            }
            if (rtxtOrderFrmDeliverAddress.Text.Trim() == null)
            {
                isValid = false;
            }
            if (rtxtOrderFrmInvoiceAddress.Text.Trim() == null)
            {
                isValid = false;
            }
            if (lstOrderFrmSpares.Items.Count <= 0)
            {
                isValid = false;
            }
            return isValid;
        }

        
    }
}

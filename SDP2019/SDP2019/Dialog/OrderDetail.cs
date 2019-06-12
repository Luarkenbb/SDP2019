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
    public partial class OrderDetail : Form
    {
        DBConnection conn;
        string frmLogonID;
        int orderSerial;

        public OrderDetail()
        {
            InitializeComponent();
        }
        public OrderDetail(int orderSerial, string frmLogonID)
        {
            InitializeComponent();
            this.orderSerial = orderSerial;
            this.frmLogonID = frmLogonID;
        }


        private void OrderDetail_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            lstSpare.Items.Clear();
            getOrderInfo();
            
        }

        private void getOrderInfo()
        {
            conn.OpenConnection();
            string sql = "SELECT orderlist.orderSerial, orderlist.orderClerkID,orderlist.createDateTime,orderlist.completeDateTime,dealer.dealerID,dealer.name,dealer.phone,orderlist.invoiceAddress,orderlist.deliverAddress,orderlist.storemanID ";
            sql += "from orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID ";
            sql += "AND orderlist.orderSerial = " + orderSerial;

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];

            txtOrderID.Text = orderSerial.ToString();
            txtOrderStaff.Text = row[1].ToString();
            txtStartDate.Text = row[2].ToString();
            txtEndDate.Text = row[3].ToString();
            txtDealerID.Text = row[4].ToString();
            txtDealerName.Text = row[5].ToString();
            txtDealerPhone.Text = row[6].ToString();
            rtxtInvoiceAddress.Text = row[7].ToString();
            rtxtDeliverAddress.Text = row[8].ToString();
            txtStoremanID.Text = row[9].ToString();

            conn.CloseConnection();

            getSpareInfo(orderSerial);
        }
        private void getSpareInfo(int orderSerial)
        {
            conn.OpenConnection();
            string sql = "SELECT orderspare.spareID, orderspare.quantityTotal, orderspare.pricePerItem, spare.quantitySafeLine, spare.quantity, spare.description, orderspare.status,orderspare.toDeliverQuantity FROM orderspare, spare WHERE orderspare.spareID = spare.SpareID AND orderspare.orderSerial = '";
            sql += orderSerial + "'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstSpare.Items.Add(item);
            }


            conn.CloseConnection();
        }
        private Boolean isEditableSpare(ListViewItem item)
        {
            Boolean isValid = false;
            if (item.SubItems[6].Text == "awaiting")
            {
                isValid = true;
            }

            return isValid;
        }

        private void btnAddSpare_Click(object sender, EventArgs e)
        {
            using (Dialog.SpareSelect dlg = new Dialog.SpareSelect())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem selectedItem = dlg.getSelectedItem(); //spare quantity pricePerItem quantitySafeLine desc

                    ListViewItem addToLst = new ListViewItem(selectedItem.SubItems[0].Text);
                    addToLst.SubItems.Add("1");
                    addToLst.SubItems.Add(selectedItem.SubItems[2]);
                    addToLst.SubItems.Add(selectedItem.SubItems[3]);
                    addToLst.SubItems.Add(selectedItem.SubItems[1]);
                    addToLst.SubItems.Add(selectedItem.SubItems[4]);
                    addToLst.SubItems.Add("awaiting");
                    lstSpare.Items.Add(addToLst);
                }
            }
        }

        private void btnDelSpare_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Remove All Selected spares?", "Clear Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstSpare.SelectedItems)
                {
                    if (isEditableSpare(item)) {
                        lstSpare.Items.Remove(item);
                    }
                    else
                    {
                        string spareID = item.SubItems[0].Text;
                        MessageBox.Show("This order with spareID:" + spareID + " is already packaged!\nIt cannot be edited or remove!");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSetQuantity_Click(object sender, EventArgs e)
        {
            if (lstSpare.SelectedItems.Count > 1)
            {
                MessageBox.Show("You should select 1 item only!");
                return;
            }else if (lstSpare.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected");
                return;
            }

            ListViewItem item = lstSpare.SelectedItems[0];
            string spareID = item.SubItems[0].Text;

            if (!isEditableSpare(item))
            {
                MessageBox.Show("This order with spareID:" + spareID + " is already packaged!\nIt cannot be edited or remove!");
                return;
            }

            int quantity = Convert.ToInt32(item.SubItems[1].Text);
            int previousPricePerItem = Convert.ToInt32(item.SubItems[2].Text);
            using (Dialog.EditSpareQuantity dlg = new Dialog.EditSpareQuantity(spareID,quantity,previousPricePerItem))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    quantity = dlg.getQuantity();
                    item.SubItems[1].Text = quantity.ToString();
                }
            }
        }
    }
}

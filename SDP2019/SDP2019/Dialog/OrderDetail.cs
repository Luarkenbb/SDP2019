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
        LinkedList<string> spareIDs = new LinkedList<string>(); // 一入張Form 原本有既spare! 
        LinkedList<string> delSpareIDs = new LinkedList<string>();

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
            getSpareIDsBeforeEdit();
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
        private void getSpareIDsBeforeEdit()
        {
            foreach (ListViewItem item in lstSpare.Items)
            {
                spareIDs.AddLast(item.SubItems[0].Text);
            }
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
            if (txtEndDate.Text == "") {
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

                        if (delSpareIDs.Contains(selectedItem.SubItems[0].Text))
                        {
                            delSpareIDs.Remove(selectedItem.SubItems[0].Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("this is a completed order! You can only view this order");
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
                        delSpareIDs.AddLast(item.SubItems[0].Text);
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
            updateOrderInfo();
            updateOrderSpareInfo();
            deleteOrderSpareInfo();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void updateOrderInfo()
        {
            conn.OpenConnection();

            string sql = "UPDATE orderlist SET ";
            sql += "invoiceAddress = '" +rtxtInvoiceAddress.Text + "',";
            sql += "deliverAddress = '" + rtxtDeliverAddress.Text + "'";
            sql += " WHERE orderSerial = '" + orderSerial +"'";

            conn.ExecuteUpdateQuery(sql);

            conn.CloseConnection();
        }


        private void updateOrderSpareInfo()
        {
            string sql;
            string spareID;
            int quantityTotal;
            int pricePerItem;
            string status;
            string toDeliverQuantity;
            conn.OpenConnection();

            foreach (ListViewItem item in lstSpare.Items)
            {
                spareID = item.SubItems[0].Text;
                quantityTotal = Convert.ToInt32(item.SubItems[1].Text);
                status = item.SubItems[6].Text;
                pricePerItem = Convert.ToInt32(item.SubItems[2].Text);

                if (item.SubItems.Count < 8)
                {
                    toDeliverQuantity = "NULL";
                }
                else
                {
                    if (item.SubItems[7].Text.Trim() == "")
                    {
                        toDeliverQuantity = "NULL";
                    }
                    else
                    {
                        toDeliverQuantity = item.SubItems[7].Text.Trim();
                    }
                }
              
                

                if (spareIDs.Contains(spareID))
                {
                    //update
                    sql = "UPDATE orderspare SET ";
                    sql += "quantityTotal = " + quantityTotal + ",";
                    sql += "status = '" + status + "',";
                    sql += "toDeliverQuantity = " + toDeliverQuantity;
                    sql += " WHERE orderSerial = " + orderSerial + " AND spareID = '" + spareID + "'";

                    MessageBox.Show(sql);
                    conn.ExecuteUpdateQuery(sql);
                }
                else
                {
                    //insert
                    sql = "Insert into orderspare(orderSerial,spareID,quantityTotal,pricePerItem,status) VAlUES(";
                    sql += orderSerial + ",'" + spareID + "'," + quantityTotal + "," + pricePerItem + ",'" + status + "'";
                    sql += ")";

                    conn.ExecuteInsertQuery(sql);
                }

                sql = "";
            }
            conn.CloseConnection();
        }
        private void deleteOrderSpareInfo()
        {
            conn.OpenConnection();
            foreach (string spareID in delSpareIDs)
            {
                string sql = "DELETE FROM orderspare WHERE orderSerial = " + orderSerial + " AND spareID = '" + spareID + "'";
                conn.ExecuteUpdateQuery(sql);
            }
            conn.CloseConnection();
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

        private void btnToFollow_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            string sql;
            DateTime localDate = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string time = "'" + localDate.ToString(format) + "'";

            if (isAllSparePackaged(orderSerial))
            {
                conn.OpenConnection();
                sql = "UPDATE orderlist SET ";
                sql += "completeDateTime = " + time + ", ";
                sql += "storemanID = " + frmLogonID + " ";
                sql += "WHERE orderSerial = " + orderSerial;

                conn.ExecuteUpdateQuery(sql);

                conn.CloseConnection();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("This order have spare awaiting! This is not a completed order!");
            }

            
        }
        private Boolean isAllSparePackaged(int orderSerial)
        {
            Boolean isPackaged = true;
            conn.OpenConnection();
            string sql;

            sql = "SELECT status FROM orderspare WHERE orderSerial = " + orderSerial;
            DataTable dt = conn.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == "awaiting")
                    {
                        isPackaged = false;
                        break;
                    }
                }
            }


            conn.CloseConnection();
            return isPackaged;
        }
        private void btnUpdateSpareStatus_Click(object sender, EventArgs e)
        {
            if (lstSpare.SelectedItems.Count > 1)
            {
                MessageBox.Show("You should select 1 item only!");
                return;
            }
            else if (lstSpare.SelectedItems.Count == 0)
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

            using (Dialog.SpareUpdateStatus dlg = new Dialog.SpareUpdateStatus(spareID,orderSerial))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lstSpare.Items.Clear();
                    getSpareInfo(orderSerial);
                }
            }

        }
    }
}

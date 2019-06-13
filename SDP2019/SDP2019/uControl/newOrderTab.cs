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
        TabControl tab;
        string frmLogonID;
        int tabSpare;
        int tabDealer;

        public newOrderTab()
        {
            InitializeComponent();
        }
        public newOrderTab(string frmLogonID,int tabSpare,int tabDealer)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.tabSpare = tabSpare;
            this.tabDealer = tabDealer;
        }

        public void addNewOrderSpare(ListViewItem item)
        {
            string spareID = item.SubItems[0].Text;
            if (!isSelectedSpare(spareID))
            {
                lstOrderFrmSpares.Items.Add(item);
            }
            else
            {
                MessageBox.Show("This item is already selected!");
            }

        }
        



        public void addDealer(string id,string name,string address,string phone)
        {
            txtOrderFrmDealerID.Text = id;
            txtOrderFrmDealerName.Text = name;
            rtxtOrderFrmInvoiceAddress.Text = address;
            txtOrderFrmDealerPhone.Text = phone;
        }
        private Boolean isSelectedSpare(string spareID)
        {
            Boolean isSelected = false;
            foreach (ListViewItem item in lstOrderFrmSpares.Items)
            {
                if (item.SubItems[0].Text == spareID)
                {
                    return true;
                }
            }
            return isSelected;
        }

        private void newOrderTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            tab = (TabControl)this.Parent.Parent;

        }
        private void btnOrderFrmSelectDealer_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = tabDealer;
        }

        private void btnOrderFrmDelAllSpares_Click(object sender, EventArgs e)
        {
            lstOrderFrmSpares.Items.Clear();
        }

        private void btnOrderFrmAddSpare_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = tabSpare;
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
                showEditSpareQuantity(clickedItem);
            }
        }

        private void btnSetQuantity_Click(object sender, EventArgs e)
        {
            var selectedItem = lstOrderFrmSpares.SelectedItems;
            if (selectedItem.Count == 0)
            {
                MessageBox.Show("You have no item selected!");
            }else if (selectedItem.Count != 1)
            {
                MessageBox.Show("You should have one item selected only!");
            }
            else
            {
                showEditSpareQuantity(selectedItem[0]);
            }

        }
        private void showEditSpareQuantity(ListViewItem item)
        {
            string spareID = item.SubItems[0].Text;
            
            int quantity = Convert.ToInt32(item.SubItems[1].Text);
            using (Dialog.EditSpareQuantity dlg = new Dialog.EditSpareQuantity(spareID, quantity))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[1].Text = dlg.getQuantity().ToString();
                    item.SubItems[5].Text = dlg.getTotal().ToString();
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
            int orderSpareID;
            foreach (ListViewItem item in lstOrderFrmSpares.Items)
            {
                string spareID = item.SubItems[0].Text;

                int quantityTotal = Convert.ToInt32(item.SubItems[1].Text);

                int pricePerItem = Convert.ToInt32(item.SubItems[2].Text);
                string status = "awaiting";
                string sql = "Insert into orderspare(orderSerial,spareID,quantityTotal,pricePerItem,status) VAlUES(";
                sql += orderSerial + ",'" + spareID + "'," + quantityTotal + "," + pricePerItem + ",'" + status + "'";
                sql += ")";

                orderSpareID = conn.ExecuteInsertQuery(sql);
                int dealerID = Convert.ToInt32(txtOrderFrmDealerID.Text);

                getToFollowSpareQuantity(spareID, dealerID, orderSpareID);
            }
        }
        private void getToFollowSpareQuantity(string spareID,int dealerID,int orderSpareID)
        {
            //require connection opened!
            int quantity = 0;
            string sql;
            LinkedList<int> followOrderIDs = new LinkedList<int>();
            sql = "SELECT tofolloworderspare.followOrderID,orderspare.spareID,tofolloworderspare.quantity,orderlist.dealerID ";
            sql += "FROM tofolloworderspare,orderlist,orderspare ";
            sql += "WHERE tofolloworderspare.orderSpareID = orderspare.orderSpareID ";
            sql += "AND orderspare.orderSerial = orderlist.orderSerial ";
            sql += "AND tofolloworderspare.status = 'awaiting' ";
            sql += "AND orderlist.dealerID = " + dealerID + " ";
            sql += "AND orderspare.spareID = '" + spareID + "'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            if (dt.Rows.Count <= 0)
            {
                return;
            }
            else
            {
                 
                foreach (DataRow row in dt.Rows)
                {
                    followOrderIDs.AddLast(Convert.ToInt32(row[0].ToString()));
                    quantity += Convert.ToInt32(row[2].ToString());
                }
                DialogResult dr = MessageBox.Show(spareID + ":Do you want to add " + quantity + " from the last order(s)?", "ToFollowSpare Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    foreach (int followOrderID in followOrderIDs)
                    {
                        sql = "UPDATE tofolloworderspare ";
                        sql += "SET followBy = " + orderSpareID + ",";
                        sql += "status = 'followed'";
                        sql += "WHERE followOrderID = " + followOrderID;
                        conn.ExecuteUpdateQuery(sql);
                    }

                    sql = "UPDATE orderspare ";
                    sql += "SET quantityTotal = quantityTotal + " + quantity + " ";
                    sql += "WHERE orderSpareID = " + orderSpareID;
                    conn.ExecuteUpdateQuery(sql);
                }
                else
                {
                    return;
                }
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

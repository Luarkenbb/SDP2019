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
    public partial class orderList : UserControl
    {
        DBConnection conn;
        string frmLogonID;
        public orderList()
        {
            InitializeComponent();
        }
        public orderList(string frmLogonID)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
        }

        private void orderList_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getOrderList();
        }
        private void getOrderList()
        {
            string spare;
            conn.OpenConnection();
            string sql = "SELECT orderlist.orderSerial, orderlist.createDateTime, orderlist.dealerID, dealer.name, orderlist.completeDateTime ";
            sql += "FROM orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID";
            DataTable dt = conn.ExecuteSelectQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                spare = getSpareOrder(Convert.ToInt32(row[0].ToString()));

                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                item.SubItems.Add(spare);
                getNonCompletedOrder(item);

                lstOrder.Items.Add(item);
            }
            conn.CloseConnection();
        }
        private void getNonCompletedOrder(ListViewItem item)
        {
            if (item.SubItems[4].Text == "")
            {
                item.SubItems[4].Text = "Not Completed!";
            }
        }
        private string getSpareOrder(int orderSerial)
        {
            //connection required!
            string spare = "";
            string sql = "SELECT spare.description FROM spare, orderspare WHERE orderspare.spareID = spare.SpareID";
            sql += " AND orderspare.orderSerial = " + orderSerial;
            DataTable dt = conn.ExecuteSelectQuery(sql);
            foreach(DataRow row in dt.Rows)
            {
                spare += row[0].ToString();
                if (dt.Rows.IndexOf(row) < dt.Rows.Count-1)
                {
                    spare += ",";
                }
            }

            return spare;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            int orderSerial;
            orderSerial = Convert.ToInt32(lstOrder.SelectedItems[0].SubItems[0].Text);

            using (Dialog.OrderDetail dlg = new Dialog.OrderDetail(orderSerial,frmLogonID))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
    }
}

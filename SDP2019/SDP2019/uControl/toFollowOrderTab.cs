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
    public partial class toFollowOrderTab : UserControl
    {
        DBConnection conn;
        public toFollowOrderTab()
        {
            InitializeComponent();
        }

        private void toFollowOrderTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getAllToFollowOrder();
        }

        private void lstFollowOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getAllToFollowOrder()
        {
            string sql = "";
            sql += "SELECT tofolloworderspare.followOrderID, tofolloworderspare.orderSpareID, orderspare.spareID ,tofolloworderspare.quantity, tofolloworderspare.status, tofolloworderspare.followBy, orderlist.dealerID, dealer.name, tofolloworderspare.createdDate";
            sql += " FROM tofolloworderspare, orderlist, dealer,orderspare";
            sql += " WHERE tofolloworderspare.orderSpareID = orderspare.orderSpareID AND orderspare.orderSerial = orderlist.orderSerial";
            sql += " AND orderlist.dealerID = dealer.dealerID";
            getToFollowOrderList(sql);

        }

        private void getToFollowOrderList(string sql)
        {
            conn.OpenConnection();
            lstFollowOrder.Items.Clear();
            DataTable dt = conn.ExecuteSelectQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstFollowOrder.Items.Add(item);
            }
            conn.CloseConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (Dialog.ToFollowSearch dlg = new Dialog.ToFollowSearch())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    getToFollowOrderList(dlg.getSql());
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllToFollowOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstFollowOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstFollowOrder.SelectedItems[0];
                string followOrderID = item.SubItems[0].Text;
                string status = item.SubItems[4].Text;
                if (status.Equals("awaiting")) {
                    string sql = "DELETE FROM tofolloworderspare WHERE followOrderID = " + followOrderID;
                    conn.OpenConnection();
                    conn.ExecuteUpdateQuery(sql);

                    conn.CloseConnection();
                    getAllToFollowOrder();
                }
                else
                {
                    MessageBox.Show("You can't delete a followed order!");
                }
            }
        }
    }
}

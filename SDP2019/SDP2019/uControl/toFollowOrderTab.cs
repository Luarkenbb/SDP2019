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
    }
}

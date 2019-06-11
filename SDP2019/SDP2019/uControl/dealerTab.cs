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
    public partial class dealerTab : UserControl
    {
        DBConnection conn;
        TabControl tab;
        string frmLogonID;
        int tabNewOrder;
        public dealerTab()
        {
            InitializeComponent();
        }
        public dealerTab(string frmLogonID, int tabNewOrder)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.tabNewOrder = tabNewOrder;
        }
        private void dealerTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            tab = (TabControl)this.Parent.Parent;
            lstDealerGetDealers();
        }
        private void lstDealerGetDealers()
        {
            lstDealer.Items.Clear();
            conn.OpenConnection();
            string sql = "Select * from dealer";
            DataTable dt = conn.ExecuteSelectQuery(sql);

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstDealer.Items.Add(item);
            }

            conn.CloseConnection();
        }

        private void lstDealer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDealerFrmAddToOrder_Click(object sender, EventArgs e)
        {
            newOrderTab distPage;
            object selectPage = tab.TabPages[tabNewOrder].Controls[0];

            distPage = (newOrderTab)selectPage;


            string id;string name;string address;string phone;

            if (lstDealer.SelectedItems.Count == 1)
            {
                ListViewItem item = lstDealer.SelectedItems[0];
                id = item.SubItems[0].Text;
                name = item.SubItems[1].Text;
                address = item.SubItems[2].Text;
                phone = item.SubItems[3].Text;

                distPage.addDealer(id,name,address,phone);
                tab.SelectedIndex = tabNewOrder;
            }
            else
            {
                MessageBox.Show("Please select a dealer!");
            }
        }

       
    }
}

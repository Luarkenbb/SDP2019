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
    public partial class spareTab : UserControl
    {
        DBConnection conn;
        TabControl tab;
        string frmLogonID;
        int tabNewOrder;
        public spareTab()
        {
            InitializeComponent();
        }

        public spareTab(string frmLogonID, int tabNewOrder)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.tabNewOrder = tabNewOrder;
        }

        private void spareTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            tab = (TabControl)this.Parent.Parent;
            lstSpareGetSpares();
        }

        private void lstSpareGetSpares()
        {
            lstSpare.Items.Clear();
            conn.OpenConnection();

            string sql = "Select SpareID, quantity, price, quantitySafeLine, description from spare";
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
        private void lstSpare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSpareFrmAddToOrder_Click(object sender, EventArgs e)
        {
            newOrderTab distPage;
            object selectPage = tab.TabPages[tabNewOrder].Controls[0];          

            distPage = (newOrderTab)selectPage;
            

            if (lstSpare.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstSpare.SelectedItems)
                {
                    ListViewItem clone = (ListViewItem)item.Clone();
                    clone.SubItems[1].Text = "1";
                    clone.SubItems.Add(clone.SubItems[2].Text);
                    distPage.addNewOrderSpare(clone);
                    
                }


                tab.SelectedIndex = tabNewOrder;
;
            }
            else
            {
                MessageBox.Show("Please select spare(s)!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SDP2019
{
    public partial class Main : Form
    {
        DBConnection conn;
        string frmLogonID;
        string frmName;
        string frmUserType;
        string frmDepartmentID;

        int tabNewOrder = 0;
        int tabOrderList = 1;
        int tabToFollow = 2;
        int tabSpare = 3;
        int tabDealer = 4;
        int tabReport = 5;
        int tabSetting = 6;
        //sdaasd
        public Main()
        {
            InitializeComponent();
        }
        public Main(string frmLogonID, string frmName, string frmUserType, string frmDepartmentID)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.frmName = frmName;
            this.frmUserType = frmUserType;
            this.frmDepartmentID = frmDepartmentID;
            userLogon();

            tabGenerate();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            //this.tabTopBar.TabPages.Remove(tabTopBar.TabPages[0]);
            

        }

        private void userLogon()
        {
            txtLogonID.Text = frmLogonID;
        }

        private void tabGenerate()
        {
            tabTopBar.TabPages.Clear();

            Object[,] uControl = {
                {"New Order", new uControl.newOrderTab() },
                {"Order List", new uControl.orderList() },
                {"ToFollow List", new uControl.toFollowOrderTab() },
                {"Spare", new uControl.spareTab(frmLogonID,tabNewOrder) },
                {"Dealer", new uControl.dealerTab() },
                {"Report", new uControl.reportTab() },
                {"Setting", new uControl.settingTab() }
            };

            for (int i = 0; i < uControl.GetLength(0); i++)
            {
                newTab((String)uControl[i, 0], (UserControl)uControl[i, 1], tabTopBar);
            }
        }

        private void newTab(String name, UserControl userControl, TabControl tabControl)
        {
            UserControl tab;
            TabPage newTabPage;

            tab = userControl;
            newTabPage = new TabPage() { Text = name };
            newTabPage.Controls.Add(tab);
            tabControl.TabPages.Add(newTabPage);
        }


        private void tabTopBar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /*

        //dealer tab start
        private void lstDealerGetDealers()
        {
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
            if (lstDealer.SelectedItems.Count == 1)
            {
                ListViewItem item = lstDealer.SelectedItems[0];
                //txtOrderFrmDealerID.Text = item.SubItems[0].Text;
                //txtOrderFrmDealerName.Text = item.SubItems[1].Text;
                //rtxtOrderFrmInvoiceAddress.Text = item.SubItems[2].Text;
                //txtOrderFrmDealerPhone.Text = item.SubItems[3].Text;

                tabTopBar.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please select a dealer!");
            }
        }
        //dealer tab end


        //topBar selected index
        private void tabTopBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = (sender as TabControl).SelectedIndex;
            if (selectedIndex == tabNewOrder)
            {

            }else if (selectedIndex == tabOrderList)
            {

            }
            else if (selectedIndex == tabToFollow)
            {

            }
            else if (selectedIndex == tabSpare)
            {
                lstSpare.Items.Clear();
                lstSpareGetSpares();
            }
            else if (selectedIndex == tabDealer)
            {
                lstDealer.Items.Clear();
                lstDealerGetDealers();
            }
            else if (selectedIndex == tabReport)
            {

            }
            else if (selectedIndex == tabSetting)
            {

            }


        }
        */

    }
}

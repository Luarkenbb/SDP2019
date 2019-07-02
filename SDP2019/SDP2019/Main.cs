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
        int tabReorder = 5;
        int tabReport = 6;
        int tabSetting = 7;

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
                {"New Order", new uControl.newOrderTab(frmLogonID,tabSpare,tabDealer) },
                {"Order List", new uControl.orderList(frmLogonID) },
                {"ToFollow List", new uControl.toFollowOrderTab() },
                {"Spare", new uControl.spareTab(frmLogonID,tabNewOrder,tabReport) },
                {"Dealer", new uControl.dealerTab(frmLogonID,tabNewOrder) },
                {"Reorder", new uControl.ReOrder() },
                {"Report", new uControl.reportTab(frmLogonID,tabSpare) },
                {"Setting", new uControl.settingTab(frmLogonID,frmUserType) }
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


        //確保關閉main會關閉程序
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

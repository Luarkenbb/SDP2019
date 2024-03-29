﻿using System;
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
        public dealerTab(string frmLogonID, int tabNewOrder, string frmUserType)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.tabNewOrder = tabNewOrder;

            permissionHandle(frmUserType);
        }
        private void permissionHandle(string type)
        {
            if (!(type.Equals("staff") | type.Equals("admin")))
            {
                gboxOrder.Hide();
            }
        }

        private void dealerTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            tab = (TabControl)this.Parent.Parent;
            lstDealerGetAllDealers();
        }

        private void lstDealerGetAllDealers()
        {
            string sql = "Select * from dealer";
            lstDealerGetDealers(sql);

        }

        private void lstDealerGetDealers(string sql)
        {
            lstDealer.Items.Clear();
            conn.OpenConnection();
            
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

        private ListViewItem getSelectedDealerID()
        {
            if (lstDealer.SelectedItems.Count == 1)
            {
                ListViewItem item = lstDealer.SelectedItems[0];
                
                return item;
            }
            else
            {
                MessageBox.Show("Please select a dealer!");
                return null;
            }
        }
        


        private void btnDealerFrmAddToOrder_Click(object sender, EventArgs e)
        {
            newOrderTab distPage;
            object selectPage = tab.TabPages[tabNewOrder].Controls[0];

            distPage = (newOrderTab)selectPage;


            string id;string name;string address;string phone;
            if (getSelectedDealerID() != null)
            {
                ListViewItem item = getSelectedDealerID();
                id = item.SubItems[0].Text;
                name = item.SubItems[1].Text;
                address = item.SubItems[2].Text;
                phone = item.SubItems[3].Text;

                distPage.addDealer(id, name, address, phone);
                tab.SelectedIndex = tabNewOrder;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (Dialog.DealerSearchAdd dlg = new Dialog.DealerSearchAdd("search"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string sql = dlg.getSqlSearch();
                    lstDealerGetDealers(sql);

                }
            }
        }

        private void btnNewDealer_Click(object sender, EventArgs e)
        {
            using (Dialog.DealerSearchAdd dlg = new Dialog.DealerSearchAdd("add"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lstDealerGetAllDealers();
                }
            }
        }

        private void btnModDealer_Click(object sender, EventArgs e)
        {
            string id;
            if (getSelectedDealerID() != null)
            {
                ListViewItem item = getSelectedDealerID();
                id = item.SubItems[0].Text;

                using (Dialog.DealerDetail dlg = new Dialog.DealerDetail(id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        lstDealerGetAllDealers();
                    }
                }
            }

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstDealerGetAllDealers();
        }
    }
}

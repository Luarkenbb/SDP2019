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
    public partial class orderList : UserControl
    {
        DBConnection conn;
        string frmLogonID;
        string frmUserType;
        public orderList()
        {
            InitializeComponent();
        }
        public orderList(string frmLogonID)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
        }
        public orderList(string frmLogonID,string frmUserType)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.frmUserType = frmUserType;
        }


        private void orderList_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getAllOrders();
        }
        private void getAllOrders()
        {
            string sql = "SELECT orderlist.orderSerial, orderlist.createDateTime, orderlist.dealerID, dealer.name, orderlist.completeDateTime ";
            sql += "FROM orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID ";
            sql += "ORDER BY orderlist.completeDateTime,orderlist.createDateTime ";
            getOrderList(sql);
        }

        private void getOrderList(string sql)
        {
            string spare;
            conn.OpenConnection();
            
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
            using (Dialog.OrderSearch dlg = new Dialog.OrderSearch())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string sql = dlg.getOrderListSQL();

                    lstOrder.Items.Clear();
                    getOrderList(sql);
                }
            }
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            int orderSerial;
            if (lstOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }

            orderSerial = Convert.ToInt32(lstOrder.SelectedItems[0].SubItems[0].Text);

            Dialog.OrderDetail dlg;
            if (frmUserType == null)
            {
                dlg = new Dialog.OrderDetail(orderSerial, frmLogonID);
            }
            else
            {
                dlg = new Dialog.OrderDetail(orderSerial, frmLogonID,frmUserType);
            }
            using (dlg)
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lstOrder.Items.Clear();
                    getAllOrders();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            getAllOrders();
        }
    }
}

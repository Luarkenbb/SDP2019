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
    public partial class ReOrder : UserControl
    {
        DBConnection conn = new DBConnection();
        public ReOrder()
        {
            InitializeComponent();
        }

        public void ReOrder_Load(object sender, EventArgs e)
        {
            setReorderTable(getReorderTable());
        }

        public DataTable getReorderTable()
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder");
            conn.CloseConnection();
            return rs;
        }

        public DataTable getReorderTable(String sql)
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder where " + sql);
            conn.CloseConnection();
            return rs;
        }

        public void setReorderTable(DataTable rs)
        {
            foreach (DataRow row in rs.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < rs.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewReOrder.Items.Add(item);
            }
        }

        private void Bt_Detail_Click(object sender, EventArgs e)
        {
            new Dialog.ReOrderDetail(int.Parse(listViewReOrder.SelectedItems[0].Text)).ShowDialog();
            waiting_refatsh();
        }

        private void Bt_Status_Click(object sender, EventArgs e)
        {
            new Dialog.ReOrderStatus(listViewReOrder.SelectedItems).ShowDialog();
            waiting_refatsh();
        }

        private void ListViewReOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_Detail.Enabled = bt_Status.Enabled = true;
        }

        private void waiting_refatsh()
        {
            listViewReOrder.Items.Clear();
            setReorderTable(getReorderTable());
            if (listViewReOrder.Items.Count > 0)
            {
                listViewReOrder.Items[0].Selected = true;
                listViewReOrder.Select();
            }
        }

        private void Bt_search_Click(object sender, EventArgs e)
        {
            using (var form = new Dialog.ReOrderSearch())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    listViewReOrder.Items.Clear();
                    setReorderTable(getReorderTable(form.sql));
                    if (listViewReOrder.Items.Count > 0)
                    {
                        listViewReOrder.Items[0].Selected = true;
                        listViewReOrder.Select();
                    }
                }
            }
        }
    }

    
}

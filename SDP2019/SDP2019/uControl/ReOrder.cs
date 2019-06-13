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
    //
    public partial class ReOrder : UserControl
    {
        DBConnection conn;
        public ReOrder()
        {
            InitializeComponent();
        }
        public void ReOrder_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            refatsh(listViewReOrder, getReorderTable());
            refatsh(lstSpare, getCanReOrderList());
        }
        private void Bt_Detail_Click(object sender, EventArgs e)
        {
            if (listViewReOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }
            new Dialog.ReOrderDetail(int.Parse(listViewReOrder.SelectedItems[0].Text)).ShowDialog();
            refatsh(listViewReOrder, getReorderTable());
        }
        private void Bt_Status_Click(object sender, EventArgs e)
        {
            if (listViewReOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }
            new Dialog.ReOrderStatus(listViewReOrder.SelectedItems).ShowDialog();
            refatsh(listViewReOrder, getReorderTable());
        }
        private void Bt_search_Click(object sender, EventArgs e)
        {
            using (var form = new Dialog.ReOrderSearch())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    refatsh(listViewReOrder, getReorderTable(form.sql));
                }
            }
        }
        private void Bt_check_Click(object sender, EventArgs e)
        {
            refatsh(listViewReOrder, getReorderTable());
            refatsh(lstSpare, getCanReOrderList());
        }
        private void Bt_setting_Click(object sender, EventArgs e)
        {
            if (lstSpare.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }
            conn.OpenConnection();
            foreach(ListViewItem row in lstSpare.SelectedItems)
            {
                String sql = "insert into reorder(spareID, quantitySafeLine, status) " +
                   "value('" +
                   lstSpare.SelectedItems[0].Text + "','" +
                   lstSpare.SelectedItems[0].SubItems[2].Text + "','" +
                   lstSpare.SelectedItems[0].SubItems[4].Text + "')";
                conn.ExecuteInsertQuery(sql);
            }
            conn.CloseConnection();
            refatsh(listViewReOrder, getReorderTable());
        }
        private void Bt_delete_Click(object sender, EventArgs e)
        {
            if (listViewReOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }
            conn.OpenConnection();
            String sql = "delete from reorder where ";
            ListViewItem last = listViewReOrder.SelectedItems[listViewReOrder.SelectedItems.Count - 1];
            foreach (ListViewItem row in listViewReOrder.SelectedItems)
            {
                sql += "reOrderID = " + row.Text + "";
                if (!row.Equals(last))
                {
                    sql += " or ";
                }

            }
            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
            refatsh(listViewReOrder, getReorderTable());
        }
        public DataTable getReorderTable()
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder");
            conn.CloseConnection();
            return rs;
        }
        public DataTable getReorderTable(String sqlWhere)
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder where " + sqlWhere);
            conn.CloseConnection();
            return rs;
        }
        public void setReorderTable(ListView listView, DataTable rs)
        {
            foreach (DataRow row in rs.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < rs.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }
        public DataTable getCanReOrderList()
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from spare");
            conn.CloseConnection();

            //add custom column
            rs.Columns["price"].SetOrdinal(3);
            rs.Columns.Add("Status", typeof(String));
            rs.Columns["status"].SetOrdinal(4);
            rs.Columns.Add("qtyofSL", typeof(int));
            rs.Columns["qtyofSL"].SetOrdinal(5);
            rs.Columns["description"].SetOrdinal(6);

            //set level
            foreach (DataRow row in rs.Rows)
            {
                if (int.Parse(row[1].ToString()) <= int.Parse(row[2].ToString()))
                {
                    row[4] = "Danger";
                }
                else if (int.Parse(row[1].ToString()) == 0)
                {
                    row[4] = "Null";
                }
                else
                {
                    row[4] = "normal";
                }
                //count level make sure can order by qty-danger level asc
                row[5] = int.Parse(row[1].ToString()) - int.Parse(row[2].ToString());
            }

            //order by asc
            DataView dataView = rs.DefaultView;
            dataView.Sort = "qtyofSL";
            return dataView.ToTable();
        }
        private void refatsh(ListView listView, DataTable dataTable)
        {
            listView.Items.Clear();
            setReorderTable(listView, dataTable);
        }

        private void Bt_setcalledQty_Click(object sender, EventArgs e)
        {
            if (listViewReOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("You dont have item selected!");
                return;
            }
            new Dialog.ReOrdercalledQTY(listViewReOrder.SelectedItems).ShowDialog();
            refatsh(listViewReOrder, getReorderTable());
        }
    }
}

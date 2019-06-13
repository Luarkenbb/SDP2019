using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP2019.Dialog
{
    public partial class ReOrderStatus : Form
    {
        ListView.SelectedListViewItemCollection selectedListViewItemCollection;
        DBConnection conn = new DBConnection();
        public ReOrderStatus()
        {
            InitializeComponent();
        }

        public ReOrderStatus(ListView.SelectedListViewItemCollection selectedListViewItemCollection)
        {
            InitializeComponent();
            lb_count.Text = "You have " + selectedListViewItemCollection.Count + " item(s) will update";
            this.selectedListViewItemCollection = selectedListViewItemCollection;
        }


        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            Boolean error = false;
            String sql;

            if (cb_status.Text == "Completed")
            {
                foreach (ListViewItem rowchenk in selectedListViewItemCollection)
                {
                    if (rowchenk.SubItems[4].Text == "")
                    {
                        MessageBox.Show("You have some item has't set quantity, Please deselect or set quantity");
                        error = true;
                    }

                }
                if (error != true)
                {
                    foreach (ListViewItem row in selectedListViewItemCollection)
                    {
                        sql = "update spare set quantity=quantity+" + row.SubItems[4].Text + " where spareID='" + row.SubItems[1].Text + "'";
                        conn.ExecuteUpdateQuery(sql);
                    }

                    update(cb_status.Text);
                }
            }
            else if (cb_status.Text == "Ordered")
            {
                update(cb_status.Text);
            }

            conn.CloseConnection();
            Close();
        }

        private void update(String status)
        {
            String sql = "update reorder set status='" + status + "' where ";
            ListViewItem last = selectedListViewItemCollection[selectedListViewItemCollection.Count - 1];
            object a = selectedListViewItemCollection;
            foreach (ListViewItem row in selectedListViewItemCollection)
            {
                sql += "reOrderID = '" + row.Text + "'";
                if (!row.Equals(last))
                {
                    sql += " or ";
                }

            }
            conn.ExecuteUpdateQuery(sql);
        }
    }
}

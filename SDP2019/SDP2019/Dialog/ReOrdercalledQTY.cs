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
    public partial class ReOrdercalledQTY : Form
    {
        ListView.SelectedListViewItemCollection selectedListViewItemCollection;
        DBConnection conn = new DBConnection();
        public ReOrdercalledQTY()
        {
            InitializeComponent();
        }
        public ReOrdercalledQTY(ListView.SelectedListViewItemCollection selectedListViewItemCollection)
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
            String sql = "update reorder set calledQty=" + tb_num.Text + " where ";
            ListViewItem last = selectedListViewItemCollection[selectedListViewItemCollection.Count - 1];
            foreach (ListViewItem row in selectedListViewItemCollection)
            {
                sql += "reOrderID = '" + row.Text + "'";
                if (!row.Equals(last))
                {
                    sql += " or ";
                }

            }
            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
            Close();
        }
    }
}

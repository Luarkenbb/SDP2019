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
    public partial class SpareSelect : Form
    {
        DBConnection conn;
        ListViewItem selectedItem;
        public SpareSelect()
        {
            InitializeComponent();
        }
        private void SpareSelect_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            lstSpareGetSpares();
        }
        public ListViewItem getSelectedItem()
        {
            return this.selectedItem;
        }

        private void btnSpareFrmAddToOrder_Click(object sender, EventArgs e)
        {
            if (lstSpare.SelectedItems.Count > 0)
            {
                    ListViewItem item = lstSpare.SelectedItems[0];
                    ListViewItem clone = (ListViewItem)item.Clone();
                    clone.SubItems[1].Text = "1";
                    

                    selectedItem = clone;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
            }
            else
            {
                MessageBox.Show("Please select spare(s)!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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

        
    }
}

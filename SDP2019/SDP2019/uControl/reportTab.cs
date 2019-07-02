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
    public partial class reportTab : UserControl
    {
        DBConnection conn;



        public reportTab()
        {
            InitializeComponent();
        }



        private void reportTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            lstSpareGetAllSpares();

            lstSelectedSpare.Items.Clear();
        }

        private void lstSpareGetAllSpares()
        {
            string sql = "Select SpareID, quantity, price, quantitySafeLine, description from spare";
            lstSpareGetSpares(sql);
        }

        private void lstSpareGetSpares(string sql)
        {
            lstSpare.Items.Clear();
            conn.OpenConnection();


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

        private void lstSpare_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            ListViewItem clickedItem = senderList.HitTest(e.Location).Item;

            ListViewItem itemAdd = new ListViewItem(clickedItem.SubItems[0].Text);
            if (clickedItem != null)
            {
                itemAdd.SubItems.Add(clickedItem.SubItems[1]);
                itemAdd.SubItems.Add(clickedItem.SubItems[2]);
                itemAdd.SubItems.Add(clickedItem.SubItems[3]);
                itemAdd.SubItems.Add(clickedItem.SubItems[4]);
            }

            lstSelectedSpare.Items.Add(itemAdd);
        }

        private void lstSelectedSpare_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            ListViewItem clickedItem = senderList.HitTest(e.Location).Item;

            
            if (clickedItem != null)
            {
                lstSelectedSpare.Items.Remove(clickedItem);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LinkedList<string> spareIDs = getAllSelectedSpareID();
            Boolean isShowPrevious = cboxPreviousMonth.Checked;
            Boolean isQtyOrSales = rbtnQty.Checked;
            DateTime month = dtPickerMonthReport.Value;

            using (Dialog.ReportChart dlg = new Dialog.ReportChart(spareIDs, isShowPrevious, isQtyOrSales, month))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private LinkedList<string> getAllSelectedSpareID()
        {
            LinkedList<string> list = new LinkedList<string>();

            foreach(ListViewItem item in lstSelectedSpare.Items)
            {
                list.AddLast(item.SubItems[0].Text);
            }


            return list;
        }


    }
}

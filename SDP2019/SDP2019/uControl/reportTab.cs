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
        TabControl tab;
        string frmLogonID;
        int tabSpare;

        public reportTab()
        {
            InitializeComponent();
        }
        public reportTab(string frmLogonID, int tabSpare)
        {
            InitializeComponent();
            this.frmLogonID = frmLogonID;
            this.tabSpare = tabSpare;
        }


        private void reportTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            tab = (TabControl)this.Parent.Parent;
            lstSelectedSpare.Items.Clear();

            
        }

        public void addSpare(ListViewItem item)
        {
            lstSelectedSpare.Items.Add(item);
        }

        private void lstSpare_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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

        private void btnSpareSelect_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = tabSpare;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSelectedSpare.Items.Clear();
        }

       
    }
}

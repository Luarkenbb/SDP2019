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
    public partial class ReOrderSearch : Form
    {

        public string sql { get; set; }
        public ReOrderSearch()
        {
            InitializeComponent();
            cb_status.SelectedIndex = 0;
        }

        private void Bt_search_Click(object sender, EventArgs e)
        {
            if (tb_spareID.Text!="")
            {
                sql += "spareID = '" + tb_spareID.Text + "'";
                if (tb_reorderID.Text != "" || cb_status.SelectedIndex != 0)
                {
                    sql += " and ";
                }

            }
            if (tb_reorderID.Text != "")
            {
                sql += "reOrderID = '" + tb_reorderID.Text + "'";
                if (cb_status.SelectedIndex != 0)
                {
                    sql += " and ";
                }

            }
            if (cb_status.SelectedIndex != 0)
            {
                sql += "status = '" + cb_status.Text + "'";
            }

            if(sql == null)
            {
                MessageBox.Show("Please enter data or select status!");
            } else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

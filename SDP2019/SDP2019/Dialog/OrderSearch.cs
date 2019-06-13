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
    public partial class OrderSearch : Form
    {
        string sql;
        public OrderSearch()
        {
            InitializeComponent();
        }

        private void OrderSearch_Load(object sender, EventArgs e)
        {
            isGroupBoxInformationHide();

            DateTime localDate = dTimeSearchDate.Value;
            string format = "yyyy-MM-dd HH:mm:ss";
            string time = "'" + localDate.ToString(format) + "'";
        }

        private void rbtnInformation_CheckedChanged(object sender, EventArgs e)
        {
            isGroupBoxInformationHide();
        }

        private void rbtnOrderSerial_CheckedChanged(object sender, EventArgs e)
        {
            isGroupBoxInformationHide();
        }
        private void isGroupBoxInformationHide()
        {
            if (rbtnInformation.Checked)
            {
                gbxInformation.Show();
            }
            else
            {
                gbxInformation.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

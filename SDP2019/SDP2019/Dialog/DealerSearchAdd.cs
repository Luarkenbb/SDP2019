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
    public partial class DealerSearchAdd : Form
    {
        DBConnection conn;

        public DealerSearchAdd()
        {
            InitializeComponent();
        }

        public DealerSearchAdd(string type)
        {
            InitializeComponent();
            if (type.Equals("search"))
            {
                btnAdd.Hide();
            }
            else
            {
                btnSearch.Hide();
                txtDealerID.ReadOnly = true;
            }
        }

        private void DealerSearch_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhone.Text, out int n))
            {
                MessageBox.Show("This is not a valid phone!");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhone.Text, out int n) && txtPhone.Text != "")
            {
                MessageBox.Show("This is not a valid phone!");
                return;
            }
        }
    }
}

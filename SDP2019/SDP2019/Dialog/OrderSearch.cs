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
        string orderListSQL;
        public string getOrderListSQL()
        {
            return this.orderListSQL;
        }
        public OrderSearch()
        {
            InitializeComponent();
        }

        private void OrderSearch_Load(object sender, EventArgs e)
        {
            isGroupBoxInformationHide();

            
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
            string sql = "SELECT orderlist.orderSerial, orderlist.createDateTime, orderlist.dealerID, dealer.name, orderlist.completeDateTime ";
            sql += "FROM orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID ";
            
            if (rbtnOrderSerial.Checked)
            {
                sql += "AND orderlist.orderSerial = " + numOrderSerial.Value + " ";
            }
            else
            {
                if (cbxDealer.Checked)
                {
                    sql = AddgbxDealerSQL(sql);
                }
                if (cbxDate.Checked)
                {
                    sql = AddgbxDateSQL(sql);
                }
                if (cbxStatus.Checked)
                {
                    sql = AddgbxStatusSQL(sql);
                }
            }
            sql += "ORDER BY orderlist.completeDateTime,orderlist.createDateTime ";

            orderListSQL = sql;

            MessageBox.Show(sql);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string AddgbxDealerSQL(string sql)
        {
          
            if (rbtnDealerID.Checked)
            {
                sql += "AND orderlist.dealerID = " + Convert.ToInt32(txtDealerID.Text) + " ";
            }
            else
            {
                sql += "AND dealer.name LIKE '%" + txtDealerName.Text + "%' ";
            }
            return sql;
        }
        private string AddgbxDateSQL(string sql)
        {
            DateTime localDate = dTimeSearchDate.Value;
            string format = "yyyy-MM-dd HH:mm:ss";
            string time = "'" + localDate.ToString(format) + "'";

            if (rbtnDateBefore.Checked)
            {
                sql += "AND orderlist.createDateTime < " + time + " ";
            }
            else
            {
                sql += "AND orderlist.createDateTime > " + time + " ";
            }

            return sql;
        }
        private string AddgbxStatusSQL(string sql)
        {
            if (rbtnCompleted.Checked)
            {
                sql += "AND orderlist.completeDateTime IS NOT NULL ";
            }
            else
            {
                sql += "AND orderlist.completeDateTime IS NULL ";
            }
            return sql;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

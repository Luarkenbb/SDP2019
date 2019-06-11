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
    public partial class OrderDetail : Form
    {
        DBConnection conn;
        string frmLogonID;
        int orderSerial;

        public OrderDetail()
        {
            InitializeComponent();
        }
        public OrderDetail(int orderSerial, string frmLogonID)
        {
            InitializeComponent();
            this.orderSerial = orderSerial;
            this.frmLogonID = frmLogonID;
        }


        private void OrderDetail_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getOrderInfo();
        }

        private void getOrderInfo()
        {
            conn.OpenConnection();
            string sql = "SELECT orderlist.orderSerial, orderlist.orderClerkID,orderlist.createDateTime,orderlist.completeDateTime,dealer.dealerID,dealer.name,dealer.phone,orderlist.invoiceAddress,orderlist.deliverAddress,orderlist.storemanID ";
            sql += "from orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID ";
            sql += "AND orderlist.orderSerial = " + orderSerial;

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];

            txtOrderID.Text = orderSerial.ToString();
            txtOrderStaff.Text = row[1].ToString();
            txtStartDate.Text = row[2].ToString();
            txtEndDate.Text = row[3].ToString();
            txtDealerID.Text = row[4].ToString();
            txtDealerName.Text = row[5].ToString();
            txtDealerPhone.Text = row[6].ToString();
            rtxtInvoiceAddress.Text = row[7].ToString();
            rtxtDeliverAddress.Text = row[8].ToString();
            txtStoremanID.Text = row[9].ToString();

            conn.CloseConnection();
        }
    }
}

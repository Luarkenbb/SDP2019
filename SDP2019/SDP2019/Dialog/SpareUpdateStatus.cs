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
    public partial class SpareUpdateStatus : Form
    {
        DBConnection conn;
        string spareID;
        int orderSerial;

        int stockBefore;
        int stockSafeLine;
        int orderQuantity;
        int deliverQuantity;
        int toFollowQuantity;
        int stockAfter;

        public SpareUpdateStatus(string spareID, int orderSerial)
        {
            InitializeComponent();
            this.orderSerial = orderSerial;
            this.spareID = spareID;
        }

        private void SpareUpdateStatus_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            getSpareInfo();
            getOrderSpareInfo();
            setPackagedQuantity();
        }

        private void getSpareInfo()
        {
            txtSpareID.Text = spareID;

            conn.OpenConnection();
            string sql = "SELECT quantity,quantitySafeLine,description FROM spare";
            sql += " WHERE SpareID = '" + spareID + "'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];

            

            txtSpareStockBefore.Text = row[0].ToString();
            stockBefore = Convert.ToInt32(row[0].ToString());

            txtSpareSafeLine.Text = row[1].ToString();
            stockSafeLine = Convert.ToInt32(row[1].ToString());

            txtSpareName.Text = row[2].ToString();

            conn.CloseConnection();
        }

        private void getOrderSpareInfo()
        {
            txtOrderSerial.Text = orderSerial.ToString();

            conn.OpenConnection();
            string sql = "SELECT quantityTotal FROM orderspare";
            sql += " WHERE orderSerial = " + orderSerial + " AND spareID = '" + spareID +"'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];

            txtOrderQuantity.Text = row[0].ToString();
            orderQuantity = Convert.ToInt32(row[0].ToString());

            conn.CloseConnection();
        }

        private void setPackagedQuantity()
        {
            if (stockBefore >= orderQuantity)
            {
                stockAfter = stockBefore - orderQuantity;
                deliverQuantity = orderQuantity;
                toFollowQuantity = 0;
            }
            else
            {
                stockAfter = 0;
                deliverQuantity = stockBefore;
                toFollowQuantity = orderQuantity - stockBefore;
            }

            txtDeliverQuantity.Text = deliverQuantity.ToString();
            txtToFollowQuantity.Text = toFollowQuantity.ToString();
            txtSpareStockAfter.Text = stockAfter.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateOrderSpare();
            updateSpareStock();
            insertToFollowOrderSpare();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void updateOrderSpare()
        {
            if (deliverQuantity > 0)
            {
                conn.OpenConnection();
                string sql = "UPDATE orderspare SET ";
                sql += "toDeliverQuantity = " + deliverQuantity;
                sql += ",status = 'packaged'";

                sql += " WHERE orderSerial = " + orderSerial + " AND spareID = '" + spareID + "'";
                conn.ExecuteUpdateQuery(sql);
                conn.CloseConnection();
            }
        }
        private void updateSpareStock()
        {
            conn.OpenConnection();
            string sql = "UPDATE spare SET ";
            sql += "quantity = " + stockAfter;
            sql += " WHERE SpareID = '" + spareID + "'";
            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();
        }
        private void insertToFollowOrderSpare()
        {
            string sql;

            if (toFollowQuantity > 0)
            {
                DateTime localDate = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                string time = "'" + localDate.ToString(format) + "'";

                conn.OpenConnection();
                sql = "SELECT orderSpareID FROM orderspare ";
                sql += "WHERE orderSerial = " + orderSerial + " AND spareID = '" + spareID +"'";
                DataTable dt = conn.ExecuteSelectQuery(sql);
                DataRow row = dt.Rows[0];
                int orderSpareID = Convert.ToInt32(row[0].ToString());
                sql = "INSERT INTO tofolloworderspare (orderSpareID,quantity,status,createdDate)";
                sql += " VALUES(" + orderSpareID + "," + toFollowQuantity + "," + "'awaiting'" + "," + time + ")";
                conn.ExecuteInsertQuery(sql);


                conn.CloseConnection();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

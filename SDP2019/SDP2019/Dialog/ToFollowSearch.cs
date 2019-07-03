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
    public partial class ToFollowSearch : Form
    {
        private string sql;
        public string getSql()
        {
            return this.sql;
        }

        public ToFollowSearch()
        {
            InitializeComponent();
        }

        private void ToFollowSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getSearchSql();
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void getSearchSql()
        {

            sql = "SELECT tofolloworderspare.followOrderID, tofolloworderspare.orderSpareID, orderspare.spareID ,tofolloworderspare.quantity, tofolloworderspare.status, tofolloworderspare.followBy, orderlist.dealerID, dealer.name, tofolloworderspare.createdDate ";
            sql += "FROM tofolloworderspare, orderlist, dealer, orderspare ";
            sql += "WHERE tofolloworderspare.orderSpareID = orderspare.orderSpareID AND orderspare.orderSerial = orderlist.orderSerial ";
            sql += "AND orderlist.dealerID = dealer.dealerID ";

            Boolean isAddWhere = false;
            string str;
            if (txtFollowID.Text != "" & int.TryParse(txtFollowID.Text, out int i))
            {
                str = "tofolloworderspare.followOrderID = " + txtFollowID.Text + " ";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (txtSpareID.Text != "")
            {
                str = "orderspare.spareID LIKE '%" + txtSpareID.Text + "%' ";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (txtDealerID.Text != "" & int.TryParse(txtDealerID.Text, out int j))
            {
                str = "orderlist.dealerID = " + txtDealerID.Text + " ";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }

            if (txtQuantity.Text != "" & int.TryParse(txtQuantity.Text, out int k))
            {
                if (rbtnMoreThan.Checked)
                {
                    str = "tofolloworderspare.quantity >= " + txtQuantity.Text + " ";
                }
                else
                {
                    str = "tofolloworderspare.quantity <= " + txtQuantity.Text + " ";
                }

                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (cboxStatus.Text != "")
            {
                str = "tofolloworderspare.status = '" + cboxStatus.Text + "' ";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
        }

        private string addWhereAndSQL(string sql, Boolean isAddWhere, string str)
        {
            if (isAddWhere)
            {
                sql += "WHERE " + str + " ";
            }
            else
            {
                sql += "AND " + str + " ";
            }
            return sql;

        }
    }
}

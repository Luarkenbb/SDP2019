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
    public partial class SpareSearch : Form
    {
        string sql;

        public string getSQL()
        {
            return sql;
        }

        public SpareSearch()
        {
            InitializeComponent();
            
        }

        private void SpareSearch_Load(object sender, EventArgs e)
        {

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean isAddWhere = true;
            sql = "Select SpareID, quantity, price, quantitySafeLine, description from spare ";
            string str;
            if (!isNullStr(txtSpareID.Text))
            { 
                str = "SpareID LIKE '%" + txtSpareID.Text + "%'";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (isInt(txtQuantity.Text))
            {
                if (rbtnQuantityBigger.Checked)
                {
                    str = "quantity >= " + Convert.ToInt32(txtQuantity.Text);
                }
                else
                {
                    str = "quantity <= " + Convert.ToInt32(txtQuantity.Text);
                }

                
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (isInt(txtPrice.Text))
            {
                if (rbtnPriceBigger.Checked)
                {
                    str = "price >= " + Convert.ToInt32(txtPrice.Text);
                }
                else
                {
                    str = "price <= " + Convert.ToInt32(txtPrice.Text);
                }

               
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (!isNullStr(rtxtDesc.Text))
            {                
                str = "description LIKE '%" + rtxtDesc.Text + "%'";
                sql = addWhereAndSQL(sql, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private string addWhereAndSQL(string sql,Boolean isAddWhere,string str)
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
        private Boolean isNullStr(string str)
        {
            Boolean isValid = false;
            if (str.Trim() == "")
            {
                return true;
            }
            return isValid;
        }
        private Boolean isInt(string str)
        {
            Boolean isValid = true;
            try{
                Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }
            return isValid;
        }

    }
}

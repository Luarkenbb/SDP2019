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
        string sqlSearch;
        public string getSqlSearch()
        {
            return this.sqlSearch;
        }

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
        /*----*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isCompletedForm())
            {
                MessageBox.Show("This is not a completed Form!");
                return;
            }

            if (!int.TryParse(txtPhone.Text, out int n))
            {
                MessageBox.Show("This is not a valid phone!");
                return;
            }
            conn.OpenConnection();
            string sql = "INSERT INTO dealer(name,address,phone) VALUES('" + txtName.Text + "','" + rtxtAddress.Text + "'," + txtPhone.Text + ")";
            conn.ExecuteUpdateQuery(sql);
            conn.CloseConnection();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private Boolean isCompletedForm()
        {
            Boolean isCompleted = true;

            if (txtName.Text == "" || txtPhone.Text == "" || rtxtAddress.Text == "")
            {
                isCompleted = false;
            }

            return isCompleted;
        }
        /*----*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean isAddWhere = true;
            string str;
            if (!int.TryParse(txtPhone.Text, out int n) && txtPhone.Text != "")
            {
                MessageBox.Show("This is not a valid phone!");
                return;
            }
            if (!int.TryParse(txtDealerID.Text, out int n2) && txtDealerID.Text != "")
            {
                MessageBox.Show("This is not a valid DealerID!");
                return;
            }


            sqlSearch = "Select * from dealer ";
            if (txtName.Text != "")
            {
                str = "name LIKE '%" + txtName.Text + "%'";
                sqlSearch = addWhereAndSQL(sqlSearch, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (txtDealerID.Text != "")
            {
                str = "dealerID = " + txtDealerID.Text;
                sqlSearch = addWhereAndSQL(sqlSearch, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (rtxtAddress.Text != "")
            {
                str = "address LIKE '%" + rtxtAddress.Text + "%'";
                sqlSearch = addWhereAndSQL(sqlSearch, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }
            if (txtPhone.Text != "")
            {
                str = "phone LIKE '%" + txtPhone.Text + "%'";
                sqlSearch = addWhereAndSQL(sqlSearch, isAddWhere, str);
                if (isAddWhere) { isAddWhere = false; }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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

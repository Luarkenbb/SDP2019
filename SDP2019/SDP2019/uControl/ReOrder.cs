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
    public partial class ReOrder : UserControl
    {
        DBConnection conn;
        public ReOrder()
        {
            InitializeComponent();
        }

        public void ReOrder_load(object sender, EventArgs e)
        {
            setReorderTable(getReorderTable());
        }

        public DataTable getReorderTable()
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder");
            conn.CloseConnection();
            return rs;
        }

        public void setReorderTable(DataTable rs)
        {
            foreach (DataRow row in rs.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < rs.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewReOrder.Items.Add(item);
            }
        }

    }

    
}

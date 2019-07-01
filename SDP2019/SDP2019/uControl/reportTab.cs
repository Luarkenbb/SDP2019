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
    public partial class reportTab : UserControl
    {
        DBConnection conn;

        public reportTab()
        {
            InitializeComponent();
        }

        private void reportTab_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            lstSpareGetAllSpares();
        }

        private void lstSpareGetAllSpares()
        {
            string sql = "Select SpareID, quantity, price, quantitySafeLine, description from spare";
            lstSpareGetSpares(sql);
        }

        private void lstSpareGetSpares(string sql)
        {
            lstSpare.Items.Clear();
            conn.OpenConnection();


            DataTable dt = conn.ExecuteSelectQuery(sql);

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstSpare.Items.Add(item);
            }

            conn.CloseConnection();
        }
    }
}

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
    public partial class ReOrderDetail : Form
    {
        DBConnection conn;

        public ReOrderDetail()
        {
            InitializeComponent();
        }

        public ReOrderDetail(int id)
        {
            InitializeComponent();
            conn.OpenConnection();
            DataRow reOrderRS = conn.ExecuteSelectQuery("Select * from reorder Where reOrderID = '" + id + "'").Rows[0];
            DataRow SpareRS = conn.ExecuteSelectQuery("Select * from spare Where spareID = '" + reOrderRS[1].ToString() + "'").Rows[0];

            tb_spareID.Text = SpareRS[0].ToString();
            tb_quantity.Text = SpareRS[1].ToString();
            tb_quantitySL.Text = SpareRS[2].ToString();
            tb_desc.Text = SpareRS[3].ToString();
            tb_reorderID.Text = reOrderRS[0].ToString();
            tb_status.Text = reOrderRS[3].ToString();

            conn.CloseConnection();
        }
    }
}

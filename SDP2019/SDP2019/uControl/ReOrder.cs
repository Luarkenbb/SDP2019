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

        public DataTable getReorderTable()
        {
            conn.OpenConnection();
            DataTable rs = conn.ExecuteSelectQuery("select * from reorder");
            conn.CloseConnection();
            return rs;
        }



    }

    
}

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
    public partial class ReportChart : Form
    {
        LinkedList<string> spareIDs;
        Boolean isShowPrevious;
        Boolean isQtyOrSales;
        int month;

        DataTable valueCurr;
        DataTable valuePrevious;

        public ReportChart()
        {
            InitializeComponent();
        }
        public ReportChart(LinkedList<string> spareIDs, Boolean isShowPrevious, Boolean isQtyOrSales, int month)
        {
            InitializeComponent();

            this.spareIDs = spareIDs;
            this.isShowPrevious = isShowPrevious;
            this.isQtyOrSales = isQtyOrSales;
            this.month = month;
        }

       
        private void ReportChart_Load(object sender, EventArgs e)
        {

        }
    }
}

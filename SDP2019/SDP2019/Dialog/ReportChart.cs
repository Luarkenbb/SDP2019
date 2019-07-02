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
        DateTime date;

        DataTable valueCurr;
        DataTable valuePrevious;
        DBConnection conn;
        

        public ReportChart()
        {
            InitializeComponent();
        }
        public ReportChart(LinkedList<string> spareIDs, Boolean isShowPrevious, Boolean isQtyOrSales, DateTime date)
        {
            InitializeComponent();

            this.spareIDs = spareIDs;
            this.isShowPrevious = isShowPrevious;
            this.isQtyOrSales = isQtyOrSales;
            this.date = date;
        }

       
        private void ReportChart_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            /*var original = chart1.Series.Add("Original");
            var modified = chart1.Series.Add("Modified");
            chart1.Series["Original"].IsValueShownAsLabel = true;
            
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            
            original.Points.AddXY("CPU", 7.6);
            modified.Points.AddXY("CPU", 1.6);
            */
            conn.OpenConnection();
            valueCurr = conn.ExecuteSelectQuery(getSQL(date));
            if (isShowPrevious) {
                valuePrevious = conn.ExecuteSelectQuery(getSQL(new DateTime(date.Year, date.Month, 1).AddMonths(-1)));
            }
            

            conn.CloseConnection();

            printCharts();
        }

        private void printCharts()
        {
            string currMonth = date.ToString("MMMM");
            string previousMonth = new DateTime(date.Year, date.Month, 1).AddMonths(-1).ToString("MMMM");

           
            if (isShowPrevious)
            {
                printChart(previousMonth, valuePrevious);
            }
            printChart(currMonth, valueCurr);
        }

        private void printChart(string colName,DataTable dt)
        {
            
            var currBar = chart1.Series.Add(colName);
            chart1.Series[colName].IsValueShownAsLabel = true;

            

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            DataRow currRow;
            foreach (string spareID in spareIDs)
            {
                currRow = isExistInDataTable(spareID, dt);
                if (currRow != null)
                {
                    int qty = Convert.ToInt32(currRow[1].ToString());
                    int value = Convert.ToInt32(currRow[2].ToString());

                    if (isQtyOrSales) {
                        currBar.Points.AddXY(spareID, qty);
                    }
                    else
                    {
                        currBar.Points.AddXY(spareID, value);
                    }
                }
            }


        }

        private DataRow isExistInDataTable(string spareID, DataTable dt)
        {
            DataRow row;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = dt.Rows[i];
                if (row[0].ToString().Equals(spareID))
                {
                    return row;
                }

            }

            return null;
        }

        private string getSQL(DateTime date)
        {
            DateTime firstDay = new DateTime(date.Year,date.Month,1);
            DateTime lastDate = new DateTime(date.Year,date.Month,1).AddMonths(1).AddDays(-1);

            
            string format = "yyyy-MM-dd HH:mm:ss";
            string strFirstDay = "'" + firstDay.ToString(format) + "'";
            string strlastDate = "'" + lastDate.ToString(format) + "'";

            string sqlSpares = "";
            foreach (string spareID in spareIDs)
            {
                sqlSpares += "'" + spareID + "',";
            }
            sqlSpares = sqlSpares.Remove(sqlSpares.Length - 1, 1);
            string sql = "";
            sql += "SELECT spareID, SUM(orderspare.toDeliverQuantity), SUM(toDeliverQuantity * pricePerItem), MONTH(orderlist.createDateTime) ";
            sql += "FROM orderspare, orderlist ";
            sql += "WHERE orderlist.createDateTime BETWEEN "+ strFirstDay + " AND "+ strlastDate + " ";
            sql += "AND orderspare.status = 'packaged' ";
            sql += "AND orderlist.orderSerial = orderspare.orderSerial ";
            sql += "AND orderspare.spareID in (" + sqlSpares +") ";
            sql += "GROUP BY orderspare.spareID,MONTH(orderlist.createDateTime) ";


            return sql;
        }

    }
}

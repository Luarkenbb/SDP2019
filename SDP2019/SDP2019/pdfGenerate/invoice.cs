using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using System.Data;

namespace SDP2019.pdfGenerate
{
    class Invoice
    {
        int orderSerial;
        string path;
        DBConnection conn;
        string companyAddress , telephone, grams;
        
        string invoiceAddress, deliveryAddress;
        string dateOrder, dateSend;
        string dealerID;

        private Font fontBigBold = FontFactory.GetFont("Arial", 16, Font.BOLD, BaseColor.BLACK);
        private Font fontNormalBold = FontFactory.GetFont("Arial", 13, Font.BOLD, BaseColor.BLACK);
        private Font fontTinyBold = FontFactory.GetFont("Arial", 13, Font.BOLD, BaseColor.BLACK);

        private Font fontBigItalic = FontFactory.GetFont("Arial", 16, Font.ITALIC, BaseColor.GRAY);
        private Font fontTinyItalic = FontFactory.GetFont("Arial", 7, Font.ITALIC, BaseColor.GRAY);

        private Font fontBig = FontFactory.GetFont("Arial", 16, Font.NORMAL,BaseColor.BLACK);
        private Font fontNormal = FontFactory.GetFont("Arial", 13, Font.NORMAL, BaseColor.BLACK);
        private Font fontTiny = FontFactory.GetFont("Arial", 7, Font.NORMAL, BaseColor.BLACK);
        public Invoice()
        {
            this.path = "invoice/test.pdf";
            setDefaultInfomration();
        }
        public Invoice(int orderSerial)
        {
            
            this.orderSerial = orderSerial;
            this.path = "invoice/" + orderSerial + ".pdf";
            setDefaultInfomration();
        }
        public Invoice(int orderSerial , string path)
        {
            
            this.orderSerial = orderSerial;
            this.path = path;

            setDefaultInfomration();
        }

        public void generate()
        {
            getOrderInfo();

            Document document = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            generateLogo(document);
            generateHeaderTable(document);
            generateInvoiceInfoTable(document);
            document.Close();
        }

        private void setDefaultInfomration()
        {
            
            companyAddress = "SMLC District, Tienhou, Guangzhou.";
            telephone = "133 808 12345";
            grams = "SmartLuxuryMC";
            
        }

        private void generateLogo(Document doc)
        {
            var imagepath = "photos/Logo.png";
            using (FileStream fs = new FileStream(imagepath,FileMode.Open))
            {
                var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png );
                png.ScalePercent(70f);
                png.SetAbsolutePosition(doc.Left, doc.Top);
                doc.Add(png);

            }
        }

        private void generateHeaderTable(Document doc)
        {
            var table = new PdfPTable(new[] {.75f,1.5f,.75f,1f})
            {
                WidthPercentage = 75,
                HorizontalAlignment = 0,//0=Left, 1=Centre, 2=Right
                DefaultCell = { MinimumHeight = 22f }
            };

            table.DefaultCell.Border = 0;

            table.AddCell("Address:");
            var addressCell = new PdfPCell(new Phrase(companyAddress))
            {
                Border = 0,
                Colspan = 4,
                HorizontalAlignment = 0,
            };
            table.AddCell(addressCell);


            table.AddCell("Tel:");
            table.AddCell(telephone);
            table.AddCell("Grams");
            table.AddCell(grams);

            doc.Add(table);
            generateSpacing(doc);
        }

        private void generateInvoiceInfoTable(Document doc)
        {
            generateInvoiceAddressTable(doc);
            generateInvoiceDealerTable(doc);
            

            //end for address
           
        }
        private void generateInvoiceAddressTable(Document doc)
        {
            var table = new PdfPTable(new[] { 1f, 1f })
            {
                WidthPercentage = 100,
                HorizontalAlignment = 0,
                DefaultCell = { MinimumHeight = 22f }
            };
            table.DefaultCell.Border = 0;
            table.AddCell(new Paragraph("INVOICE ADDRESS", fontBigBold));
            table.AddCell(new Paragraph("DELIVERY ADDRESS (IF DIFFERENT)", fontBigBold));

            table.AddCell(new Paragraph(invoiceAddress, fontNormal));
            table.AddCell(new Paragraph(deliveryAddress, fontNormal));

            doc.Add(table);
        }
        private void generateInvoiceDealerTable(Document doc)
        {
            var table = new PdfPTable(new[] { 1.25f, 1.25f, .75f, .75f })
            {
                WidthPercentage = 100,
                HorizontalAlignment = 0,
                DefaultCell = { MinimumHeight = 22f }
            };
            table.DefaultCell.Border = 0;

            table.AddCell(new Paragraph("ORDER DATE", fontBigBold));
            table.AddCell(new Paragraph("SEND DATE", fontBigBold));
            table.AddCell(new Paragraph("ORDER SERIAL", fontBigBold));
            table.AddCell(new Paragraph("DEALER CODE", fontBigBold));

            table.AddCell(new Paragraph(dateOrder, fontNormal));
            table.AddCell(new Paragraph(dateSend, fontNormal));
            table.AddCell(new Paragraph(orderSerial.ToString(), fontNormal));
            table.AddCell(new Paragraph(dealerID, fontNormal));
            doc.Add(table);

        }

        private void generateSpacing(Document doc)
        {
            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            doc.Add(spacer);
        }


        //for getting invoice information!

        private void getOrderInfo()
        {
            DBConnection conn = new DBConnection();
            conn.OpenConnection();
            string sql = "SELECT orderlist.orderSerial,orderlist.createDateTime,orderlist.completeDateTime,dealer.dealerID,orderlist.invoiceAddress,orderlist.deliverAddress ";
            sql += "from orderlist, dealer ";
            sql += "WHERE orderlist.dealerID = dealer.dealerID ";
            sql += "AND orderlist.orderSerial = " + orderSerial;

            DataTable dt = conn.ExecuteSelectQuery(sql);
            DataRow row = dt.Rows[0];
            dateOrder = row[1].ToString();
            dateSend = row[2].ToString();
            dealerID = row[3].ToString();
            invoiceAddress = row[4].ToString();
            deliveryAddress = row[5].ToString();

            conn.CloseConnection();

            getSpareInfo(orderSerial);
        }
        private void getSpareInfo(int orderSerial)
        {
            DBConnection conn = new DBConnection();
            conn.OpenConnection();
            string sql = "SELECT orderspare.spareID, orderspare.quantityTotal, orderspare.pricePerItem, spare.quantitySafeLine, spare.quantity, spare.description, orderspare.status,orderspare.toDeliverQuantity FROM orderspare, spare WHERE orderspare.spareID = spare.SpareID AND orderspare.orderSerial = '";
            sql += orderSerial + "'";

            DataTable dt = conn.ExecuteSelectQuery(sql);
            /*foreach (DataRow row in dt.Rows)
            {
               
            }*/


            conn.CloseConnection();
        }
    }
}

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

namespace SDP2019.pdfGenerate
{
    class Invoice
    {
        string orderSerial, path;
        DBConnection conn;
        string companyAddress , telephone, grams;
        public Invoice()
        {
            setDefaultInfomration();
        }

        public Invoice(string orderSerial , string path)
        {
            DBConnection conn = new DBConnection();
            this.orderSerial = orderSerial;
            this.path = path;

            setDefaultInfomration();
        }

        public void generate()
        {
            Document document = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
            PdfWriter.GetInstance(document, new FileStream("invoice/test2.pdf", FileMode.Create));
            document.Open();

            generateLogo(document);
            generateHeaderTable(document);
            
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

        private void generateSpacing(Document doc)
        {
            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            doc.Add(spacer);
        }
    }
}

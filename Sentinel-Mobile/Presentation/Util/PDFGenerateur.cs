using System;

using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using Sentinel_Mobile.Model.DTO;
using System.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using Sentinel_Mobile.Presentation.UIComponents;

namespace Sentinel_Mobile.Presentation.Util
{
    class PDFGenerateur
    {
        public static void genererPdf(PAN_Char_Cam_Vehi [] PansVehicules)
        {
            Document document = new Document(PageSize.A4, 40, 40, 40, 40);
            using (FileStream memStream = new FileStream("./Doc.pdf", FileMode.Append))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, memStream);
                document.Open();
                PdfPTable tableau = new PdfPTable(4);
                //MARQUES
                //using (MemoryStream imgMemStream = new MemoryStream())
                //{
                //    Properties.Resources.marques.Save(imgMemStream, ImageFormat.Bmp);
                //    iTextSharp.text.Image marques = iTextSharp.text.Image.GetInstance(imgMemStream.ToArray());
                //    marques.Alignment = iTextSharp.text.Image.RIGHT_ALIGN;
                //    document.Add(marques);
                //}
                //LOGO
                Chunk logo = new Chunk("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.TIMES_BOLD, "ASCII", true), 20f));
                document.Add(logo);
                Phrase phrase  = new Phrase("");

                //Titre du document
                Phrase titre = new Phrase("", new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.TIMES_BOLD, "ASCII", true), 20f));
                document.Add(titre);
                //Les infos du document
                //Tableau
                tableau.HorizontalAlignment = PdfTable.ALIGN_CENTER;
                tableau.AddCell("Type"); tableau.AddCell("Châssis"); tableau.AddCell("Destination"); tableau.AddCell("Observations");
                foreach (PAN_Char_Cam_Vehi pan in PansVehicules)
                {
                    tableau.AddCell(pan.Modele); tableau.AddCell(pan.Vin); tableau.AddCell("dest"); tableau.AddCell("RAS");
                }
                document.Add(tableau);
                document.Close();

            }
        }

        private static Bitmap genererQR(String manifest)
        {
            return null;
        }
    }
}

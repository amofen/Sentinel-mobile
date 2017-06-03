using System;

using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using Sentinel_Mobile.Model.DTO;
using System.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;

namespace Sentinel_Mobile.Presentation.Util
{
    class PDFGenerateur
    {
        public static void genererPdf(List<ChassisManifestDTO> listVehicules)
        {
            Document document = new Document(PageSize.A4, 40, 40, 40, 40);
            using (FileStream memStream = new FileStream("./manifeste.pdf", FileMode.Create))
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
                Chunk logo = new Chunk("SOVAC\n", new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.TIMES_BOLD, "ASCII", true), 20f));
                document.Add(logo);
                Phrase phrase  = new Phrase("Importateur Officiel\n");

                //Titre du document
                Phrase titre = new Phrase("Bon de transert N°209122", new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.TIMES_BOLD, "ASCII", true), 20f));
                document.Add(titre);
                //Les infos du document
                //Tableau
                tableau.HorizontalAlignment = PdfTable.ALIGN_CENTER;
                tableau.AddCell("Type"); tableau.AddCell("Châssis"); tableau.AddCell("Destination"); tableau.AddCell("Observations");
                tableau.AddCell(" "); tableau.AddCell(" "); tableau.AddCell(" "); tableau.AddCell(" "); tableau.AddCell(" ");


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

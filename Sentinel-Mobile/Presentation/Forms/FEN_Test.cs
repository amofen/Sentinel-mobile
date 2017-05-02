using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data;
using Sentinel_Mobile.Data.DAO;
using System.Threading;
using CodeTitans.JSon;
using System.Diagnostics;
using System.IO;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
using ZXing;
using ZXing.Common;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Imaging;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Cache.DAO.Avaries;


namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Test : Form
    {
        public FEN_Test()
        {
            InitializeComponent();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click_1(object sender, EventArgs e)
        {

        }

        private Bitmap Encode(string text, BarcodeFormat format)
        {
            var writer = new BarcodeWriter { Format = format };
            return writer.Write(text);
        }

        public void generatePdf()
        {
            Document doc = new Document(PageSize.A4, 10, 10, 20, 20);
            using (FileStream mem = new FileStream("./amine2.pdf", FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, mem);
                doc.Open();
                Phrase phrase = new Phrase("phrase");
                doc.Add(phrase);
                var bitmap = Encode("/// The main entry point for the application.", BarcodeFormat.QR_CODE);
                pictureBox1.Image = bitmap;
                MemoryStream stream = new MemoryStream();

                bitmap.Save(stream, ImageFormat.Bmp);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(stream.ToArray());
                doc.Add(img);

                doc.Close();
            }
        }

        private void FEN_Test_Load(object sender, EventArgs e)
        {
            AnomalieDAO dao = new AnomalieDAOImpl();
            List<String> codes = dao.getAnomalies();
            foreach (String str in codes)
            {
                MessageBox.Show(str);
            }
        }

    }
}
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Presentation.UIComponents.Sound;
using System.IO;
using System.Reflection;
using Sentinel_Mobile.Presentation.UIComponents.Barcode;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Positionnement : Form
    {
        public String Vin { get; set; }
        public String Modele { get; set; }
        public String NumLot { get; set; }
        public int NbScans { get; set; }
        public int NumeroPlace { get; set; }
        public Dictionary<String,PlaceRangee> Positionnements { get; set; }
        private BarcodeScanner scanner;

        private PositionnementController locaController;
        public FEN_Positionnement()
        {
            InitializeComponent();
            locaController = new PositionnementController(this);
            locaController.initCbx();
            scanner = new HWBarcodeScanner();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Positionner_Click(object sender, EventArgs e)
        {

        }

        private void Cbx_Zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_Zone.SelectedIndex != 0) locaController.updateCbxPlateforme();
        }

        private void Cbx_Plateforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_Plateforme.SelectedIndex != 0) locaController.updateCbxRange();
        }

        private void Cbx_Range_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_Range.SelectedIndex != 0) locaController.updateNmrcNumPlace();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            SoundManager.PlaySoundSuccess();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            SoundManager.PlaySoundError();
        }

        private void FEN_Positionnement_Load(object sender, EventArgs e)
        {
            //Initialiser le code à barre
            scanner.initialise();
            scanner.activate();
            handleDecodeEvent handler = handleDecodeEventMethode;
            scanner.setScanEventHandler(handler);
        }

        private void handleDecodeEventMethode(object sender, EventArgs e)
        {
            String codeScanne = scanner.getScannResult(e);
            if (codeScanne != null)
            {
                locaController.traiterCodeScanner(codeScanne);
            }

        }

        public void updatePanView()
        {
            pan_info_vehicule.vin = this.Vin;
            pan_info_vehicule.model = this.Modele;
            pan_info_vehicule.updateView();
        }

        public void setScanSuccess()
        {
            this.pan_info_vehicule.setSuccess();
        }

        public void setScanWarnning()
        {
            this.pan_info_vehicule.setWarnning();
        }
        public void setScanEchec()
        {
            this.pan_info_vehicule.setFail();
        }

        public void incNbScansVehicules()
        {
            this.NbScans++;
        }
        public void resetView()
        {
            this.Vin = "-";
            this.Modele = "-";
            this.NumLot = "-";
            this.updatePanView();
        }

    }
}
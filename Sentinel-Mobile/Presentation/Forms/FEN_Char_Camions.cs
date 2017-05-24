using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Presentation.UIComponents.Barcode;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Char_Camions : Form
    {
        private ChargementCamionController chargementCamionController = null;
        public PAN_Char_Cam_Vehi [] pansVehicules  { get; set; }
        public int nbVehiculesCharges { get; set; }
        private BarcodeScanner scanner;

        public FEN_Char_Camions()
        {
            InitializeComponent();
            this.chargementCamionController = new ChargementCamionController(this);
            this.nbVehiculesCharges = 0;
            initListVehicules();
            updateView();
            scanner = new HWBarcodeScanner();
        }

        private void initListVehicules()
        {
            pansVehicules =  new PAN_Char_Cam_Vehi[8];
            pansVehicules[0] = paN_Char_Cam_Vehi1;
            pansVehicules[1] = paN_Char_Cam_Vehi2;
            pansVehicules[2] = paN_Char_Cam_Vehi3;
            pansVehicules[3] = paN_Char_Cam_Vehi4;
            pansVehicules[4] = paN_Char_Cam_Vehi5;
            pansVehicules[5] = paN_Char_Cam_Vehi6;
            pansVehicules[6] = paN_Char_Cam_Vehi7;
            pansVehicules[7] = paN_Char_Cam_Vehi8;
            for (int i = 0; i < 8; i++)
            {
                pansVehicules[i].Ordre = i + 1;
                pansVehicules[i].Hide();
                pansVehicules[i].Vin = null;
                pansVehicules[i].setDeleteHandler(handleDeleteEvent);
                pansVehicules[i].setDeleteBtnTag(i+1);
                pansVehicules[i].updateView();
            }
        }

        public void updateView()
        {
            this.Lbl_VehiculesCharges.Text = nbVehiculesCharges+"";

        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

        }


        private void FEN_Char_Camions_Load(object sender, EventArgs e)
        {
            chargementCamionController.InitialiserChargement();

            //Initialiser le code à barre
            scanner.initialise();
            scanner.activate();
            handleDecodeEvent handler = handleDecodeEventMethode;
            scanner.setScanEventHandler(handler);
        }


        private void Cbx_Transporteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementCamionController.updateCbxCamion();
            chargementCamionController.updateCbxChauffeur();
        }

        private void FEN_Char_Camions_Closing(object sender, CancelEventArgs e)
        {
            scanner.disactivate();
            FEN_Principale fenetre = (FEN_Principale)this.Tag;
            fenetre.Show();
        }

        //L'ordre varie entre 1 et 8
        public void cacherPanel(int ordre)
        {
            pansVehicules[ordre - 1].Hide();
        }




        private void handleDecodeEventMethode(object sender, EventArgs e)
        {
            String codeScanne = scanner.getScannResult(e);
            if (codeScanne != null)
            {
                chargementCamionController.traiterCodeScanne(codeScanne);
            }

        }

        private void handleDeleteEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int order =(int) btn.Tag;
            chargementCamionController.supprimerVehicule(order);
        }



    }
}
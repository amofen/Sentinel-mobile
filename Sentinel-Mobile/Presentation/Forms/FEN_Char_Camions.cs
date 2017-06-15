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
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Char_Camions : Form
    {
        private ChargementCamionController chargementCamionController = null;
        public PAN_Char_Cam_Vehi [] PansVehicules  { get; set; }
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
            initUtilisateur();
        }

        private void initUtilisateur()
        {
            chargementCamionController.initUtilisateur();
        }

        private void initListVehicules()
        {
            PansVehicules =  new PAN_Char_Cam_Vehi[8];
            PansVehicules[0] = paN_Char_Cam_Vehi1;
            PansVehicules[1] = paN_Char_Cam_Vehi2;
            PansVehicules[2] = paN_Char_Cam_Vehi3;
            PansVehicules[3] = paN_Char_Cam_Vehi4;
            PansVehicules[4] = paN_Char_Cam_Vehi5;
            PansVehicules[5] = paN_Char_Cam_Vehi6;
            PansVehicules[6] = paN_Char_Cam_Vehi7;
            PansVehicules[7] = paN_Char_Cam_Vehi8;
            for (int i = 0; i < 8; i++)
            {
                PansVehicules[i].Ordre = i + 1;
                PansVehicules[i].Hide();
                PansVehicules[i].Vin = null;
                PansVehicules[i].setDeleteHandler(handleDeleteEvent);
                PansVehicules[i].setDeleteBtnTag(i+1);
                PansVehicules[i].updateView();
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
            baR_Etat_Perso1.stopTimer();
        }

        //L'ordre varie entre 1 et 8
        public void cacherPanel(int ordre)
        {
            PansVehicules[ordre - 1].Hide();
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

        private void Rbx_plusDest_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbx_plusDest.Checked)
            {
                Cbx_designation.Enabled = false;
                Cbx_destination.Enabled = false;
            }
            else
            {
                Cbx_designation.Enabled = true;
                Cbx_destination.Enabled = true;
            }
        }


        public void setUneSeulDest()
        {
            Rbx_uneDest.Checked = true;
        }

        public void disablePlusDestinations()
        {
            Rbx_plusDest.Enabled = false;
        }

        private void Cbx_destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_destination.SelectedIndex == 0)
            {
                Cbx_designation.Hide();
            }
            else
            {
                chargementCamionController.updateCbxDesignation();
                Cbx_designation.Show();
            }
        }

        public bool isUneSeulDestination()
        {
            return Rbx_uneDest.Checked;
        }

        private void BTN_Valider_Click_1(object sender, EventArgs e)
        {
            PDFGenerateur.genererPdf(PansVehicules);
            //TODO: Enregistrer le camion
        }

        private void BTN_Annuler_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        public void pauseCnxTest()
        {
            this.baR_Etat_Perso1.pauseCnxTest();
        }

        public void reprendreCnxTest()
        {
            this.baR_Etat_Perso1.reprendreCnxTest();
        }
    }
}
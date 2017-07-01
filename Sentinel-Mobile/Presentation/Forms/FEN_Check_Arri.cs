using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CodeTitans.JSon;
using System.Threading;
using Sentinel_Mobile.Controlers;
using Sentinel_Mobile.Presentation.UIComponents.Barcode;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Model.Domain.Vehicules;


namespace Sentinel_Mobile.Presentation.Forms
{
    
    public partial class FEN_Check_Arri : Form
    {
        public String Vin { get; set; }
        public String Modele { get; set; }
        public String NumLot { get; set; }
        public String Port { get; set; }
        public String CodePort { get; set; }
        public String DateArrivage { get; set; }
        public int TotalVehicules{get;set;}
        public int NbScans { get; set; }
        public bool ChassisActif { get; set; }
        public int Etape { get; set; }
        private BarcodeScanner scanner;
        private CheckArrivageController CheckArrController;
        public FEN_Check_Arri()
        {
            InitializeComponent();
            scanner = new HWBarcodeScanner();

        }

        internal void setCheckArrivageController(CheckArrivageController checkController)
        {
            this.CheckArrController = checkController;
        }

        private void CHK_Avarie_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void FEN_Check_Arri_Load(object sender, EventArgs e)
        {
            scanner.initialise();
            scanner.activate();
            handleDecodeEvent handler = handleDecodeEventMethode;
            scanner.setScanEventHandler(handler);
        }


        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void BTN_Declarer_Click(object sender, EventArgs e)
        {
            if (this.ChassisActif)
            {
                using (FEN_DEC_AVA fen = new FEN_DEC_AVA(this.Vin,Vehicule.PORT))
                {
                    if (fen.ShowDialog() == DialogResult.No)
                    {
                        setScanWarnning();
                    }
                    else
                    {
                        setScanSuccess();
                    }
                }
                
            }
        }


        private void FEN_Check_Arri_Closing(object sender, CancelEventArgs e)
        {
            scanner.disactivate();
            FEN_Choix_Arrivage fenetre = (FEN_Choix_Arrivage)this.Tag;
            baR_Etat_Perso1.stopTimer();
            fenetre.reprendreCnxTest();
            fenetre.Show();
        }
        
        private void handleDecodeEventMethode(object sender, EventArgs e)
        {
            String codeScane = scanner.getScannResult(e);
            if (codeScane != null)
            {
                System.Diagnostics.Debug.Write(codeScane);
                CheckArrController.traiterCodeScanner(codeScane);
            }

        }

        public void updatePanView() 
        {
            pan_info_vehicule.vin = this.Vin;
            pan_info_vehicule.numLot = this.NumLot;
            pan_info_vehicule.model = this.Modele;
            pan_info_vehicule.updateView();
        }

        public void updateArrivageView()
        {
            this.Lbl_Date_Arrivage.Text = this.DateArrivage;
            this.Lbl_Port.Text = this.Port;
            this.LBL_Total_Vehi.Text = this.TotalVehicules+"";
            this.LBL_Nb_Scanes.Text = this.NbScans+"";
        }

        public void incNbScansVehicules() 
        { 
            this.NbScans++;
            this.LBL_Nb_Scanes.Text = NbScans + "";
        }

        public void setScanSuccess()
        {
            this.pan_info_vehicule.setSuccess();
            this.ChassisActif = true;
        }

        public void setScanWarnning()
        {
            this.pan_info_vehicule.setWarnning();
            this.ChassisActif = true;
        }

        public void setScanEchec()
        {
            this.pan_info_vehicule.setFail();
            this.ChassisActif = false;
        }

        public void resetView()
        {
            this.Vin = "-";
            this.Modele = "-";
            this.NumLot = "-";
            this.updatePanView();
            this.ChassisActif = false;
        }

        private void pan_info_vehicule_Click(object sender, EventArgs e)
        {
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (MessagingService.confirmation("Voulez vous vraiment confirmer la vérification du lot?") == DialogResult.Yes)
            {
                CheckArrController.validerAnomalies();
            }
        }

        private void bar_etat_Click(object sender, EventArgs e)
        {

        }

        private void FEN_Check_Arri_Closed(object sender, EventArgs e)
        {
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
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


namespace Sentinel_Mobile.Presentation.Forms
{
    
    public partial class FEN_Check_Arri : Form
    {
        public String Vin { get; set; }
        public String Modele { get; set; }
        public String NumLot { get; set; }
        public String Port { get; set; }
        public String DateArrivage { get; set; }
        public int TotalVehicules{get;set;}
        public int NbScans { get; set; }
        public bool ChassisActif { get; set; }
        public int Etape { get; set; }
        private BarcodeScanner scanner;

        CheckArrivageController checkArrController;
        public FEN_Check_Arri()
        {
            InitializeComponent();
            checkArrController = new CheckArrivageController(this);
            scanner = new HWBarcodeScanner();

        }

        private void CHK_Avarie_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void FEN_Check_Arri_Load(object sender, EventArgs e)
        {
            //TODO: init jhandler decode
            scanner.initialise();
            scanner.activate();
            handleDecodeEvent handler = handleDecodeEventMethode;
            scanner.setScanEventHandler(handler);
            initialiserDonnees();
        }


        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            FEN_Principale fenetre = (FEN_Principale)this.Tag;
            fenetre.Show();
            Close();
        }

        private void BTN_Declarer_Click(object sender, EventArgs e)
        {
            if (this.ChassisActif)
            {
                using (FEN_DEC_AVA fen = new FEN_DEC_AVA(this.Vin,this.Etape))
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

        private void initialiserDonnees()
        {
            checkArrController.initDonneesArrivage();
        }

        private void FEN_Check_Arri_Closing(object sender, CancelEventArgs e)
        {
            scanner.disactivate();
            FEN_Principale fenetre = (FEN_Principale)this.Tag;
            fenetre.Show();
        }
        
        private void handleDecodeEventMethode(object sender, EventArgs e)
        {
            String codeScane = scanner.getScannResult(e);
            if (codeScane != null)
            {
                System.Diagnostics.Debug.Write(codeScane);
                checkArrController.traiterCodeScanner(codeScane);
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
     

    }
}
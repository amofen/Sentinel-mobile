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

        CheckArrivageController checkArrController;
        public FEN_Check_Arri()
        {
            InitializeComponent();
            checkArrController = new CheckArrivageController(this);

        }

        private void CHK_Avarie_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void FEN_Check_Arri_Load(object sender, EventArgs e)
        {
            pan_info_vehicule.DEC_Controleur.DecodeEvent += handleDecodeEvent;
            initialiserDonnees();
        }


        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            FEN_Principale fenetre = (FEN_Principale)this.Tag;
            fenetre.Show();
            Dispose();
        }

        private void BTN_Declarer_Click(object sender, EventArgs e)
        {
            if (this.ChassisActif)
            {
                using (FEN_DEC_AVA fen = new FEN_DEC_AVA(this.Vin))
                {
                    fen.ShowDialog();
                }
                
            }
        }

        private void initialiserDonnees()
        {
            checkArrController.initDonneesArrivage();
        }

        private void FEN_Check_Arri_Closing(object sender, CancelEventArgs e)
        {
            FEN_Principale fenetre = (FEN_Principale)this.Tag;
            fenetre.Show();
        }

        private void handleDecodeEvent(object sender, Honeywell.DataCollection.Decoding.DecodeBase.DecodeEventArgs e)
        {
            String codeScane = null;
            if (!e.DecodeResults.pchMessage.Equals("")) codeScane = e.DecodeResults.pchMessage;
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
            setScanSuccess();
        }

        public void setScanSuccess()
        {
            this.pan_info_vehicule.setSuccess();
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
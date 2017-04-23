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
        public String vin { get; set; }
        public String model { get; set; }
        public String numLot { get; set; }
        public String port { get; set; }
        public String dateArrivage { get; set; }
        public int totalVehicules{get;set;}
        public int nbScans { get; set; }
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
                using (FEN_DEC_AVA fen = new FEN_DEC_AVA())
                {

                    fen.ShowDialog();

                }
                
            }
        }

        private void initialiserDonnees()
        {

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
            pan_info_vehicule.vin = this.vin;
            pan_info_vehicule.numLot = this.numLot;
            pan_info_vehicule.model = this.model;
            pan_info_vehicule.updateView();
        }

        public void updateArrivageView()
        {
            this.Lbl_Date_Arrivage.Text = this.dateArrivage;
            this.Lbl_Port.Text = this.port;
            this.LBL_Total_Vehi.Text = this.totalVehicules+"";
        }

        public void incNbScansVehicules() 
        { 
            this.nbScans++;
            this.LBL_Nb_Scanes.Text = nbScans + "";
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
            this.vin = "-";
            this.model = "-";
            this.numLot = "-";
            this.updatePanView();
            this.ChassisActif = false;
        }

        private void pan_info_vehicule_Click(object sender, EventArgs e)
        {

        }


    }
}
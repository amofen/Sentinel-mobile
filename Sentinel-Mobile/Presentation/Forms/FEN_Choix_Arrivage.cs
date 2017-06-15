using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Controlers;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Choix_Arrivage : Form
    {
        private ChoixArrivageController chArriController;
        public FEN_Choix_Arrivage()
        {
            InitializeComponent();
            this.chArriController = new ChoixArrivageController(this);
        }

        private void FEN_Choix_Arrivage_Load(object sender, EventArgs e)
        {
            
            chArriController.initCbxSource();
            chArriController.initCbxArrivage();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Valider_Click_1(object sender, EventArgs e)
        {
            chArriController.choisirLot();

        }

        private void Lst_Lots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            chArriController.initCbxArrivage();
        }

        private void Cbx_Arrivages_SelectedIndexChanged(object sender, EventArgs e)
        {
            chArriController.updateListLots();
        }

        private void BTN_Annuler_Click_1(object sender, EventArgs e)
        {
            FEN_Principale fen = (FEN_Principale)this.Tag;
            fen.Show();
            baR_Etat_Perso1.stopTimer();
            Dispose();
            
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
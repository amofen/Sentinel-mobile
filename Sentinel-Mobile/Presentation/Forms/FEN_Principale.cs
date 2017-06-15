using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Principale : Form
    {
        public FEN_Principale()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click(object sender, EventArgs e)
        {
            FEN_Parametres fen = new FEN_Parametres();
            fen.Tag = this;
            pauseCnxTest();
            fen.Show();
            Hide();
        }

        private void BTN_Positionnement_Click(object sender, EventArgs e)
        {
            FEN_Positionnement fen = new FEN_Positionnement();
            fen.Tag = this;
            fen.Show();
            pauseCnxTest();
            Hide();
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            FEN_Choix_Arrivage fen = new FEN_Choix_Arrivage();
            pauseCnxTest();
            fen.Tag = this;
            fen.Show();
            Hide();
        }

        private void FEN_Principale_Load(object sender, EventArgs e)
        {
           
        }

        private void FEN_Principale_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Chargement_Click(object sender, EventArgs e)
        {
            FEN_Char_Camions fen = new FEN_Char_Camions();
            fen.Tag = this;
            fen.Show();
            pauseCnxTest();
            Hide();
        }

        public void pauseCnxTest()
        {
            this.baR_Etat_Perso1.pauseCnxTest();
        }

        public void reprendreCnxTest()
        {
            this.baR_Etat_Perso1.reprendreCnxTest();
        }

        private void BTN_Notifications_Click(object sender, EventArgs e)
        {
            InitController initCtrl = new InitController();
            initCtrl.initApplicationCache();
        }


    }
}
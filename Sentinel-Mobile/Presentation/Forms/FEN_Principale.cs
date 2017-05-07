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
            Hide();
            fen.Show();
        }

        private void BTN_Positionnement_Click(object sender, EventArgs e)
        {
            FEN_Positionnement fen = new FEN_Positionnement();
            fen.Tag = this;
            fen.Show();
            Hide();
          
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            Hide();
            FEN_Check_Arri fen = new FEN_Check_Arri();
            fen.Tag = this;
            fen.Show();
            
        }

        private void FEN_Principale_Load(object sender, EventArgs e)
        {
            initApplicationCache();
        }

        private void FEN_Principale_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static void initApplicationCache()
        {
            //TODO: Ici je dois initialiser le Cache (Utilisateur,Informations)

            //Initialisation Utilisateur
            Sentinel_Mobile.Data.Config.UtilisateurCache.Type = Utilisateur.AGENT_PORT;
            Sentinel_Mobile.Data.Config.UtilisateurCache.Port = "MOSTA";

            //Initialisation Lots
            if (ConnectionTester.test())
            {
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Lots");
                //initController.initLots();
                SplashManager.CloseSplashScreen();
            }
        }
    }
}
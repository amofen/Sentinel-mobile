using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using iTextSharp.text.pdf;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Controlers;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class APP_MAIN : Form
    {
        public APP_MAIN()
        {
            InitializeComponent();
        }

        private void APP_MAIN_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            initApplicationCache();
            lancerFenetre();
        }

        private void APP_MAIN_Activated(object sender, EventArgs e)
        {

        }

        static void initApplicationCache()
        {
            //TODO: Ici je dois initialiser le Cache (Utilisateur,Informations)

            //Initialisation Utilisateur
            Sentinel_Mobile.Data.Config.UtilisateurCache.Type = Utilisateur.AGENT_PORT;
            Sentinel_Mobile.Data.Config.UtilisateurCache.Port = "MOSTA";

            //Initialisation Lots
            if(ConnectionTester.test()){
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Lots");
                initController.initLots();
                SplashManager.CloseSplashScreen();
            }
        }

        void lancerFenetre()
        {
            //TODO: Selon l'utilisateur et son état, afficher la fenêtre qui correspond

            FEN_Principale fen = new FEN_Principale();
            fen.Tag = this;
            this.Hide();
            fen.Show();
            
        }


    }
}
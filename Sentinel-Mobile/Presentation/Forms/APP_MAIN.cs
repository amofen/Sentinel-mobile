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
            SplashManager.ShowSplashScreen("Chargement");
            initApplicationCache();
            SplashManager.CloseSplashScreen();
            lancerFenetre();
        }

        private void APP_MAIN_Activated(object sender, EventArgs e)
        {

        }

        static void initApplicationCache()
        {
            //TODO: Ici je dois initialiser le Cache (Utilisateur,Informations)
            Sentinel_Mobile.Data.Config.UtilisateurCache.Type = Utilisateur.AGENT_PORT;
            Sentinel_Mobile.Data.Config.UtilisateurCache.PortId = 2;
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
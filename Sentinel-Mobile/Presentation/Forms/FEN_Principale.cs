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
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Data.Cache.DAO.Application;
using Sentinel_Mobile.Model.Domain.Infrastructures;

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

            if (UtilisateurCache.Affectation.Type == PointLivrable.PARC)
            {
                FEN_Positionnement fen = new FEN_Positionnement();
                fen.Tag = this;
                fen.Show();
                pauseCnxTest();
                Hide();
            }
            else
            {
                MessagingService.showInfoMessage("Vous devez être affecter à un parc!");
            }
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            if (UtilisateurCache.Affectation.Type == PointLivrable.PORT)
            {

                FEN_Choix_Arrivage fen = new FEN_Choix_Arrivage();
                pauseCnxTest();
                fen.Tag = this;
                fen.Show();
                Hide();
            }
            else
            {
                MessagingService.showInfoMessage("Vous devez être affecter à un port!");
            }
        }

        private void FEN_Principale_Load(object sender, EventArgs e)
        {
            // InitController initController = new InitController();
            //initController.initUtilisateur(this) ;
            UtilisateurCache.CurrentUserName = "Amine";
            UtilisateurCache.CurrentUserPassword = "abc123";
            UtilisateurCache.Affectation = new PointLivrable() { Code = "PARC-BOUIRA", Type = PointLivrable.PARC, Designation = "Parc Bouira" };
        }

        private void FEN_Principale_Closed(object sender, EventArgs e)
        {
            if (MessagingService.confirmation("Voulez vous vraiment quitter l'application ?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_Chargement_Click(object sender, EventArgs e)
        {
            //FEN_Char_Camions fen = new FEN_Char_Camions();
            FEN_Ordres_Transport fen = new FEN_Ordres_Transport();
            pauseCnxTest();
            fen.Tag = this;
            fen.Show();
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
            //InitController initCtrl = new InitController();
            //initCtrl.initApplicationCache();


        }

        private void imageButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            ParametreDAO dao = new ParametreDAOImpl();
            dao.deleteParametre(UtilisateurCache.Params.NOM_UTILISATEUR);
            dao.deleteParametre(UtilisateurCache.Params.MOT_PASSE_UTILISATEUR);
            dao.deleteParametre(UtilisateurCache.Params.COOKIE_SESSION);
            if (MessagingService.confirmation("Vous aller être décennectés. vous devez relancer l'application. Continuer ?") == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            if (MessagingService.confirmation("Voulez vous mêttre à jour le cache de l'application ?") == DialogResult.Yes)
            {

                InitController init = new InitController();
                init.initApplicationCache();
                MessagingService.showInfoMessage("Données du cache sont mises à jour");
            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            if (MessagingService.confirmation("Voulez vous mêttre à jour les données des arrivages ?") == DialogResult.Yes)
            {

                InitController init = new InitController();
                init.initArrivages();
                MessagingService.showInfoMessage("Données d'arrivages sont mises à jour");
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessagingService.confirmation("Voulez vous mêttre à jour les données des opérations de transport ?") == DialogResult.Yes)
                {

                    ChargementManager charManager = new ChargementManager();
                    charManager.getRemoteOperationReceptionnee(UtilisateurCache.Affectation.Code);
                    MessagingService.showInfoMessage("Les données des opérations de transport sont mises à jour");
                }

            }
            catch (Exception ee)
            {
                MessagingService.showErrorMessage("Une erreur est survenue pendant le chargement des opérations!");
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {

        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            MessagingService.showInfoMessage("SENTINEL MOBILE 0.1a");
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            if (MessagingService.confirmation("Voulez vous vraiment quittez ?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_PDS_Click(object sender, EventArgs e)
        {
            MessagingService.showInfoMessage("La fonctionnalité sera implémantée prochainement").
        }


    }
}
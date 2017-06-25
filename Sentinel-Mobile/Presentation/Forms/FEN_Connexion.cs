using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Connexion : Form
    {
        public String NomUtilisateur { get { return Txt_utilisateur.Text; } }
        public String MotPasse { get { return Txt_mot_passe.Text; } }

        public FEN_Connexion()
        {
            InitializeComponent();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Connexion_Click(object sender, EventArgs e)
        {
            Lbl_msg.Hide();
            if (Cbx_Affectation.SelectedIndex == 0)
            {
                Lbl_msg.Show();
                Lbl_msg.Text = "Veuillez choisir votre affectation";
            }
            else
            {
                ApplicationManager appManager = new ApplicationManager();
                UtilisateurCache.Affectation = (PointLivrable)Cbx_Affectation.SelectedItem;
                AuthentificationManager authManager = new AuthentificationManager();
                if (ConnectionTester.IS_CONNECTED)
                {

                    if (authManager.authentifierUtilisateur(NomUtilisateur, MotPasse))
                    {
                        UtilisateurCache.CurrentUserName = appManager.getParametre(UtilisateurCache.Params.NOM_UTILISATEUR);
                        UtilisateurCache.CurrentUserPassword = appManager.getParametre(UtilisateurCache.Params.MOT_PASSE_UTILISATEUR);
                        UtilisateurCache.CurrentUserCookie = appManager.getParametre(UtilisateurCache.Params.COOKIE_SESSION);
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        Lbl_msg.Text = "Mot de passe ou utilisateur incorrect";
                        Lbl_msg.Show();
                    }
                }
                else
                {
                    if (appManager.getParametre(UtilisateurCache.Params.NOM_UTILISATEUR) != null)
                    {
                        UtilisateurCache.CurrentUserName = appManager.getParametre(UtilisateurCache.Params.NOM_UTILISATEUR);
                        UtilisateurCache.CurrentUserPassword = appManager.getParametre(UtilisateurCache.Params.MOT_PASSE_UTILISATEUR);
                        UtilisateurCache.CurrentUserCookie = appManager.getParametre(UtilisateurCache.Params.COOKIE_SESSION);
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        DialogResult = DialogResult.No;
                    }
                }
            }

        }

        private void FEN_Connexion_Load(object sender, EventArgs e)
        {
            Cbx_Affectation.Items.Clear();
            Cbx_Affectation.Items.Add("<--Votre Affectation-->");
            Cbx_Affectation.SelectedIndex = 0;
            Cbx_Affectation.Items.Add(new PointLivrable() { Code = "PARC-BOUIRA", Designation = "Parc Bouira", Type = PointLivrable.PARC });
            Cbx_Affectation.Items.Add(new PointLivrable() { Code = "PORT-DJEN", Designation = "Port Djen Djen", Type = PointLivrable.PORT });
            Cbx_Affectation.Items.Add(new PointLivrable() { Code = "PORT-MOSTA", Designation = "Port Mostaganem", Type = PointLivrable.PORT });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();

        }


    }
}
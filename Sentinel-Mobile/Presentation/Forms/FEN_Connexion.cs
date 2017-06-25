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

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Connexion : Form
    {
        public String NomUtilisateur { get { return Txt_utilisateur.Text; } }
        public String MotPasse { get {return Txt_mot_passe.Text;}}

        public FEN_Connexion()
        {
            InitializeComponent();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Connexion_Click(object sender, EventArgs e)
        {
            if (Cbx_Affectation.SelectedIndex == 0)
            {
                Lbl_msg.Text = "Veuillez choisir votre affectation";
            }
            else
            {
                UtilisateurCache.Affectation = (PointLivrable)Cbx_Affectation.SelectedItem;
                AuthentificationController ctrl = new AuthentificationController(this);
                ctrl.authentifierUtilisateur();
            }

            
            //TODO: Remettre ça
            //Pour la démonstration
            //FEN_Principale fen = new FEN_Principale();
            //this.Hide();
            //fen.Show();

        }

        private void FEN_Connexion_Load(object sender, EventArgs e)
        {
            Cbx_Affectation.Items.Clear();
            Cbx_Affectation.Items.Add("<--Votre Affectation-->");
            ChargementManager charManager = new ChargementManager();
            List<PointLivrable> listPtLivrables = charManager.getListPointLivreableByType(PointLivrable.PARC);
            listPtLivrables.AddRange(charManager.getListPointLivreableByType(PointLivrable.PORT));
        }


    }
}
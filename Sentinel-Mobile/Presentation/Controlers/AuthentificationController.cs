using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using System.Windows.Forms;
using Sentinel_Mobile.Business;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class AuthentificationController
    {
        private AuthentificationManager authManager=null;
        private FEN_Connexion fenetreConnexion=null;
        public AuthentificationController(FEN_Connexion fen_connexion)
        {
            this.fenetreConnexion = fen_connexion;
            this.authManager = new AuthentificationManager();
        }
        public void lancerAuthentifierUtilisateur()
        {

            using (FEN_Connexion fen = new FEN_Connexion())
            {
                DialogResult result = fen.ShowDialog();
                if (result == DialogResult.Yes)//Authentification Réussie
                {
                    MessageBox.Show("authen");
                }
                else if (result == DialogResult.Ignore)//Authentification local (connexion non disponible)
                {

                }
                else//Authentification échoué
                {
                
                }
            }

        }

        public void authentifierUtilisateur()
        {
            if (fenetreConnexion != null)
            {
                if (authManager.authentifierUtilisateur(fenetreConnexion.NomUtilisateur, fenetreConnexion.MotPasse))
                {
                    fenetreConnexion.DialogResult = DialogResult.Yes;
                }
                else
                {
                    fenetreConnexion.DialogResult = DialogResult.No;
                }

            }
        }
    }
}

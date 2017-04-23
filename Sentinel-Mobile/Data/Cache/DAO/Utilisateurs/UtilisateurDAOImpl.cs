using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Model;
using Sentinel_Mobile.Data;
using System.Data;
using System.Windows.Forms;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Data.Cache.DAO.Utilisateurs
{
    class UtilisateurDAOImpl : UtilisateurDAO
    {
        #region UtilisateurDAO Members

        public Utilisateur getUtilisateur()
        {
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "SELECT * FROM utilisateur";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //MessageBox.Show(reader[0].ToString() + "   " + reader[3].ToString());
            }
            cnx.Close();

            Utilisateur utilisateur = new Utilisateur();
            utilisateur.typeUtilisateur = 1;

            return utilisateur;
        }

        #endregion
    }
}

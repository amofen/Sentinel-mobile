using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Transport;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    class TransporteurDAOImpl : TransporteurDAO
    {

        #region TransporteurDAO Members
        public Camion findCamionById(String id)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM camion WHERE id=@id";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", id);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                Camion camion = null;
                if (reader.Read())
                {
                    camion = new Camion();
                    camion.Id = (String)reader["id"];
                    camion.Transporteur = (String)reader["transporteur"];
                }
                return camion;
            }
        }

        public void addCamion(Camion camion)
        {

        }

        public void setCamionDisponible(bool disponible)
        {

        }

        public List<Camion> getListCamionsByTransporteur(string transporteur)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM camion WHERE transporteur=@transporteur AND disponible = 1";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@transporteur", transporteur);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Camion> camions = new List<Camion>();
                while(reader.Read())
                {
                    Camion camion = new Camion();
                    camion.Id = (String)reader["id"];
                    camion.Transporteur = (String)reader["transporteur"];
                    camions.Add(camion);
                }   
                if (camions.Count > 0) return camions;
                else return null;
            }
        }

        public List<String> getNomsTransporteurs()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  transporteur FROM camion GROUP BY transporteur";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<String> transporteurs = new List<String>();
                while (reader.Read())
                {
                    transporteurs.Add((String)reader["transporteur"]);
                }
                if (transporteurs.Count > 0) return transporteurs;
                else return null;
            }

        }

        public List<Chauffeur> getListChauffeursByTransporteur(string transporteur)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM chauffeur WHERE transporteur=@transporteur AND disponible = 1";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@transporteur", transporteur);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Chauffeur> chauffeurs = new List<Chauffeur>();
                while (reader.Read())
                {
                    Chauffeur chauffeur = new Chauffeur();
                    chauffeur.Id = (String)reader["id"];
                    chauffeur.Nom = (String)reader["nom"];
                    chauffeur.Prenom = (String)reader["prenom"];
                    chauffeurs.Add(chauffeur);
                }
                if (chauffeurs.Count > 0) return chauffeurs;
                else return null;
                //TODO: il faut tester la valeur null à l'appel
            }
        }

        #endregion
    }
}

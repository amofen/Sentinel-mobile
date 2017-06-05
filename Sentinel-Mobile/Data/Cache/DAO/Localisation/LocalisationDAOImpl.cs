using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Data.Cache.DAO.Localisation
{
    class LocalisationDAOImpl:LocalisationDAO
    {
        #region LocalisationDAO Members

        public List<Zone> getZonesBySite(string codePtLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Zone";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                //cmd.Parameters.AddWithValue("@codePtLivrable", codePtLivrable);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Zone> ListZones = new List<Zone>();
                while (reader.Read())
                {
                    Zone zone = new Zone();
                    zone.NbMaxPlateformes = (int)reader["nbmaxplateformes"];
                    zone.Libre = Convert.ToInt32(reader["libre"])==1;
                    zone.Nom = (String)reader["nom"];
                    zone.CodePointLivrable = (String)reader["codePtLivrable"];
                    ListZones.Add(zone);
                }
                if (ListZones.Count > 0) return ListZones;
                else return null;
            }
        }

        public List<Plateforme> getPlateformesByZone(string zone)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Plateforme WHERE nomZone=@nomZone";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@nomZone", zone);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Plateforme> listePlateforme = new List<Plateforme>();
                while (reader.Read())
                {
                    Plateforme plateforme = new Plateforme();
                    plateforme.Nom = (String)reader["nom"];
                    plateforme.NomZone = zone;
                    plateforme.Ranges = null;
                    plateforme.NbMaxRanges = Convert.ToInt32(reader["nbMaxRanges"]);
                    listePlateforme.Add(plateforme);
                }
                if (listePlateforme.Count > 0) return listePlateforme;
                else return null;
            }
        }

        public List<Range> getRangesByZonePlateforme(string zone,string plateforme)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Range WHERE nomZone=@nomZone AND nomPlateforme=@nomPlateforme";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@nomZone", zone);
                cmd.Parameters.AddWithValue("@nomPlateforme", plateforme);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Range> listeRanges = new List<Range>();
                while (reader.Read())
                {
                    Range range = new Range();
                    range.Nom = (String)reader["nom"];
                    range.NomPlateforme = plateforme;
                    range.NomZone = zone;
                    range.NbMaxPlaces = Convert.ToInt32(reader["nbMaxPlaces"]);
                    listeRanges.Add(range);
                }
                if (listeRanges.Count > 0) return listeRanges;
                else return null;
            }
        }

        #endregion
    }
}

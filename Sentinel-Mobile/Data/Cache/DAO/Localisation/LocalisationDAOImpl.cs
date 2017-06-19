using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Data.Cache.DAO.Localisation
{
    class LocalisationDAOImpl:LocalisationDAO
    {
        #region LocalisationDAO Members

        public List<Zone> getZonesByParc(string codePtLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Zone where codeparc=@codeparc";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@codeParc", codePtLivrable);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Zone> ListZones = new List<Zone>();
                while (reader.Read())
                {
                    Zone zone = new Zone();
                    zone.Code = (String)reader["code"];
                    zone.NbrMaxPlateformes = (int)reader["nbrMaxPlateformes"];
                    zone.Libre = Convert.ToInt32(reader["libre"])==1;
                    zone.Nom = (String)reader["nom"];
                    zone.CodeParc = codePtLivrable;
                    ListZones.Add(zone);
                }
                if (ListZones.Count > 0) return ListZones;
                else return null;
            }
        }

        public List<Plateforme> getPlateformesByZone(string codeZone)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Plateforme WHERE codeZone=@codeZone";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                cmd.Parameters.AddWithValue("@codeZone", codeZone);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Plateforme> listePlateforme = new List<Plateforme>();
                while (reader.Read())
                {
                    Plateforme plateforme = new Plateforme();
                    plateforme.Code = (String)reader["code"];
                    plateforme.CodeZone = codeZone;
                    plateforme.NbrMaxRangees = Convert.ToInt32(reader["nbrMaxRanges"]);
                    listePlateforme.Add(plateforme);
                }
                if (listePlateforme.Count > 0) return listePlateforme;
                else return null;
            }
        }

        public List<Range> getRangesByZonePlateforme(string codeZone,string codePlateforme)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Range WHERE codeZone=@codeZone AND codePlateforme=@codePlateforme";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@codeZone", codeZone);
                cmd.Parameters.AddWithValue("@codePlateforme", codePlateforme);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Range> listeRanges = new List<Range>();
                while (reader.Read())
                {
                    Range range = new Range();
                    range.Code = (String)reader["code"];
                    range.CodePlateforme = codePlateforme;
                    range.CodeZone = codeZone;
                    range.NbrMaxPlaces = Convert.ToInt32(reader["nbrMaxPlaces"]);
                    listeRanges.Add(range);
                }
                if (listeRanges.Count > 0) return listeRanges;
                else return null;
            }
        }

        public void sauvegarderZone(Zone zone)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO zone (code,codeparc,nom,libre,nbrMaxPlateformes)" +
                                    "VALUES (@code,@codeparc,@nom,@libre,@nbrMaxPlateformes)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", zone.Code);
                cmd.Parameters.AddWithValue("@codeparc", zone.CodeParc);
                cmd.Parameters.AddWithValue("@nom", zone.Nom);
                cmd.Parameters.AddWithValue("@libre", zone.Libre);
                cmd.Parameters.AddWithValue("@nbrMaxPlateformes", zone.NbrMaxPlateformes);
                
                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                foreach (Plateforme plateforme in zone.Plateformes)
                {
                    sauvegarderPlateforme(plateforme, cnx);
                    foreach (Range range in plateforme.Rangees)
                    {
                        sauvegarderRangee(range, cnx);
                    }
                }
                
            }

        }

        public void sauvegarderPlateforme(Plateforme plateforme, SqlCeConnection cnx)
        {
                string requete = "INSERT INTO plateforme (code,codezone,nbrMaxRanges)" +
                                    "VALUES (@code,@codezone,@nbrMaxRanges)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", plateforme.Code);
                cmd.Parameters.AddWithValue("@codezone", plateforme.CodeZone);
                cmd.Parameters.AddWithValue("@nbrMaxRanges", plateforme.NbrMaxRangees);
               //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();

        }

        public void sauvegarderRangee(Range range, SqlCeConnection cnx)
        {
                string requete = "INSERT INTO range (code,codezone,codeplateforme,nbrMaxplaces)" +
                                    "VALUES (@code,@codezone,@codeplateforme,@nbrMaxplaces)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", range.Code);
                cmd.Parameters.AddWithValue("@codezone", range.CodeZone);
                cmd.Parameters.AddWithValue("@codeplateforme",range.CodePlateforme);
                cmd.Parameters.AddWithValue("@nbrMaxplaces", range.NbrMaxPlaces);

                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();

        }

        public void enregistrerPositionnement(Positionnement positionnement,int synchronisation)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Positionnement (vin,codeparc,codezone,codeplateforme,codeRangee,numeroDsRangee,datepositionnement,synchronise,valide)" +
                                    "VALUES (@vin,@codeparc,@codezone,@codeplateforme,@codeRangee,@numeroDsRangee,@datepositionnement,@synchronise,@valide)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", positionnement.Veicule.Vin);
                cmd.Parameters.AddWithValue("@codeparc", positionnement.CodeParc);
                cmd.Parameters.AddWithValue("@codezone", positionnement.Zone);
                cmd.Parameters.AddWithValue("@codeplateforme", positionnement.Plateforme);
                cmd.Parameters.AddWithValue("@codeRangee", positionnement.Rangee);
                cmd.Parameters.AddWithValue("@numeroDsRangee", positionnement.NumeroDsRangee);
                cmd.Parameters.AddWithValue("@datepositionnement", positionnement.date);
                cmd.Parameters.AddWithValue("@synchronise", synchronisation);
                cmd.Parameters.AddWithValue("@valide", 1);

                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Positionnement> getPositionnementsByEtatSync(int etat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Positionnement WHERE synchronise=@synchronise";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                cmd.Parameters.AddWithValue("@synchronise", etat);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Positionnement> listPositionnement = new List<Positionnement>();
                while (reader.Read())
                {
                    Positionnement positionnement = new Positionnement();
                    positionnement.Veicule = new Vehicule() { Vin = (String)reader["vin"] };
                    positionnement.CodeParc = (String)reader["codeparc"];
                    positionnement.Zone = (String)reader["codezone"];
                    positionnement.Plateforme = (String)reader["codeplateforme"];
                    positionnement.Rangee = (String)reader["coderangee"];
                    positionnement.NumeroDsRangee = Convert.ToInt32 (reader["numerodsrangee"]);
                    positionnement.date = (DateTime)reader["datepositionnement"];
                    listPositionnement.Add(positionnement);
                }
                if (listPositionnement.Count > 0) return listPositionnement;
                else return null;
            }
        }

        public void setPositionnementEtatSynchonise(String vin,int etat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "DELETE FROM  Positionnement WHERE vin = @vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@synchronise", etat);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}

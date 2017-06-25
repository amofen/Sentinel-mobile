using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.Synchronisation;

namespace Sentinel_Mobile.Data.DAO.Cache.Vehicules
{
    class VehiculeDAOImpl : VehiculeDAO
    {

        public Vehicule getVehiculeByVin(String vin) 
        {
                using (SqlCeConnection cnx = DBConnexionManager.connect())
                {
                    string requete = "SELECT * FROM vehicule WHERE vin=@vin";
                    SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                    SqlCeParameter parametre = new SqlCeParameter("@vin", vin);

                    cmd.Parameters.Add(parametre);
                    cmd.Prepare();
                    SqlCeDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    Vehicule vehicule = new Vehicule();
                    vehicule.Vin = (String)reader["vin"];
                    vehicule.Model = (String)reader["model"];
                    vehicule.Couleur = (String)reader["couleur"];
                    vehicule.Lot = (String)reader["lot"];
                    return vehicule;
                }
        }

        public int sauvegarderVehicule(Vehicule vehicule)
        {
            //Création de la connexion
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Vehicule (vin,model,couleur,lot) VALUES (@vin,@model,@couleur,@lot)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vehicule.Vin);
                cmd.Parameters.AddWithValue("@model", vehicule.Model);
                cmd.Parameters.AddWithValue("@couleur", vehicule.Couleur);
                cmd.Parameters.AddWithValue("@lot", vehicule.Lot);

                //Préparation de la requête
                cmd.Prepare();
                return cmd.ExecuteNonQuery();
            }
            //Return 1 si la requête a réussi
            

        }

        public List<Vehicule> getVehiculesByLotId(string id)
        {
            List<Vehicule> listVehicule = new List<Vehicule>();
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Vehicule WHERE lot=@lot";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@lot", id);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vehicule vehicule = new Vehicule();
                    vehicule.Vin = (String)reader["vin"];
                    vehicule.Lot = (String) reader["lot"];
                    vehicule.Model = (String)reader["model"];
                    vehicule.Couleur = (String)reader["couleur"];
                    listVehicule.Add(vehicule);
                }
            }
            if (listVehicule.Count > 0) return listVehicule;
            else return null;
        }

        public int getNombreVehiculeByNumLot(string numLot)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(*) FROM Vehicule WHERE lot=@lot";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@lot",numLot);

                //Préparation de la requête
                cmd.Prepare();
                return (int) cmd.ExecuteScalar();
            }            
        }



        public void scannerVehicule(String vin,int etape,String codePtLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO ScanArrivage (vin,datescanne,etape,codePtLivrable,synchronisee) VALUES (@vin,@date,@etape,@codePtLivrable,@synchronisee)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@synchronisee", SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                cmd.Parameters.AddWithValue("@etape", etape);
                cmd.Parameters.AddWithValue("@codePtLivrable", codePtLivrable);
                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public bool vehiculeScanne(String vin,int etape)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(*) FROM ScanArrivage where vin=@vin and etape=@etape ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@etape", etape);
                cmd.Prepare();
                if ((int)cmd.ExecuteScalar() == 0) return false;
                else return true;
            }
        }


        public int getNbVehiculesScannesPort()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(vin) AS nbvehicules FROM scanarrivage where etape=@etape";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@etape", Vehicule.PORT);
                int nbVehicules = (int)cmd.ExecuteScalar();
                return nbVehicules;
            }
        }


        #region VehiculeDAO Members


        public List<Scan> getScansByEtatSync(int syncEtat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                List<Scan> listScans = new List<Scan>();
                string requete = "SELECT * FROM ScanArrivage WHERE synchronisee=@synchronisee";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@synchronisee", syncEtat);
                cmd.Prepare();

                SqlCeDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Scan scan = new Scan();
                    scan.Vin = (String)reader["vin"];
                    scan.Date = (DateTime)reader["datescanne"];
                    scan.CodePtLivrable = (String)reader["codePtLivrable"];
                    scan.Etape = Convert.ToInt32(reader["etape"]);
                    listScans.Add(scan);
                }
                if (listScans.Count > 0) return listScans;
                else return null;
            }
        }


        public void setVehiculeScanEtat(string vin, int syncEtat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE ScanArrivage SET synchronisee=@synchronisee WHERE vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@synchronisee", syncEtat);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public bool setVehiculeScanEtapeEtat(string vin, int p, string pointLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE ScanArrivage SET synchronisee=0,datescanne=@date,etape=@etape,codePtLivrable=@codePtLivrable WHERE vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@etape", p);
                cmd.Parameters.AddWithValue("@codePtLivrable", pointLivrable);

                
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        #endregion
    }
}

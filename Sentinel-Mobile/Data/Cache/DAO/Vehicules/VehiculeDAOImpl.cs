using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Util;

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
                    vehicule.Annee = (String)reader["annee"];
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
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "INSERT INTO vehicule (vin,model,annee,couleur,lot) VALUES (@vin,@model,@annee,@couleur,@lot)";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

            //Préparation des paramètres
            cmd.Parameters.AddWithValue("@vin", vehicule.Vin);
            cmd.Parameters.AddWithValue("@model", vehicule.Model);
            cmd.Parameters.AddWithValue("@annee", vehicule.Annee);
            cmd.Parameters.AddWithValue("@couleur", vehicule.Couleur);
            cmd.Parameters.AddWithValue("@lot", vehicule.Lot);

            //Préparation de la requête
            cmd.Prepare();

            //Return 1 si la requête a réussi
            return cmd.ExecuteNonQuery();

        }

        public List<Vehicule> getVehiculesByLotId(string id)
        {
            return null;
        }
    }
}

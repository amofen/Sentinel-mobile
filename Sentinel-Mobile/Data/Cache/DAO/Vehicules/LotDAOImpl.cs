using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;

namespace Sentinel_Mobile.Data.Cache.DAO.Vehicules
{
    class LotDAOImpl:LotDAO
    {
        public void sauvegarderLot(Lot lot)
        {
            //Création de la connexion
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Lot (Id,DatePrevueArrive) VALUES (@Id,@DatePrevueArrive)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@Id", lot.Id);
                cmd.Parameters.AddWithValue("@DatePrevueArrive", lot.DatePrevueArrive);

                //Préparation de la requête
                cmd.Prepare();

                //Return 1 si la requête a réussi
                if (cmd.ExecuteNonQuery() > 0)
                {
                    VehiculeDAO vehiculeDAO = new VehiculeDAOImpl();
                    foreach (Vehicule vehicle in lot.vehicules)
                    {
                        vehiculeDAO.sauvegarderVehicule(vehicle);
                    }

                }
            }
   
        }





        public List<Lot> getCacheLots()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM Lot";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Lot> lots = new List<Lot>();
                while (reader.Read())
                {
                    Lot lot = new Lot();
                    lot.Id = (String)reader["id"];
                     lot.DatePrevueArrive = (DateTime)reader["DatePrevueArrive"];
                    
                    lots.Add(lot);
                }
                return lots;
            }
        }
    }
}

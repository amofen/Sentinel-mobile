using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
using Sentinel_Mobile.Data.Cache.DAO.Transport;

namespace Sentinel_Mobile.Data.Cache.DAO.Vehicules
{
    class LotDAOImpl:LotDAO
    {
        public void sauvegarderLot(Lot lot)
        {
            //Création de la connexion
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Lot (Id,CodeArrivage) VALUES (@Id,@CodeArrivage)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@Id", lot.Id);
                cmd.Parameters.AddWithValue("@CodeArrivage", lot.CodeArrivage);

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
                    lots.Add(lot);
                }
                return lots;
            }
        }

        public List<Lot> getLotsByArrivageCode(long code)
        {
            List<Lot> listLot = new List<Lot>();
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Lot WHERE codeArrivage=@codeArrivage";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@codeArrivage", code);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Lot lot = new Lot();
                    lot.CodeArrivage = code;
                    lot.Id = (String)reader["id"];
                    lot.CodeArrivage = Convert.ToInt64(reader["codeArrivage"]);
                    listLot.Add(lot);
                }

            }
            foreach (Lot lot in listLot)
            {
                VehiculeDAO vehiDao = new VehiculeDAOImpl();
                lot.vehicules = vehiDao.getVehiculesByLotId(lot.Id);
            }
            if (listLot.Count > 0) return listLot;
            else return null;
        }

        public void sauvegarderArrivage(Arrivage arrivage)
        {
            //Création de la connexion
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Arrivage (Code,DatePrevue,Source) VALUES (@Code,@DatePrevue,@Source)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@Code", arrivage.Code);
                cmd.Parameters.AddWithValue("@DatePrevue", arrivage.Date);
                cmd.Parameters.AddWithValue("@Source", arrivage.Source.Code);
                
                //Préparation de la requête
                cmd.Prepare();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    foreach (Lot lot in arrivage.lots)
                    {
                        sauvegarderLot(lot);
                    }

                }
            }
        }
        public  List<Arrivage> getArrivageByPtLivrableCode(String code)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                List<Arrivage> listArrivage = new List<Arrivage>();
                string requete = "SELECT * FROM Arrivage WHERE source=@source";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@source", code);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Arrivage arrivage = new Arrivage();
                    arrivage.Code = Convert.ToInt64(reader["Code"]);
                    arrivage.Source = null;
                    arrivage.Date = (DateTime)reader["datePrevue"];
                    arrivage.lots = null;
                    listArrivage.Add(arrivage);
                }
                foreach (Arrivage arrivage in listArrivage)
                {
                    ChargementDAO chrDao = new ChargementDAOImpl();
                    arrivage.Source = chrDao.getListPointLivrableById(code);

                    LotDAO lotDao = new LotDAOImpl();
                    arrivage.lots = lotDao.getLotsByArrivageCode(arrivage.Code);
                }
                if (listArrivage.Count > 0) return listArrivage;
                else return null;
            }
        }

        
    }
}

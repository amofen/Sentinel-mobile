using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Data.Cache.DAO.Vehicules
{
    class LotDAOImpl:LotDAO
    {
        public int sauvegarderLot(Lot lot)
        {
            //Création de la connexion
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "INSERT INTO lot (Id,DatePrevueArrive,DateReelleArrive) VALUES (@Id,@DatePrevueArrive,@DateReelleArrive)";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

            //Préparation des paramètres
            cmd.Parameters.AddWithValue("@Id", lot.Id);
            cmd.Parameters.AddWithValue("@DatePrevueArrive", lot.DatePrevueArrive);
            cmd.Parameters.AddWithValue("@DateReelleArrive", lot.DateReelleArrive);

            //Préparation de la requête
            cmd.Prepare();

            //Return 1 si la requête a réussi
            return cmd.ExecuteNonQuery();
        }

    }
}

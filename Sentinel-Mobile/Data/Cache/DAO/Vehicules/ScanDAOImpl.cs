using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Data.DAO.Cache.Vehicules
{
    class ScanDAOImpl:ScanDAO
    {

        #region ScanDAO Members

        public int vehiculeScanne(string vin)
        {
           
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "SELECT COUNT(vin) FROM scanarrivage WHERE vin=@vin";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
            cmd.Parameters.AddWithValue("@vin", vin);
            int i = (int)cmd.ExecuteScalar();
            cnx.Close();
            return i;
            
        }


        public int scannerVehicule(String vin)
        {
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "INSERT INTO  scanarrivage (vin,date) VALUES (@vin,@date)";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
            cmd.Parameters.AddWithValue("@vin",vin);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            return cmd.ExecuteNonQuery();
        }

        public int getNbVehiculesScannes()
        {
            SqlCeConnection cnx = DBConnexionManager.connect();
            string requete = "SELECT COUNT(vin) AS nbvehicules FROM scanarrivage";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
            int nbVehicules = (int)cmd.ExecuteScalar();
            return nbVehicules;
        }

        #endregion
    }
}

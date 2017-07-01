using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Data.Cache.DAO.Application
{
    class ParametreDAOImpl : ParametreDAO
    {

        #region ParametresDAO Members

        public void setParametre(string nomParam, string valParam)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                try
                {
                    deleteParametre(nomParam, cnx);
                }
                catch { }
                string requete = "INSERT INTO Parametres (nomParam,valeurParam) VALUES (@nomParam,@valeurParam)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@nomParam", nomParam);
                cmd.Parameters.AddWithValue("@valeurParam", valParam);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public String getValeurParametre(string nomParam)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM Parametres WHERE nomParam = @nomParam";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@nomParam", nomParam);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return (String)reader["valeurParam"];
                else return null;
            }
        }

        public void deleteParametre(string nomParam)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "DELETE FROM Parametres WHERE nomParam = @nomParam";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@nomParam", nomParam);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteParametre(string nomParam, SqlCeConnection cnx)
        {
            string requete = "DELETE FROM Parametres WHERE nomParam = @nomParam";
            SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
            cmd.Parameters.AddWithValue("@nomParam", nomParam);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void deleteCache()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "DELETE Anomalie";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Arrivage";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Camion";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Chauffeur";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE DeclarationAnomalie";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE DestinationVehicule";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Lot";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Operation";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE OperationReceptionnee";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Plateforme";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE PointLivrable";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Positionnement";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Range";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE ScanArrivage";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Vehicule";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();

                requete = "DELETE Zone";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();

                requete = "DELETE VehiculeReceptionne";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();



            }
        }

        public void viderScanArrivage()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "DELETE ScanArrivage";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
            }
        }

        public void viderOperationTransport()
        {

            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "DELETE OperationReceptionnee";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE Operation";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
                requete = "DELETE DestinationVehicule";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();

                requete = "DELETE VehiculeReceptionne";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
            }
        }

        public void viderDeclarationAnomalies()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "DELETE DeclarationAnomalie";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.ExecuteNonQuery();
          
            }
        }
        #endregion
    }
}

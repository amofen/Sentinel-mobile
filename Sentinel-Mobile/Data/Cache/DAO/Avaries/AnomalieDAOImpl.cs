using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Avaries;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    class AnomalieDAOImpl:AnomalieDAO
    {
        #region AnomalieDAO Members

        public void sauvegarderAnomalie(Anomalie anomalie)
        {
            
        }

        void AnomalieDAO.sauvegarderAnomalie(Anomalie anomalie)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Anomalie (code,designation,typeanomalie) VALUES (@code,@designation,@typeanomalie)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@code",anomalie.Id);
                cmd.Parameters.AddWithValue("@designation", anomalie.Designation);
                cmd.Parameters.AddWithValue("@typeanomalie",anomalie.Type);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public List<String> getAnomalies()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT Code FROM Anomalie";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<String> codes = new List<String>();
                while (reader.Read())
                {
                    codes.Add((String)reader["code"]);
                }
                return codes;
            }
        }

        public List<Anomalie> getAnomaliesByType(int type)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM Anomalie WHERE typeanomalie=@type and code!='AUTRE'";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@type",type);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Anomalie> anomalies = new List<Anomalie>();
                while (reader.Read())
                {
                    Anomalie anomalie = new Anomalie();
                    anomalie.Id = (String) reader["code"];
                    anomalie.Designation = (String) reader["designation"];
                    anomalie.Type = type;
                    anomalies.Add(anomalie);
                }
                return anomalies;
            }
        }

        public int getTypeAnomalieByCode(String codeAnomalie)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT typeanomalie FROM Anomalie WHERE code=@code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@code", codeAnomalie);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return Convert.ToInt32(reader["typeanomalie"]);
            }
        }
        #endregion

    }
}

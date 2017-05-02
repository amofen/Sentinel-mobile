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
            throw new NotImplementedException();
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
        #endregion

    }
}

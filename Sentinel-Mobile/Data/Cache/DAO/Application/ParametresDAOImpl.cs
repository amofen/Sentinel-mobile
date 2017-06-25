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

        #endregion
    }
}

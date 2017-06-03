using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    class ChargementDAOImpl:ChargementDAO
    {

        #region ChargementDAO Members

        public bool vehiculeCharge(String vin)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(vin) FROM LigneDocumentTransport where vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Prepare();
                if ((int)cmd.ExecuteScalar() == 0) return false;
                else return true;
            }
        }

        public List<PointLivrable> getListPointLivrableByType(int type)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM PointLivrable WHERE type=@type";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@type", type);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<PointLivrable> listPtLivrable = new List<PointLivrable>();
                while (reader.Read())
                {
                    PointLivrable ptLivrable = new PointLivrable();
                    ptLivrable.Code = (String)reader["code"];
                    ptLivrable.Designation = (String)reader["designation"];
                    ptLivrable.Type = type;
                    listPtLivrable.Add(ptLivrable);
                }
                if (listPtLivrable.Count > 0) return listPtLivrable;
                else return null;
            }
        }

        public PointLivrable getListPointLivrableById(int id)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM PointLivrable WHERE id=@id";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", id);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                PointLivrable ptLivrable = null;
                if (reader.Read())
                {
                    ptLivrable = new PointLivrable();
                    ptLivrable.Code = (String)reader["code"];
                    ptLivrable.Designation = (String) reader["designation"];
                    ptLivrable.Type = Convert.ToInt32(reader["type"]);
                }
                return ptLivrable;
            }
        }
        #endregion
    }
}

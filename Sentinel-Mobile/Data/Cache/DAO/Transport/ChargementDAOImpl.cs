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

        public PointLivrable getListPointLivrableById(String code)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM PointLivrable WHERE code=@code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", code);
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

        public int sauvegarderPtLivrable(PointLivrable ptLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "INSERT INTO PointLivrable (code,designation,type)"
                                  + " VALUES (@code,@designation,@type)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@code",ptLivrable.Code);
                cmd.Parameters.AddWithValue("@designation", ptLivrable.Designation);
                cmd.Parameters.AddWithValue("@type", ptLivrable.Type);
                return cmd.ExecuteNonQuery();
            }
        }
        public bool ptLivrableExiste(PointLivrable ptLivrable)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(code) FROM PointLivrable where code=@code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", ptLivrable.Code);
                cmd.Prepare();
                if ((int)cmd.ExecuteScalar() == 0) return false;
                else return true;
            }
        }

        public PointLivrable getPtLivrableByLotId(string p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT    PointLivrable.code, PointLivrable.designation, PointLivrable.type" +
                                 "FROM      (SELECT  Arrivage.source AS Source" +
                                             "FROM            Arrivage INNER JOIN Lot ON Arrivage.code = Lot.codeArrivage" +
                                             "WHERE        (Lot.Id = 2)" +
                                             "GROUP BY Arrivage.source) AS SourceTable INNER JOIN   PointLivrable " +
                                  "ON SourceTable.Source = PointLivrable.code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@lotId", p);
                //Préparation de la requête
                //cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                PointLivrable ptLivrable = null;
                if (reader.Read())
                {
                    ptLivrable = new PointLivrable();
                    ptLivrable.Code = (String)reader["code"];
                    ptLivrable.Designation = (String)reader["designation"];
                    ptLivrable.Type = Convert.ToInt32(reader["type"]);
                }
                return ptLivrable;
            }
        }

        #endregion
    }
}

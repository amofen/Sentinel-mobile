using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    class DeclarationAnomalieDAOImpl:DeclarationAnomalieDAO
    {


        #region DeclarationAnomalieDAO Members

        public int sauvegarder(DeclarationAnomalie declaration)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "INSERT INTO DeclarationAnomalie (codeAnomalie,vinVehicule,commentaire)"
                                  + " VALUES (@codeAnomalie,@vinVehicule,@commentaire)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@codeAnomalie",declaration.Anomalie.Id);
                cmd.Parameters.AddWithValue("@vinVehicule",declaration.Vehicule.Vin);
                cmd.Parameters.AddWithValue("@commentaire",declaration.Commentaire);
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}

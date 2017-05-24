using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;

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

        #endregion
    }
}

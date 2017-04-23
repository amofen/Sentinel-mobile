using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using Sentinel_Mobile.Data.Config;
namespace Sentinel_Mobile.Data.Util
{
    class DBConnexionManager
    {
        public static SqlCeConnection connect()
        {
            DBParam.initDBString();
            SqlCeConnection cnx = new SqlCeConnection(DBParam.DB_NAME);
            try
            {
                cnx.Open();
            }
            catch (SqlCeException e)
            {
                throw e;
            }
            return cnx;
        }
    }
}

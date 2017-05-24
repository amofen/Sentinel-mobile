using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;

namespace Sentinel_Mobile.Business
{
    class ChargementManager
    {
        public bool vehiculeCharge(String vin)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            return dao.vehiculeCharge(vin);
        }
    }
}

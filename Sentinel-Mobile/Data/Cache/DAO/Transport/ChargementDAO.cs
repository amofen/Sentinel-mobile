using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    interface ChargementDAO
    {
        bool vehiculeCharge(String vin);

        List<PointLivrable> getListPointLivrableByType(int type);

        PointLivrable getListPointLivrableById(int id);
    }
}

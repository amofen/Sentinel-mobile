﻿using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    interface ChargementDAO
    {
        bool vehiculeCharge(String vin);

        List<PointLivrable> getListPointLivrableByType(int type);

        PointLivrable getListPointLivrableById(String code);

        int sauvegarderPtLivrable(PointLivrable ptLivrable);

        bool ptLivrableExiste(PointLivrable ptLivrable);

        PointLivrable getPtLivrableByLotId(string p);
    }
}

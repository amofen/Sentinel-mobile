using System;
using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Data.Cache.DAO.Vehicules
{
    interface LotDAO
    {
        void sauvegarderLot(Lot lot);
        List<Lot> getCacheLots();
    }
}

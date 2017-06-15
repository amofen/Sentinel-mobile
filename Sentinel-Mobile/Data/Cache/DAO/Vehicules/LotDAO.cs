using System;
using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Data.Cache.DAO.Vehicules
{
    interface LotDAO
    {

        //Arrivage
        void sauvegarderLot(Lot lot);
        List<Lot> getCacheLots();
        

        //Arrivage
        void sauvegarderArrivage(Arrivage arrivage);

        List<Arrivage> getArrivageByPtLivrableCode(string code);

        List<Lot> getLotsByArrivageCode(long p);

    }
}

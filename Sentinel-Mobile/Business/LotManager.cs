using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Data.Cache.DAO.Vehicules;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
namespace Sentinel_Mobile.Business
{
    class LotManager
    {
        public List<Lot> getLotsPrevu(String idPort)
        {
            List<Lot> lots = new List<Lot>();
            LotService lotService = new LotService();
            foreach (LotDTO lotDTO in lotService.getLotPrevu())
            {
                Lot lot = ModelDTOConverter.convertLot(lotDTO);
                lots.Add(lot);
            }
            return lots;
            
        }

        public void saveLots(List<Lot> lots)
        {
            LotDAO lotDAO = new LotDAOImpl();
            foreach (Lot lot in lots)
            {
                lotDAO.sauvegarderLot(lot);
            }
        }



        public List<Lot> getCacheLots()
        {
            LotDAO lotDAO = new LotDAOImpl();
            return lotDAO.getCacheLots();

        }
    }
}

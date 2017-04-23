using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Util;
namespace Sentinel_Mobile.Business
{
    class LotManager
    {
        public List<Lot> getLotsPrevu(String idPort)
        {
            List<Lot> lots = new List<Lot>();
            LotService lotService = new LotService();
            foreach (LotDTO lotDTO in lotService.getLotPrevu(idPort))
            {
                Lot lot = DTOToModelConverter.convertLot(lotDTO);
                lots.Add(lot);
            }
            return lots;
            
        }
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Business;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class InitController
    {
        public void initLots()
        {
            
            LotManager lotManager = new LotManager();
            List<Lot> listLot = lotManager.getLotsPrevu(null);
            try
            {
                lotManager.saveLots(listLot);
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);   
            }
         
        }

        public int getNombreVehiculesArrivage()
        {
            LotManager lotManager = new LotManager();
            List<Lot> lots = lotManager.getCacheLots();
            VehiculeManager vehiculeManager = new VehiculeManager();
            int cumulVehicules = 0;
            foreach (Lot lot in lots)
            {
                cumulVehicules += vehiculeManager.getNombreVehiculeLot(lot.Id);
            }
            return cumulVehicules;
        }
    }
}

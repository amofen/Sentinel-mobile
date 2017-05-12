using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Business
{
    class SynchronisationManager
    {
        SynchronisationService syncService = new SynchronisationService();
        public void syncScanArrivage()
        {
            if (ConnectionTester.test())
            {
                VehiculeDAO vehiculeDao = new VehiculeDAOImpl();
                List<Scan> scans = vehiculeDao.getScansByEtatSync(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                if (scans != null)
                {
                    foreach (Scan scan in scans)
                    {
                        ScanDTO scanDTO = ModelDTOConverter.convertScan(scan);
                        if (syncService.syncScan(scanDTO))
                        {
                            vehiculeDao.setVehiculeScanEtat(scan.Vin, SynchronisationService.SynchronisationParams.SYNCHRONISE);
                        }
                    }
                }
            }
            
        }
    }
}

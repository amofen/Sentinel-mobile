using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.Cache.DAO.Avaries;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Business
{
    class SynchronisationManager
    {
        SynchronisationService syncService = new SynchronisationService();
        public void syncScanRoutine()
        {
            if (ConnectionTester.IS_CONNECTED)
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

        public void syncDeclarationAnomalies()
        {
            if (ConnectionTester.IS_CONNECTED)
            {
                DeclarationAnomalieDAO declarationDAO = new DeclarationAnomalieDAOImpl();
                List<DeclarationAnomalie> declarations = declarationDAO.getDeclarationsByEtatSync(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                if (declarations != null)
                {
                    foreach (DeclarationAnomalie declaration in declarations)
                    {
                        DeclarationAnomalieDTO declarationDTO = ModelDTOConverter.convertDevlarationAnomalie(declaration);
                        if (syncService.syncDeclarationAnomalie(declarationDTO))
                        {
                            declarationDAO.setDeclarationAnomalieEtatSync(declaration.Vin, declaration.Anomalie, SynchronisationService.SynchronisationParams.SYNCHRONISE);
                        }
                    }
                }
            }
        }
    }
}

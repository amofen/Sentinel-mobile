﻿using System;

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
                    List<ScanDTO> listDTO = new List<ScanDTO>();
                    foreach (Scan scan in scans)
                    {
                        ScanDTO scanDTO = ModelDTOConverter.convertScan(scan);
                        listDTO.Add(scanDTO);
                    }
                    if (listDTO.Count > 0)
                    {
                        if (syncService.syncScan(listDTO))
                        {
                            foreach (Scan scan in scans)
                            {
                                vehiculeDao.setVehiculeScanEtat(scan.Vin, SynchronisationService.SynchronisationParams.SYNCHRONISE);
                            }
                            
                        }
                    }
                }
            }

        }

        public void syncDeclarationAnomaliesRoutine()
        {
            if (ConnectionTester.IS_CONNECTED)
            {
                DeclarationAnomalieDAO dao = new DeclarationAnomalieDAOImpl();
                List<DeclarationAnomalie> listDeclaration = dao.getDeclarationsByEtatSync(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                List<DeclarationAnomalieDTO> listDTO = new List<DeclarationAnomalieDTO>();
                foreach (DeclarationAnomalie declaration in listDeclaration)
                {
                    DeclarationAnomalieDTO declarationDTO = ModelDTOConverter.convertDevlarationAnomalie(declaration);
                    listDTO.Add(declarationDTO);
                }
                if (listDTO.Count>0 && syncService.syncDeclarationAnomalie(listDTO))
                {
                    foreach (DeclarationAnomalie declaration in listDeclaration)
                    {
                        dao.setDeclarationAnomalieEtatSync(declaration.Vin, declaration.Anomalie, SynchronisationService.SynchronisationParams.SYNCHRONISE);
                    }
                }
            }
        }
    }
}

﻿using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.DAO;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;

namespace Sentinel_Mobile.Business
{
    class VehiculeManager
    {
        public Vehicule getVehiculeByVin(String vin)
        {
            VehiculeDAO vehiculeDAO = new VehiculeDAOImpl();
            return vehiculeDAO.getVehiculeByVin(vin);
        }


        //Enregistre le vehicule comme scanné (si il ne l'est pas encore). Retour 0: Vehicule scanné déja 1: Véhicule non scanné 
        public bool scannerVehicule(String vin, int etape, String codePtLivrable)
        {
            VehiculeDAO dao = new VehiculeDAOImpl();
            if (!dao.vehiculeScanne(vin,etape))
            {
                dao.scannerVehicule(vin,etape,codePtLivrable);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getNombreVehiculeLot(String numLot)
        {
            VehiculeDAO vehiculeDAO = new VehiculeDAOImpl();
            return vehiculeDAO.getNombreVehiculeByNumLot(numLot);

        }

        public int getNombreVehiculeEnCoursScannePort()
        {
            VehiculeDAO dao = new VehiculeDAOImpl();
            return dao.getNbVehiculesScannesPort();
        }

        public bool vehiculeAvecAnomalie(String vin)
        {
            AnomalieManager anomalieManager = new AnomalieManager();
            return anomalieManager.vehiculeAvecAnomalie(vin);
        }

        public List<Vehicule> getVehiculesByLotId(String id)
        {
            VehiculeDAO dao = new VehiculeDAOImpl();
            return dao.getVehiculesByLotId(id);
        }

        internal bool rescannerVehicule(string vin, int p, String pointLivrable)
        {
            VehiculeDAO dao = new VehiculeDAOImpl();
            return dao.setVehiculeScanEtapeEtat(vin, p, pointLivrable);
        }
    }
}

using System;

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
        public bool scannerVehicule(String vin)
        {
            ScanDAO dao = new ScanDAOImpl();
            if (dao.vehiculeScanne(vin)==0)
            {
                dao.scannerVehicule(vin);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Data.DAO.Cache.Vehicules
{
    interface VehiculeDAO
    {
        //Concerne le véhicule en générale
        Vehicule getVehiculeByVin(String vin);
        int sauvegarderVehicule(Vehicule vehicule);
        List<Vehicule> getVehiculesByLotId(String id);
        int getNombreVehiculeByNumLot(string numLot);
        void scannerVehicule(String vin,int etape);
        bool vehiculeScanne(String vin);
        int getNbVehiculesScannes();

        //Concerne les déclarations 
        List<Scan> getScansByEtatSync(int syncEtat);
        void setVehiculeScanEtat(String vin, int syncEtat);
    }
}

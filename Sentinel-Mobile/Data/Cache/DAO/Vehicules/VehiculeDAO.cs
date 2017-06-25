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
        int getNombreVehiculeByNumLot(string numLot);
        List<Vehicule> getVehiculesByLotId(string id);
        void scannerVehicule(String vin, int etape, String codePtLivrable);
        bool vehiculeScanne(String vin,int etape);
        int getNbVehiculesScannesPort();

        //Concerne la synchcronisation
        List<Scan> getScansByEtatSync(int syncEtat);
        void setVehiculeScanEtat(String vin, int syncEtat);

        bool setVehiculeScanEtapeEtat(string vin, int p, string pointLivrable);
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Data.DAO.Cache.Vehicules
{
    interface VehiculeDAO
    {
        Vehicule getVehiculeByVin(String vin);
        int sauvegarderVehicule(Vehicule vehicule);
        List<Vehicule> getVehiculesByLotId(String id);
        int getNombreVehiculeByNumLot(string numLot);
    }
}

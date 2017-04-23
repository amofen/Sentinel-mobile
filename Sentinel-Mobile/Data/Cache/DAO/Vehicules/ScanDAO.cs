using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.DAO.Cache.Vehicules
{
    interface ScanDAO
    {
        int vehiculeScanne(String vin);
        int scannerVehicule(String vin);
        int getNbVehiculesScannes();
    }
}

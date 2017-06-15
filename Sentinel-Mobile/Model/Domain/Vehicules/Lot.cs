using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    class Lot
    {
        public String Id { get; set; }
        public List<Vehicule> vehicules { get; set; }
        public long CodeArrivage { get; set; }

        public override string ToString()
        {
            return "Lot N°: "+Id+" -  Nb véhicules:"+vehicules.Count;
        }
    }
}

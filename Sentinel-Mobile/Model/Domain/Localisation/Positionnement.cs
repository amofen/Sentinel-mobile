using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    public class Positionnement
    {
        public Vehicule Veicule { get; set; }
        public String CodeParc { get; set; }
        public String Zone { get; set; }
        public String Plateforme { get; set; }
        public String Rangee { get; set; }
        public int NumeroDsRangee { get; set; }
        public DateTime date { get; set; }


        public override string ToString()
        {
            return Veicule.Vin+" | "+CodeParc+" | "+Zone+"-"+Plateforme+Rangee+"-"+NumeroDsRangee;
        }
    }
}

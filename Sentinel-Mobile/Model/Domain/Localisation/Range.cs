using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    class Range
    {
        public String NomZone { get; set; }
        public String NomPlateforme { get; set; }
        public String Nom { get; set; }
        public int NbMaxPlaces { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }
}

using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    class Plateforme
    {
        public String NomZone { get; set; }
        public String Nom { get; set; }
        public int NbMaxRanges { get; set; }
        public List<Range> Ranges { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }
}

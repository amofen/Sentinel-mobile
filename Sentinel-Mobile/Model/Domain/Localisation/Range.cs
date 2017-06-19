using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    public class Range
    {
        public String CodeZone { get; set; }
        public String CodePlateforme { get; set; }
        public String Code { get; set; }
        public int NbrMaxPlaces { get; set; }

        public override string ToString()
        {
            return Code;
        }
    }
}

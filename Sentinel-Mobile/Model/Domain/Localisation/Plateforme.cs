using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    public class Plateforme
    {
        public String CodeZone { get; set; }
        public String Code { get; set; }
        public int NbrMaxRangees { get; set; }
        public List<Range> Rangees { get; set; }
        public override string ToString()
        {
            return Code;
        }
    }
}

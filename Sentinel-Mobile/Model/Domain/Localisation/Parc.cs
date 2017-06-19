using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    class Parc
    {
        public String Nom { get; set; }
        public String Code { get; set; }
        public List<Zone> Zones { get; set; }
    }
}

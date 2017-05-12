using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    class Scan
    {
        public String Vin { get; set; }
        public DateTime Date { get; set; }
        public int Etape { get; set; }
    }
}

using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.DTO
{
    class ChassisManifestDTO
    {
        public String vin { get; set; }
        public String Destination { get; set; }
        public List<String> Anomalies { get; set; }
    }
}

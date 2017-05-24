using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class Camion
    {
        public String Id{ get; set; }
        public String Transporteur { get; set; }

        public override String ToString()
        {
            return Id;
        }
    }
}

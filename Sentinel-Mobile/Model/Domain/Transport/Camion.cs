using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class Camion
    {
        public String NumeroImmatriculation{ get; set; }
        public String Transporteur { get; set; }
        public String Modele { get; set; }

        public override String ToString()
        {
            return NumeroImmatriculation+"-"+Modele;
        }
    }
}

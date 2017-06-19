using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class Chauffeur
    {
        public String NumeroPermis { get; set; }
        public String NomPrenom { get; set; }
        public String CodeTransporteur { get; set; }

        public override string ToString()
        {
            return NomPrenom;
        }
    }
}

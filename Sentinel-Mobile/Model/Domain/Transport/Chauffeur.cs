using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class Chauffeur
    {
        public String Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }

        public override string ToString()
        {
            return Nom+" "+Prenom;
        }
    }
}

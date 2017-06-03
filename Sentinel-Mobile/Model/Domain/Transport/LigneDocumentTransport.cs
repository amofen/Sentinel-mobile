using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class LigneDocumentTransport
    {
        public String Vin { get; set; }
        public String Modele { get; set; }
        public PointLivrable Destination { get; set; }
        public List<DeclarationAnomalie> Declarations { get; set; }
    }
}

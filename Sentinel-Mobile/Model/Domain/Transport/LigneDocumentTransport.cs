using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class LigneDocumentTransport
    {
        public String Vin { get; set; }
        public PointLivrable Destination { get; set; }
    }
}

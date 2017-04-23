using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    class Lot
    {
        public DateTime DatePrevueArrive { get; set; }
        public DateTime DateReelleArrive { get; set; }
        public String Id { get; set; }
        public List<Vehicule> vehicules { get; set; }
    }
}

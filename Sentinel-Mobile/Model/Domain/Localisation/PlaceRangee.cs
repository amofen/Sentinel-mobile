using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    class PlaceRangee
    {
        public Vehicule Vehicule { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int NumPlace { get; set; }
        public bool Courante { get; set; }
    }
}

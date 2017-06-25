using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    public class Vehicule
    {
        //Etapes
        public const int TRANSPORT_MARITIME = 0;
        public const int PORT = 1;
        public const int TRANSIT = 2;
        public const int PARC_SOUS_DOUANE = 3;
        public const int PARC_LIBRE = 4;
        public const int LIVRAISON = 5;
        public const int TRANSFERT = 6;
        public const int ATELIER = 7;

        public String Couleur { get; set; }
        public String Model { get; set; }
        public String Vin { get; set; }
        public String Lot { get; set; }
    }
}

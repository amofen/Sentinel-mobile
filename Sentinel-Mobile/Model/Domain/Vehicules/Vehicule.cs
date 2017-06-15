using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    public class Vehicule
    {
        //Etapes
        public static int TRANSPORT_MARITIME = 0;
        public static int PORT = 1;
        public static int TRANSIT = 2;
        public static int PARC_SOUS_DOUANE = 3;
        public static int PARC_LIBRE = 4;
        public static int LIVRAISON = 5;
        public static int TRANSFERT = 6;
        public static int ATELIER = 7;

        public String Couleur { get; set; }
        public String Model { get; set; }
        public String Vin { get; set; }
        public String Lot { get; set; }
    }
}

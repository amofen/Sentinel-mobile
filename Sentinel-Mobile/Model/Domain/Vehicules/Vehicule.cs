using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    class Vehicule
    {
        //Etapes
        public static int TRANSPORT_MARITIME = 0;
        public static int PORT = 1;
        public static int TRANSIT = 2;
        public static int PARC_DEDOUANE = 3;
        public static int PARC_NON_DEDOUANE = 4;
        public static int TRANSFERT = 5;
        public static int LIVRAISON = 6;

        public String Couleur { get; set; }
        public String Model { get; set; }
        public String Vin { get; set; }
        public String Lot { get; set; }
    }
}

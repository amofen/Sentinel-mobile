using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Model.Domain.Avaries
{
    class DeclarationAnomalie
    {
        //Etapes
        public static int TRANSPORT_MARITIME = 1;
        public static int PORT  = 2;
        public static int TRANSIT = 3;
        public static int PARC = 4;
        public static int TRANSFERT = 5;
        public static int LIVRAISON = 6;
        //Etat de l'anomalie
        public static int NON_TRAITEE = 1;        
        public static int TRAITEE = 2;
        public static int IGNOREE = 3;

        public Anomalie Anomalie { get; set; }
        public Vehicule Vehicule { get; set; }
        public String Commentaire { get; set; }
        public DateTime Date { get; set; }
        public int Etape { get; set; }
        public int EtatAnomalie { get; set; }

    }
}

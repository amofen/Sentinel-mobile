using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;

namespace Sentinel_Mobile.Model.Domain.Avaries
{
    class DeclarationAnomalie
    {
        //Etat de l'anomalie
        public static int NON_TRAITEE = 1;        
        public static int TRAITEE = 2;
        public static int IGNOREE = 3;

        public String Anomalie { get; set; }
        public String Vin { get; set; }
        public DateTime Date { get; set; }
        public int Etape { get; set; }

    }
}

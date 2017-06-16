using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Avaries
{
    class Anomalie
    {
        public static int MANQUE = 1;
        public static int AVARIE = 0;
        public static int AUTRE_CATEGORIE = 3;

        public static int VALIDEE = 1;
        public static int NON_VALIDEE = 0;

        public String Id { get; set; }
        public String Designation { get; set; }
        public int Type { get; set; }

    }
}

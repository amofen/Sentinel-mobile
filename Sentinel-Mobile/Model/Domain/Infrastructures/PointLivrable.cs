using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Infrastructures
{
    public class PointLivrable
    {
        public String Code { get; set; }
        public int Type { get; set; }
        public String Designation { get; set; }
        //Les types des points livrables 
        public static int PORT = 0;
        public static int PARC = 1;
        public static int SHOW_ROOM = 2;
        public static int CONCESSIONNAIRE = 3;

        public override string ToString()
        {
            return Designation;
        }
    }
}

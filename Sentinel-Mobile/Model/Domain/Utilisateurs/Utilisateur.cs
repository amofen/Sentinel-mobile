using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.Domain.Utilisateur
{
    class Utilisateur
    {
        public static int AGENT_PORT = 1;
        public static int AGENT_PAC = 2;
        public string nom { set; get; }
        public int typeUtilisateur {set;get;}
        public string nomUtilisateur { get; set; }
        public string motPasse { get; set; }
    }
}

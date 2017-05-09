using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Config
{
    class UtilisateurCache
    {
        public class Params
        {
            //Les noms des différents paramètres à utiliser 
            public static String NOM_UTILISATEUR = "nom_utilisateur";
            public static String MOT_PASSE_UTILISATEUR = "mot_passe";
            public static String COOKIE_SESSION = "cookie";
            public static String PORT = "port";
            public static String PARC = "parc";
            public static String TYPE_AGENT = "type_agent";
            public static String DECLARATION_AVANCEE = "declaration_avancee";
        }
        public static int Type = 0;
        public static String Port = "MOSTA";
        public static String CurrentUserCookie = "";
        public static String CurrentUserName="Agent 1";
        public static String CurrentUserPassword = "123";
    }
}

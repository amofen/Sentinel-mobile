using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Config
{
    class ConnexionParam
    {
        //Informations de connexion au serveur 
        public static String PROTOCOLE = "http";
        public static String SERVER_IP = "192.168.1.15";
        public static int SERVER_PORT = 51740;
        public static String SERVER_HOST_URL = PROTOCOLE+"://"+SERVER_IP+":"+SERVER_PORT;

        //Les paths d'accès au services
        public static String API = SERVER_HOST_URL + "/api";
        public static String LOT_SERVICE = API+"/Lots";
        public static String AUTH_SERVICE = API + "/auth/login";
        public static String VALIDER_SCAN = API + "/validate/scan";
        public static String VALIDER_DECLARATION_ANOMALIE = API + "/validate/declarations";
    }
}

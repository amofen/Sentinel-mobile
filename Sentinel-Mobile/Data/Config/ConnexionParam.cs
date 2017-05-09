using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Config
{
    class ConnexionParam
    {
        public static string SERVER_HOST_URL = "http://192.168.0.20:51740";
        //ICI on saisi tout les paths d'accès au services
        public static string API = SERVER_HOST_URL + "/api";
        public static string LOT_SERVICE = API+"/Lots";
        public static string AUTH_SERVICE = API + "/auth/login";
    }
}

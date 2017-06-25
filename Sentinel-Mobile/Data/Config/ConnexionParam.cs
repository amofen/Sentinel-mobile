using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Config
{
    class ConnexionParam
    {
        //Informations de connexion au serveur 
        public static String PROTOCOLE = "http";
        public static String SERVER_IP = "192.168.43.12";
        public static int SERVER_PORT = 51740;
        public static String SERVER_HOST_URL = PROTOCOLE+"://"+SERVER_IP+":"+SERVER_PORT;

        //Les paths d'accès au services
        public static String API = SERVER_HOST_URL + "/api";
        public static String LOT_SERVICE = API+"/Lots";
        public static String AUTH_SERVICE = API + "/auth/login";
        public static String VALIDER_DECLARATION_ANOMALIE = API + "/Anomalies";
        public static String PT_LIVRABLE_SERVICE = API+"/GetPointsLivrables";
        public static String ARRIVAGES_SERVICE = API + "/Arrivages";
        public static String VEHICULES_SERVICE = API + "/Vehicules";
        public static String CODES_AVARIES = API + "/CodesAvaries";
        public static String CODES_OBJETS = API + "/CodesObjets";
        public static String CHAUFFEURS_SERVICE = API + "/GetChauffeurs";
        public static String CAMIONS_SERVICE = API + "/GetCamions";
        public static String OPERATION_TRANSPORT_SERVICE = API + "/OperationTransport";
        public static String ZONES_SERVICES = API + "/GetParcs";
        public static String POSITIONNEMENT_SERVICE = API + "/PositionnerVehicules";
        public static String OPERATION_RECEP_GET_SERVICE = API + "/GetOperations?codeDestination=";
        public static String OPERATION_RECEP_END = API + "/EndOperation";
    }
}

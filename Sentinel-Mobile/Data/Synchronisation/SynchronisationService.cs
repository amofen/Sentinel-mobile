using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.DTO;
using CodeTitans.JSon;
using System.Net;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class SynchronisationService
    {

    
        public  class SynchronisationParams
        {
            //L'entrée n'a jamais été synchronisée
            public static int NON_SYNCHRONISEE = 0;
            //L'entrée a été synchronisée
            public static int SYNCHRONISE = 1;
            //L'entrée a été synchronisée, mais il y a eu des modifications après la synchronisation
            public static int SYNCHRONISE_MODIFIE = 2;
        }


        public bool syncScan(ScanDTO scan)
        {
            JSonWriter writer = new JSonWriter();
            writer.Write(scan);
            String json = writer.ToString();

            using (HttpWebResponse reponse = APIConsumer.postJsonRequest(ConnexionParam.VALIDER_SCAN, json))
            {
                if (reponse != null)
                {
                    if (reponse.StatusCode == HttpStatusCode.OK) return true;
                    else return false;
                }
                else return false;
            }
        }

        public bool syncDeclarationAnomalie(DeclarationAnomalieDTO declaration)
        {
            JSonWriter writer = new JSonWriter();
            writer.Write(declaration);
            String json = writer.ToString();

            using (HttpWebResponse reponse = APIConsumer.postJsonRequest(ConnexionParam.VALIDER_DECLARATION_ANOMALIE, json))
            {
                if (reponse != null)
                {
                    if (reponse.StatusCode == HttpStatusCode.OK) return true;
                    else return false;
                }
                else return false;
            }
        }
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Data.Util;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class AnomalieService
    {
        public List<AnomalieDTO> getListAvaries()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.CODES_AVARIES);
            List<AnomalieDTO> listAnomalies = new List<AnomalieDTO>();
            JSonReader jReader = new JSonReader();
            foreach (IJSonObject anomalieJObject in jReader.ReadAsJSonObject(json).ArrayItems)
            {
                AnomalieDTO anomalieDTO = new AnomalieDTO();
                anomalieDTO.Read(anomalieJObject);
                listAnomalies.Add(anomalieDTO);
            }
            return listAnomalies;
        }

        public List<AnomalieDTO> getListObjetsManquants()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.CODES_OBJETS);
            List<AnomalieDTO> listAnomalies = new List<AnomalieDTO>();
            JSonReader jReader = new JSonReader();
            foreach (IJSonObject anomalieJObject in jReader.ReadAsJSonObject(json).ArrayItems)
            {
                AnomalieDTO anomalieDTO = new AnomalieDTO();
                anomalieDTO.Read(anomalieJObject);
                listAnomalies.Add(anomalieDTO);
            }
            return listAnomalies;
        }
    }
}

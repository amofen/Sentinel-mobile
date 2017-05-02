using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using CodeTitans.JSon;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Cache.DAO.Vehicules;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class LotService
    {
        public List<LotDTO> getLotPrevu()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.LOT_SERVICE);
            List<LotDTO> listLots = new List<LotDTO>();
            JSonReader jReader = new JSonReader();
            IJSonObject jObject = jReader.ReadAsJSonObject(json);
            foreach ( IJSonObject lotJObject in jObject.ArrayItems)
            {
                LotDTO lotDTO = new LotDTO();
                lotDTO.Read(lotJObject);
                listLots.Add(lotDTO);
            }
            return listLots ;
        }

    }
}

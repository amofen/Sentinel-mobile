using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.DTO;
using CodeTitans.JSon;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Model.Util;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class LocalisationService
    {
        public List<PointLivrable> getListPtLivrables()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.PT_LIVRABLE_SERVICE);
            List<PointLivrable> listPtLivrables = new List<PointLivrable>();
            JSonReader jReader = new JSonReader();
            IJSonObject jObject = jReader.ReadAsJSonObject(json);
            foreach (IJSonObject lotJObject in jObject.ArrayItems)
            {
                PointLivrableDTO ptLivrableDto = new PointLivrableDTO();
                ptLivrableDto.Read(lotJObject);
                PointLivrable ptLivrable = new PointLivrable();
                ptLivrable.Code = ptLivrableDto.Code;
                ptLivrable.Type = ptLivrableDto.Type;
                ptLivrable.Designation = ptLivrableDto.Designation;
                listPtLivrables.Add(ptLivrable);
            }
            return listPtLivrables;
        }

        public List<Zone> getListZones()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.ZONES_SERVICES);
            List<Zone> listZones = new List<Zone>();
            JSonReader jReader = new JSonReader();
            IJSonObject jObject = jReader.ReadAsJSonObject(json);
            foreach (IJSonObject iJObject in jObject.ArrayItems)
            {
                ParcDTO parcDTO = new ParcDTO();
                parcDTO.Read(iJObject);
                foreach (ZoneDTO zoneDTO in parcDTO.Zones)
                {
                    Zone zone = ModelDTOConverter.convertZones(zoneDTO,parcDTO.Code);
                    listZones.Add(zone);
                }
            }

            return listZones;
        }




    }
}

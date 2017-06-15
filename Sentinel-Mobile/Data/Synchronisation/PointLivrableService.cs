using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.DTO;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class PointLivrableService
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
    }
}

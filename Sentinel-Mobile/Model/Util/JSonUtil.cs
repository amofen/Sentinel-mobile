using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.DTO;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.Util
{
    class JSonUtil
    {
        public static List<LotDTO> getLotDTOArrayFromJson(String json)
        {
            JSonReader reader = new JSonReader();
            IJSonObject jsonObject = reader.ReadAsJSonObject(json);
            IJSonObject[] jobjects = (IJSonObject[])jsonObject.ArrayItems;
            List<LotDTO> listDTO = new List<LotDTO>();
            foreach (IJSonObject jobject in jobjects)
            {
                LotDTO lotDTO = new LotDTO();
                lotDTO.Read(jobject);
                listDTO.Add(lotDTO);
            }
            return listDTO;
        }
    }
}

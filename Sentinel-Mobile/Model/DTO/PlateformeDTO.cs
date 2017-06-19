using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class PlateformeDTO:IJSonSerializable
    {
        public String Code { get; set; }
        public int NbrMaxRangees { get; set; }
        public List<RangeeDTO> Rangees{ get; set; }
        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Code = input["Code"].StringValue;
            NbrMaxRangees = input["NbrMaxRangees"].Int32Value;
            Rangees = new List<RangeeDTO>();
            foreach (IJSonObject iJSonObject in input["Rangees"].ArrayItems)
            {
                RangeeDTO rangeeDTO = new RangeeDTO();
                rangeeDTO.Read(iJSonObject);
                Rangees.Add(rangeeDTO);
            }
        }

        #endregion
    }
}

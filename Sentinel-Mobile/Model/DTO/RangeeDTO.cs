using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class RangeeDTO:IJSonSerializable
    {
        public String Code { get; set; }
        public int NbrMaxPlaces { get; set; }


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
            NbrMaxPlaces = input["NbrMaxPlaces"].Int32Value;
        }

        #endregion
    }
}

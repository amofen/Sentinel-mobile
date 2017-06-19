using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class TransporteurDTO:IJSonSerializable
    {
        public String Code { get; set; }
        public String Nom { get; set; }
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
            Nom = input["Nom"].StringValue;
        }

        #endregion
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class DestinationVehicule:IJSonSerializable
    {
        public String Vin { get; set; }
        public String CodeDestination { get; set; }

        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Vin",Vin);
            output.WriteMember("CodeDestination",CodeDestination);
            output.WriteObjectEnd();

        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

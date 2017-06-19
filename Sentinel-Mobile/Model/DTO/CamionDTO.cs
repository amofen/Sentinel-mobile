using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class CamionDTO:IJSonSerializable
    {
        public String Id { get; set; }
        public String Transporteur { get; set; }
        public String Modele { get; set; }


        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Id = input["NumImmatriculation"].StringValue;
            Transporteur = input["CodeTransporteur"].StringValue;
            Modele = input["MarqueModele"].StringValue;
        }

        #endregion
    }
}

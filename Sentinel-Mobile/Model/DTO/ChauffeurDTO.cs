using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class ChauffeurDTO:IJSonSerializable
    {
        public String CodeTransporteur  { get; set; }
        public String NomPrenom { get; set; }
        public String NumeroPermis { get; set; }



        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            CodeTransporteur = input["CodeTransporteur"].StringValue;
            NomPrenom = input["NomPrenom"].StringValue;
            NumeroPermis = input["NumeroPermis"].StringValue;
        }

        #endregion
    }
}

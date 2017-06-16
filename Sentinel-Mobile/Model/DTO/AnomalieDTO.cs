using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;
namespace Sentinel_Mobile.Model.DTO
{
    class AnomalieDTO:IJSonSerializable
    {

        public String Id { get; set; }
        public String Designation { get; set; }
        public int Type { get; set; }



        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Id = input["Code"].StringValue;
            Designation = input["Designation"].StringValue;
        }

        #endregion

        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

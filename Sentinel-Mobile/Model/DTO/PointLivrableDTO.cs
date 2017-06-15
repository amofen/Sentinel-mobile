using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class PointLivrableDTO:IJSonSerializable
    {
        public String Code { get; set; }
        public int Type { get; set; }
        public String Designation { get; set; }





        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Code", Designation);
            output.WriteMember("Nom", Designation);
            output.WriteMember("Type", Type);
            output.WriteObjectEnd();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Code = input["Code"].StringValue;
            Designation = input["Nom"].StringValue;
            Type = input["Type"].Int32Value;
        }

        #endregion
    }
}

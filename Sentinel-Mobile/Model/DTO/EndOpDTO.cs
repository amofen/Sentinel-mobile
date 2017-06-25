using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class EndOpDTO:IJSonSerializable
    {
        public long Code { get; set; }
        public DateTime DateArrivee { get; set; }
        public List<String> Vins { get; set; }



        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Code",Code);
            output.WriteMember("DateArrivee", DateArrivee);
            output.WriteMember("Vins");
            output.Write(Vins);
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

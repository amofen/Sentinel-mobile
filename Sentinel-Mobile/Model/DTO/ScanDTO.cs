using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class ScanDTO : IJSonSerializable
    {
        public String Vin { get; set; }
        public DateTime Date { get; set; }
        public int Etape { get; set; }


        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Vin",Vin);
            output.WriteMember("Date",Date);
            output.WriteMember("Etape",Etape);
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

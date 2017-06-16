using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class DeclarationAnomalieDTO:IJSonSerializable
    {
        public String Vin { get; set; }
        public String Anomalie { get; set; }
        public DateTime Date { get; set; }
        public int Etape { get; set; }
        public int Type { get; set; }



        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("CodeTypeAvarie", Anomalie);
            output.WriteMember("Vin",Vin);
            output.WriteMember("DateOccurence", Date);
            output.WriteMember("Etape", Etape);
            output.WriteMember("Type", Type);
            output.WriteMember("CodeObjetManquant", Anomalie);
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

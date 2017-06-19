using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class PositionnementDTO:IJSonSerializable
    {
        public String Vin { get; set; }
        public String CodeParc { get; set; }
        public String CodeZone { get; set; }
        public String CodePlateforme { get; set; }
        public String CodeRangee { get; set; }
        public int NumeroDsRangee { get; set; }
        public DateTime DateDebutOccupation { get; set; }




        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Vin",Vin);
            output.WriteMember("CodeParc",CodeParc);
            output.WriteMember("CodeZone",CodeZone);
            output.WriteMember("CodePlateforme",CodePlateforme);
            output.WriteMember("CodeRangee",CodeRangee);
            output.WriteMember("NumeroDsRangee",NumeroDsRangee);
            output.WriteMember("DateDebutOccupation",DateDebutOccupation);
            output.WriteObjectEnd();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Vin = input["Vin"].StringValue;
            CodeParc = input["CodeParc"].StringValue;
            CodeZone = input["CodeZone"].StringValue;
            CodePlateforme = input["CodePlateforme"].StringValue;
            CodeRangee = input["CodeRangee"].StringValue;
            NumeroDsRangee = input["NumeroDsRangee"].Int32Value;
            DateDebutOccupation = input["DateDebutOccupation"].DateTimeValue;
        }

        #endregion
    }
}

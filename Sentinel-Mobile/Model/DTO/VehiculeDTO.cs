using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class VehiculeDTO:IJSonSerializable
    {
        public String Annee { get; set; }//Pas besoin
        public String Couleur { get; set; }
        public String Model { get; set; }//Modele et Marque des strings
        public String Vin { get; set; }
        public String LotId { get; set; }//NumeroLot 

        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Vin",Vin);
            output.WriteMember("Annee",Annee);
            output.WriteMember("Couleur",Couleur);
            output.WriteMember("Model",Model);
            output.WriteMember("LotId",LotId);
            output.WriteObjectEnd();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Vin = input["Vin"].StringValue;
            Couleur = input["Couleur"].StringValue;
            Annee = input["Annee"].StringValue;
            Model = input["Model"].StringValue;
            LotId = input["LotId"].StringValue;
        }

        #endregion
    }
}

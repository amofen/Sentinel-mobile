using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    public class VehiculeDTO:IJSonSerializable
    {
        public String Couleur { get; set; }
        public String Modele { get; set; }//Modele et Marque des strings
        public String Marque { get; set; }
        public String Vin { get; set; }
        public int NumeroLot { get; set; }//NumeroLot 
        public bool Receptionne { get; set; }
        public List<DeclarationAnomalieDTO> Anomalies { get; set; }

        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Vin",Vin);
            output.WriteMember("Couleur",Couleur);
            output.WriteMember("Modele",Modele);
            output.WriteMember("Marque", Marque);
            output.WriteMember("NumeroLot",NumeroLot);
            output.WriteObjectEnd();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Vin = input["Vin"].StringValue;
            Couleur = input["Couleur"].StringValue;
            Modele = input["Modele"].StringValue;
            Marque = input["Marque"].StringValue;
            NumeroLot = input["NumeroLot"].Int32Value;
            Anomalies = new List<DeclarationAnomalieDTO>();
            foreach (IJSonObject iJObject in input["Anomalies"].ArrayItems)
            {
                DeclarationAnomalieDTO anomalieDTO = new DeclarationAnomalieDTO();
                anomalieDTO.Read(iJObject);
                Anomalies.Add(anomalieDTO);
            }
        }

        #endregion
    }
}

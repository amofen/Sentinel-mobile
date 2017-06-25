using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    public class OpTransportReceptionneeDTO:IJSonSerializable
    {
        public long Code { get; set; }
        public DateTime DateDepart { get; set; }
        public String NumeroImmatriculation { get; set; }
        public String NumPermisChauffeur { get; set; }
        public String CodeLieuDepart { get; set; }
        public String CodeLieuArrive { get; set; }
        public int TypeOperation { get; set; }
        public List<VehiculeDTO> Vehicules { get; set; }




        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Code = input["Code"].Int64Value;
            DateDepart = input["DateDepart"].DateTimeValue;
            NumeroImmatriculation = input["NumeroImmatriculation"].StringValue;
            NumPermisChauffeur = input["NumPermisChauffeur"].StringValue;
            CodeLieuDepart = input["CodeLieuDepart"].StringValue;
            CodeLieuArrive = input["CodeLieuArrivee"].StringValue;
            TypeOperation = input["TypeOperation"].Int32Value;
            Vehicules = new List<VehiculeDTO>();
            foreach (IJSonObject iJObject in input["Vehicules"].ArrayItems)
            {
                VehiculeDTO vehicule = new VehiculeDTO();
                vehicule.Read(iJObject);
                Vehicules.Add(vehicule);
            }
        }

        #endregion
    }
}

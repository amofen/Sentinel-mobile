using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;
using System.Collections;

namespace Sentinel_Mobile.Model.DTO
{
    class LotDTO:IJSonSerializable
    {
        public String DatePrevueArrive { get; set; }//DatePrevueArrivage
        public String DateReelleArrive { get; set; }
        public String Id { get; set; }//Numero int
        public List<VehiculeDTO> Vehicules { get; set; }


        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("DatePrevueArrive", DatePrevueArrive);
            output.WriteMember("DateReelleArrive", DateReelleArrive);
            output.WriteMember("Id",Id);
            output.WriteMember("Vehicules");
            output.WriteArrayBegin();
            foreach (VehiculeDTO vehicule in Vehicules){
                output.Write(vehicule);
            }
            output.WriteArrayEnd();
            output.WriteObjectEnd();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            DatePrevueArrive = input["DatePrevueArrive"].StringValue;
            DateReelleArrive = input["DateReelleArrive"].StringValue;
            Id = input["Id"].StringValue;
            IEnumerable<IJSonObject> vehi = (IEnumerable<IJSonObject>)input["Vehicules"].ArrayItems;
            Vehicules = new List<VehiculeDTO>();
            foreach (IJSonObject item in vehi)
            {
                VehiculeDTO vehiculeDTO = new VehiculeDTO();
                JSonReader reader = new JSonReader();
                vehiculeDTO.Read(item);
                Vehicules.Add(vehiculeDTO);
            }
        }

        #endregion
    }
}

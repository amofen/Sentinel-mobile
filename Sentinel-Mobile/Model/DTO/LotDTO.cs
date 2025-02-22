﻿using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;
using System.Collections;

namespace Sentinel_Mobile.Model.DTO
{
    class LotDTO:IJSonSerializable
    {
        public int Numero { get; set; }//Numero int
        public List<VehiculeDTO> Vehicules { get; set; }


        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("Numero",Numero);
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
            Numero = input["Numero"].Int32Value;
            IEnumerable<IJSonObject> vehi = (IEnumerable<IJSonObject>)input["Vehicules"].ArrayItems;
            Vehicules = new List<VehiculeDTO>();
            foreach (IJSonObject item in vehi)
            {
                VehiculeDTO vehiculeDTO = new VehiculeDTO();
                vehiculeDTO.Read(item);
                Vehicules.Add(vehiculeDTO);
            }
        }

        #endregion

    }
}

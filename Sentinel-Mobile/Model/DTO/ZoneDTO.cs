using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class ZoneDTO:IJSonSerializable
    {
        public String Nom { get; set; }
        public String Code { get; set; }
        public bool Libre { get; set; }
        public int NbrMaxPlateforme { get; set; }
        public List<PlateformeDTO> Plateformes { get; set; }


        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Nom = input["Nom"].StringValue;
            Code = input["Code"].StringValue;
            Libre = input["Libre"].BooleanValue;
            NbrMaxPlateforme = input["NbrMaxPlateformes"].Int32Value;
            Plateformes = new List<PlateformeDTO>();
            foreach (IJSonObject iJSonObject in input["Plateformes"].ArrayItems)
            {
                PlateformeDTO plateformeDTO = new PlateformeDTO();
                plateformeDTO.Read(iJSonObject);
                Plateformes.Add(plateformeDTO);
            }
        }

        #endregion
    }
}

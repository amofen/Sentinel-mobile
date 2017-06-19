using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class ParcDTO : IJSonSerializable
    {
        public String Nom { get; set; }
        public String Code { get; set; }
        public List<ZoneDTO> Zones { get; set; }


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
            Zones = new List<ZoneDTO>();
            foreach (IJSonObject iZoneObject in input["Zones"].ArrayItems)
            {
                ZoneDTO zoneDTO = new ZoneDTO();
                zoneDTO.Read(iZoneObject);
                Zones.Add(zoneDTO);
            }
        }

        #endregion
    }
}

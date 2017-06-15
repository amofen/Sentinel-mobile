using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class ArrivageDTO:IJSonSerializable
    {
        public long Code { get; set; }
        public DateTime Date { get; set; }
        public List<LotDTO> lots { get; set; }
        public String Source { get; set; }
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
            Date = input["DatePrevueArrivage"].DateTimeValue;
            Source = input["CodePort"].StringValue;
            lots = new List<LotDTO>();
            foreach(IJSonObject jobject in input["Lots"].ArrayItems)
            {
                LotDTO lotDTO = new LotDTO();
                lotDTO.Read(jobject);
                lots.Add(lotDTO);
            }
        }

        #endregion
    }
}

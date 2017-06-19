using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;

namespace Sentinel_Mobile.Model.DTO
{
    class OperationTransportDTO:IJSonSerializable
    {
        public DateTime DateDepart { get; set; }
        public int TypeOperation { get; set; }
        public String NumeroImmatriculation { get; set; }
        public String NumPermisChauffeur { get; set; }
        public String CodeLieuDepart { get; set; }
        public String CodeLieuArrivee { get; set; }
        public List<DestinationVehiculeDTO> DestinationsVehicules { get; set; }



        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            output.WriteObjectBegin();
            output.WriteMember("DateDepart",DateDepart);
            output.WriteMember("TypeOperation",TypeOperation);
            output.WriteMember("NumeroImmatriculation",NumeroImmatriculation);
            output.WriteMember("NumPermisChauffeur",NumPermisChauffeur);
            output.WriteMember("CodeLieuDepart",CodeLieuDepart);
            output.WriteMember("CodeLieuArrivee",CodeLieuArrivee);
            output.WriteMember("DestinationsVehicules");
            output.WriteArrayBegin();
            foreach (DestinationVehiculeDTO destinationDTO in DestinationsVehicules)
            {
                output.Write(destinationDTO);
            }
            output.WriteArrayEnd();
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

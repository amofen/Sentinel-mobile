using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Model.DTO
{
    class OpTransportReceptionneeDTO
    {
        public long Code { get; set; }
        public DateTime DateDepart { get; set; }
        public String NumeroImmatriculation { get; set; }
        public String NumPermisChauffeur { get; set; }
        public String CodeLieuDepart { get; set; }
        public String CodeLieuArrive { get; set; }
        public List<VehiculeDTO> Vehicules { get; set; }
    }
}

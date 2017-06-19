using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class OperationTransport
    {
        public String Id { get; set; }
        public DateTime DateDepart { get; set; }
        public int TypeOperation { get; set; }
        public String NumeroImmatriculation { get; set; }
        public String NumPermisChauffeur { get; set; }
        public String CodeLieuDepart { get; set; }
        public String CodeLieuArrivee { get; set; }
        public List<DestinationVehiculeDTO> DestinationsVehicules { get; set; }
        public List<LigneDocumentTransport> Lignes { get; set; }


        public static int TRANSIT = 0;
        public static int TRANSFERT = 1;
        public static int LIVRAISON = 2;
    }
}

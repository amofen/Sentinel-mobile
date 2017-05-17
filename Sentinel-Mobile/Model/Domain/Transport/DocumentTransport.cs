using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Transport
{
    class DocumentTransport
    {
        public String Id { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateArrive { get; set; }
        public PointLivrable LieuDepart { get; set; }
        public PointLivrable LieuArrive { get; set; }
        public Chauffeur Chauffeur { get; set; }
        public Camion Camion { get; set; }
        public List<LigneDocumentTransport> Lignes { get; set; }

    }
}

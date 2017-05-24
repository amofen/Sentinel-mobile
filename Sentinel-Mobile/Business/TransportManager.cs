using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
using Sentinel_Mobile.Model.Domain.Transport;

namespace Sentinel_Mobile.Business
{
    class TransportManager
    {

        internal List<string> getTransporteurs()
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getNomsTransporteurs();
        }

        internal List<Camion> getCamionsByTransporteur(string transporteur)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getListCamionsByTransporteur(transporteur);
        }

        internal List<Chauffeur> getListChauffeurByTransporteur(String transporteur)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getListChauffeursByTransporteur(transporteur);
        }
    }
}

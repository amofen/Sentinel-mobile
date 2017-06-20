using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Data.Synchronisation;

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

        internal void sauvegarderChauffeurs(List<Chauffeur> listChauffeurs)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            foreach (Chauffeur chauffeur in listChauffeurs)
            {
                dao.sauvegarderChauffeur(chauffeur);
            }
        }

        internal void sauvegarderCamions(List<Camion> listCamions)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            foreach (Camion camion in listCamions)
            {
                dao.sauvegarderCamion(camion);
            }
        }

        internal List<Camion> getCamions()
        {
           TransportService service = new TransportService();
           return service.getCmions();
        }

        internal List<Chauffeur> getChauffeurs()
        {
            TransportService service = new TransportService();
            return service.getChauffeurs();
        }

        internal Chauffeur getChauffeurByCode(string codeScanne)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getChauffeurByCode(codeScanne);
        }

        internal Camion getCamionByCode(string codeScanne)
        {
            throw new NotImplementedException();
        }
    }
}

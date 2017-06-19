using System;
using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Transport;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    interface TransporteurDAO
    {
        //Méthodes qui concernet les camions
        Camion findCamionById(String id);
        void sauvegarderCamion(Camion camion);
        void setCamionDisponible(Boolean disponible);
        List<Camion> getListCamionsByTransporteur(String transporteur);

        //Méthodes qui concerne les transporteurs
        List<String> getNomsTransporteurs();

        //Méthodes qui concerne les chauffeurs
        List<Chauffeur> getListChauffeursByTransporteur(String transporteur);
        void sauvegarderChauffeur(Chauffeur chauffeur);
    }
}

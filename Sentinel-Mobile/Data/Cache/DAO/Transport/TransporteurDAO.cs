﻿using System;
using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Model.DTO;

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

        Chauffeur getChauffeurByCode(string codeScanne);



        void sauvegarderOperation(OperationTransport operationTransport);
        List<OperationTransport> getOperationBySyncEtat(int syn);


        void setOperationEtatSync(OperationTransport opTransport, int p);

        void sauvegarderOperation(OpTransportReceptionneeDTO operationTransport);


        int getNombreVehiculeByOperationReceptionne(long code);
        int getNombreVehiculeByOperation(int idOperation);

        List<OpTransportReceptionneeDTO> getOperationRecepByEtats(int syn, int val);
        OpTransportReceptionneeDTO getOperationRecepByCode(long code);

        void setVehiculeReceptionne(string p);
        void validerOperationReceptionne(string p);
        void setOperationReceptionneSynchronise(long p);

        bool isVehiculeReceptionne(string p);

        void validerReception(long p);
    }
}

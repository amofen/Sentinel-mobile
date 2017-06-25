using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Business
{
    class ChargementManager
    {
        public bool vehiculeCharge(String vin)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            return dao.vehiculeCharge(vin);
        }

        public List<PointLivrable> getListPointLivreableByType(int type)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            return dao.getListPointLivrableByType(type);
        }


        internal PointLivrable getListPointLivreableById(String code)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            return dao.getListPointLivrableById(code);
        }

        public List<PointLivrable> getPtLivrables()
        {
            LocalisationService ptLivrableService = new LocalisationService();
            return ptLivrableService.getListPtLivrables();
        }

        public void sauvegarderPtLivrables(List<PointLivrable> pointsLivrable)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            foreach (PointLivrable ptLivrable in pointsLivrable)
            {
                if(!dao.ptLivrableExiste(ptLivrable))
                dao.sauvegarderPtLivrable(ptLivrable);
            }
        }


        internal void validerChargement(OperationTransport operationTransport)
        {

            TransporteurDAO dao = new TransporteurDAOImpl();
            dao.sauvegarderOperation(operationTransport);
        }

        public void getRemoteOperationReceptionnee(string codeDestination)
        {
            TransportService tranService = new TransportService();
            List<OpTransportReceptionneeDTO> listOpReceptionne = tranService.getOperationsReceptionnee(codeDestination);
            TransporteurDAO dao = new TransporteurDAOImpl();
            foreach (OpTransportReceptionneeDTO op in listOpReceptionne)
            {
                try
                {

                    dao.sauvegarderOperation(op);
                }
                catch { }
            }
        }

        public List<OpTransportReceptionneeDTO> getOperationReceptionnePrRecept()
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return  dao.getOperationRecepByEtats(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE, 0);
        }

        public List<OpTransportReceptionneeDTO> getOperationReceptionnePrSync()
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getOperationRecepByEtats(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE, 1);
        }

        public List<OperationTransport> getOperationTransport()
        {
            TransporteurDAO dao = new TransporteurDAOImpl();

            List<OperationTransport> operationsTransport = new List<OperationTransport>();
            List<OperationTransport> operationsTransportSync = dao.getOperationBySyncEtat(SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
            if (operationsTransportSync != null) operationsTransport.AddRange(operationsTransportSync);
            List<OperationTransport> operationsTransportNonSync = dao.getOperationBySyncEtat(SynchronisationService.SynchronisationParams.SYNCHRONISE);
            if(operationsTransportNonSync!=null) operationsTransport.AddRange(operationsTransportNonSync);
            return operationsTransport;
        }

        public OpTransportReceptionneeDTO getOperationReceptByCode(long code)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.getOperationRecepByCode(code);
        }

        internal void setVehiculeReceptionne(string p)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            dao.setVehiculeReceptionne(p);

        }

        internal bool isVehiculeReceptionne(string p)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            return dao.isVehiculeReceptionne(p);
        }

        internal void validerReception(long p)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            dao.validerReception(p);
        }

        public void setOperationTransportSync(long code)
        {
            TransporteurDAO dao = new TransporteurDAOImpl();
            dao.setOperationReceptionneSynchronise(code);
        }
    }
}


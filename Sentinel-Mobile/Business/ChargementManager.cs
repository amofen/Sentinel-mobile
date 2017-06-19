using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Data.Synchronisation;

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

        public void validerChargement(OperationTransport documentTransport)
        {
            
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

    }
}

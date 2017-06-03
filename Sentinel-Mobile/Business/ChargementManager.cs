using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Transport;

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

        public void validerChargement(DocumentTransport documentTransport)
        {
            
        }

        internal PointLivrable getListPointLivreableById(int id)
        {
            ChargementDAO dao = new ChargementDAOImpl();
            return dao.getListPointLivrableById(id);
        }
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Data.Cache.DAO.Localisation;

namespace Sentinel_Mobile.Business
{
    class LocalisationManager
    {
        public List<Zone> getZonesBySite(String site)
        {
            LocalisationDAO dao = new LocalisationDAOImpl();
            return dao.getZonesBySite(site);
        }

        public List<Plateforme> getPlateformesByZone(String zone)
        {
            LocalisationDAO dao = new LocalisationDAOImpl();
            return dao.getPlateformesByZone(zone);
        }

        public List<Range> getRangesByZonePlateforme(String zone,String plateforme)
        {
            LocalisationDAO dao = new LocalisationDAOImpl();
            return dao.getRangesByZonePlateforme(zone,plateforme);
        }
    }
}

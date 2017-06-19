using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Data.Cache.DAO.Localisation;
using Sentinel_Mobile.Data.Synchronisation;

namespace Sentinel_Mobile.Business
{
    class LocalisationManager
    {
        public List<Zone> getZonesByParc(String site)
        {
            LocalisationDAO dao = new LocalisationDAOImpl();
            return dao.getZonesByParc(site);
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

        public List<Zone> getListeZones()
        {
            LocalisationService ptLivrableService = new LocalisationService();
            return ptLivrableService.getListZones();
        }



        internal void validerPositionnement(List<Positionnement> positionnements)
        {
            
        }

        internal void validerPositionnement(Dictionary<string, Positionnement>.ValueCollection valueCollection)
        {
            LocalisationDAO dao = new LocalisationDAOImpl();
            foreach (Positionnement postitionnement in valueCollection)
            {
                try
                {
                    dao.enregistrerPositionnement(postitionnement, SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                }
                catch
                {
                }
                
            }
        }
    }
}

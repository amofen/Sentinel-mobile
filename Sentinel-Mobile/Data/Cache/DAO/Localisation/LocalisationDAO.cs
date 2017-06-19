using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Localisation;

namespace Sentinel_Mobile.Data.Cache.DAO.Localisation
{
    interface LocalisationDAO
    {
        List<Zone> getZonesByParc(String site);

        List<Plateforme> getPlateformesByZone(String zone);

        List<Range> getRangesByZonePlateforme(String Zone,String plateforme);

        void sauvegarderZone(Zone zone);

         void enregistrerPositionnement(Positionnement positionnement, int synchronisation);

         List<Positionnement> getPositionnementsByEtatSync(int etat); 
        
        void setPositionnementEtatSynchonise(String vin, int etat);
    }
}

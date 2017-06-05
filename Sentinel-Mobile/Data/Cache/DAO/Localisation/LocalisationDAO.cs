using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Localisation;

namespace Sentinel_Mobile.Data.Cache.DAO.Localisation
{
    interface LocalisationDAO
    {
        List<Zone> getZonesBySite(String site);

        List<Plateforme> getPlateformesByZone(String zone);

        List<Range> getRangesByZonePlateforme(String Zone,String plateforme);
    }
}

using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    interface AnomalieDAO
    {
        void sauvegarderAnomalie(Anomalie anomalie);
        List<String> getAnomalies();


        List<Anomalie> getAnomaliesByType(int type);

        int getTypeAnomalieByCode(String codeAnomalie);

    }
}

using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Cache.DAO.Application
{
    interface ParametreDAO
    {
        void setParametre(String nomParam, String valParam);
        String getValeurParametre(String nomParam);
         void deleteParametre(string nomParam);
          void deleteCache();
          void viderScanArrivage();

       void viderOperationTransport();


       void viderDeclarationAnomalies();
    }
}

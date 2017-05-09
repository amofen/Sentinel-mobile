using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Cache.DAO.Application
{
    interface ParametreDAO
    {
        void setParametre(String nomParam, String valParam);
        String getValeurParametre(String nomParam);
    }
}

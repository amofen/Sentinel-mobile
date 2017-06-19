using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Cache.DAO.Application;

namespace Sentinel_Mobile.Business
{
    class ApplicationManager
    {
        public String getParametre(String nomParam)
        {
            ParametreDAO dao = new ParametreDAOImpl();
            return dao.getValeurParametre(nomParam);
        }

        public void setParametre(String nomParam,String valeurParam)
        {
            ParametreDAO dao = new ParametreDAOImpl();
            dao.setParametre(nomParam, valeurParam);
        }
    }
}

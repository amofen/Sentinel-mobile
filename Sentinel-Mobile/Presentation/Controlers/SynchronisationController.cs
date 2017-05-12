using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Business;
using System.Threading;
using Sentinel_Mobile.Data.Config;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class SynchronisationController
    {
        private SynchronisationManager syncManager = null;
        public SynchronisationController()
        {
            this.syncManager = new SynchronisationManager();
        }


        //Cette méthode doit être lancée dans un thread à part
         public void syncScans()
        {
            while (true)
            {
                syncManager.syncScanArrivage();
                Thread.Sleep(UtilisateurCache.Params.SYNC_INTERVALLE);
            }
        }
    }
}

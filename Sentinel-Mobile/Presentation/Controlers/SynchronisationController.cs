using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Business;
using System.Threading;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.Util;

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
         public void lancerSyncRoutines()
        {
            while (true)
            {
                syncManager.syncScanRoutine();
                syncManager.syncDeclarationAnomaliesRoutine();
                Thread.Sleep(UtilisateurCache.Params.SYNC_INTERVALLE);
            }
        }

        public  void testerConnexion()
        {
            while(true)
            ConnectionTester.test();
        }
    }
}

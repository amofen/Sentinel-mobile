using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Business;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using Sentinel_Mobile.Data.Util;
using System.Threading;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class InitController
    {
        private SynchronisationController syncController = null;
        public InitController()
        {
            this.syncController = new SynchronisationController();
        }

        public void demarrerApplication()
        {
            initSynchroThreads();            
            Application.Run(new FEN_Principale());
        }
        private  void initSynchroThreads()
        {
            Thread thread = new Thread(new ThreadStart(this.syncController.syncScans));
            thread.IsBackground = true;
            thread.Start();
        }
        public void initLots()
        {
            
            LotManager lotManager = new LotManager();
            List<Lot> listLot = lotManager.getLotsPrevu(null);
            try
            {
                lotManager.saveLots(listLot);
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);   
            }
         
        }

        public int getNombreVehiculesArrivage()
        {
            LotManager lotManager = new LotManager();
            List<Lot> lots = lotManager.getCacheLots();
            VehiculeManager vehiculeManager = new VehiculeManager();
            int cumulVehicules = 0;
            foreach (Lot lot in lots)
            {
                cumulVehicules += vehiculeManager.getNombreVehiculeLot(lot.Id);
            }
            return cumulVehicules;
        }
        public void initApplicationCache()
        {
            //TODO: Ici je dois initialiser le Cache (Utilisateur,Informations)

            //Initialisation Utilisateur
            Sentinel_Mobile.Data.Config.UtilisateurCache.Type = Utilisateur.AGENT_PORT;
            Sentinel_Mobile.Data.Config.UtilisateurCache.Port = "MOSTA";

            //Initialisation Lots
            if (ConnectionTester.test())
            {
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Lots");
                //initController.initLots();
                SplashManager.CloseSplashScreen();
            }
        }
    }
}

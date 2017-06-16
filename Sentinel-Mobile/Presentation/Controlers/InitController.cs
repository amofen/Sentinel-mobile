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
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class InitController
    {
        private SynchronisationController syncController = null;
        public InitController()
        {
            this.syncController = new SynchronisationController();
        }
        public void initConnexion()
        {
            SplashManager.ShowSplashScreen("Initialisation de la connexion");
            ConnectionTester.test();
            SplashManager.CloseSplashScreen();
        }

        public void demarrerApplication()
        {
            initConnexion();
            initConnectionTestThreads();
           // initApplicationCache();
            initSynchroThreads();
            Application.Run(new FEN_Principale());
        }
        private  void initSynchroThreads()
        {
            Thread thread = new Thread(new ThreadStart(this.syncController.lancerSyncRoutines));
            thread.IsBackground = true;
            thread.Start();
        }

        public void initConnectionTestThreads()
        {
            Thread thread = new Thread(new ThreadStart(this.syncController.testerConnexion));
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

        public void initPtLivrables()
        {

            ChargementManager chrManager = new ChargementManager();
            List<PointLivrable> listPtLivrable = chrManager.getPtLivrables();
            try
            {
                if(listPtLivrable!=null) chrManager.sauvegarderPtLivrables(listPtLivrable);
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


        public void initArrivages()
        {
            LotManager lotManager = new LotManager();
            List<Arrivage> listArrivage = lotManager.getArrivagePrevue();
            try
            {
                lotManager.saveArrivages(listArrivage);
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);
            }
        }


        public void initAnomalie()
        {
            AnomalieManager anomalieManager = new AnomalieManager();
            List<Anomalie> listAvaries = anomalieManager.getListAvaries();
            List<Anomalie> listManques = anomalieManager.getListObjetsManquants();
            try
            {
                anomalieManager.enregistrerAnomalies(listAvaries);
                anomalieManager.enregistrerAnomalies(listManques);
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);
            }
        }


        public void initApplicationCache()
        {
            //TODO: Ici je dois initialiser le Cache (Utilisateur,Informations)

            //Initialisation Utilisateur
            Sentinel_Mobile.Data.Config.UtilisateurCache.Type = Utilisateur.AGENT_PORT;
            Sentinel_Mobile.Data.Config.UtilisateurCache.Port = "MOSTA";

            if (ConnectionTester.IS_CONNECTED)
            {
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Pt Livrables");
                initPtLivrables();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Arrivages");
                initArrivages();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                InitController initController = new InitController();
                SplashManager.ShowSplashScreen("Chargement Codes Avaries");
                initAnomalie();
                SplashManager.CloseSplashScreen();
            }


        }
    }
}

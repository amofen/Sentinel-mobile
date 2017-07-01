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
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Data.Cache.DAO.Localisation;
using Sentinel_Mobile.Data.Cache.DAO.Application;

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
            ApplicationManager appManager = new ApplicationManager();
            String host = appManager.getParametre(UtilisateurCache.Params.HOST);
            String port = appManager.getParametre(UtilisateurCache.Params.PORT_NUMBER);
            if (host != null && port != null)
            {
                ConnexionParam.SERVER_IP = host;
                ConnexionParam.SERVER_PORT = Int32.Parse(port);
            }
            ConnectionTester.test();
            SplashManager.CloseSplashScreen();
        }

        public void demarrerApplication()
        {



        }

        public void initTransport()
        {
            TransportManager tsManager = new TransportManager();
            List<Camion> listCamions = tsManager.getCamions();
            List<Chauffeur> listChauffeurs = tsManager.getChauffeurs();
            if (listCamions.Count > 0 && listChauffeurs.Count > 0)
            {
                tsManager.sauvegarderChauffeurs(listChauffeurs);
                tsManager.sauvegarderCamions(listCamions);
            }
        }


        public void initSynchroThreads()
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
                if (listPtLivrable != null) chrManager.sauvegarderPtLivrables(listPtLivrable);
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
            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Arrivages");
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
                SplashManager.CloseSplashScreen();
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
            if (ConnectionTester.IS_CONNECTED)
            {
                ParametreDAOImpl dao = new ParametreDAOImpl();
                dao.deleteCache();
                SplashManager.ShowSplashScreen("Chargement Pt Livrables");
                
                initPtLivrables();

                SplashManager.CloseSplashScreen();
            }



            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Inf Avaries");
                initAnomalie();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Inf Trans");
                initTransport();
                SplashManager.CloseSplashScreen();
            }

            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Inf Parcs");
                initZones();
                SplashManager.CloseSplashScreen();
            }


        }

        private void initZones()
        {
            LocalisationManager locaManager = new LocalisationManager();
            List<Zone> zones = locaManager.getListeZones();
            LocalisationDAO dao = new LocalisationDAOImpl();
            foreach (Zone zone in zones)
            {
                dao.sauvegarderZone(zone);
            }
        }
    }
}

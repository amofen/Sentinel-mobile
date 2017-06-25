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
            initUtilisateur();
            //initApplicationCache();
            initSynchroThreads();
            Application.Run(new FEN_Principale());
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

        private bool initUtilisateur()
        {
            ApplicationManager appManager = new ApplicationManager();
            try
            {
                if (appManager.getParametre(UtilisateurCache.Params.NOM_UTILISATEUR) == null)
                {
                    FEN_Connexion fen_cnx = new FEN_Connexion();
                    while (fen_cnx.ShowDialog() != DialogResult.Yes)
                    {

                    }
                    return true;
                }
                else
                {
                    UtilisateurCache.CurrentUserName = appManager.getParametre(UtilisateurCache.Params.NOM_UTILISATEUR);
                    UtilisateurCache.CurrentUserPassword = appManager.getParametre(UtilisateurCache.Params.MOT_PASSE_UTILISATEUR);
                    UtilisateurCache.CurrentUserCookie = appManager.getParametre(UtilisateurCache.Params.COOKIE_SESSION);
                    return true;

                }
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        private void initSynchroThreads()
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
            initUtilisateur();

            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Pt Livrables");
                initPtLivrables();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Arrivages");
                initArrivages();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement Codes Avaries");
                initAnomalie();
                SplashManager.CloseSplashScreen();
            }
            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement transport");
                initTransport();
                SplashManager.CloseSplashScreen();
            }

            if (ConnectionTester.IS_CONNECTED)
            {
                SplashManager.ShowSplashScreen("Chargement zones");
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

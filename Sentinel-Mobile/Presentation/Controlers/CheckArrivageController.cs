using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Controlers
{
    class CheckArrivageController
    {
        private FEN_Check_Arri fenCheckArrivage;
        private LotManager lotManager;
        private VehiculeManager vehiculeManager;
        public CheckArrivageController(FEN_Check_Arri fenCheckArrivage)
        {
            this.fenCheckArrivage = fenCheckArrivage;
            this.lotManager = new LotManager();
            this.vehiculeManager = new VehiculeManager();
        }

        
        public void traiterCodeScanner(String codeScane)
        {
            Vehicule vehicule = null;
            try
            {
                vehicule = vehiculeManager.getVehiculeByVin(codeScane);
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);
            }
            if (vehicule != null)
            {
                //TODO: BIP + Afficher Vehicule
                fenCheckArrivage.Vin = vehicule.Vin;
                fenCheckArrivage.Modele= vehicule.Model;
                fenCheckArrivage.NumLot = vehicule.Lot;
                fenCheckArrivage.updatePanView();
                fenCheckArrivage.setScanSuccess();
                if (this.vehiculeManager.scannerVehicule(vehicule.Vin,Vehicule.PORT))
                {
                    fenCheckArrivage.incNbScansVehicules();
                }
                else
                {
                    if (this.vehiculeManager.vehiculeAvecAnomalie(vehicule.Vin))
                    {
                        fenCheckArrivage.setScanWarnning();
                    }
                }
            }
            else 
            {
                fenCheckArrivage.setScanEchec();
                fenCheckArrivage.resetView();
                fenCheckArrivage.Vin = codeScane;
                fenCheckArrivage.updatePanView();
            }
        }

        public void declarerAvarie()
        {

        }


        public void initDonneesArrivage()
        {
            //Initialiser les informations nécessiares
            LotManager lotManager = new LotManager();
            List<Lot> lots = lotManager.getCacheLots();
            VehiculeManager vehiculeManager = new VehiculeManager();
            int cumulVehicules = 0;
            foreach (Lot lot in lots)
            {
                cumulVehicules += vehiculeManager.getNombreVehiculeLot(lot.Id);
                fenCheckArrivage.DateArrivage = lot.DatePrevueArrive.ToString();
                fenCheckArrivage.Port = UtilisateurCache.Port;
            }
            fenCheckArrivage.TotalVehicules = cumulVehicules;

            //Vérifier l'existance d'un arrivage non valider en cours
            fenCheckArrivage.Etape = Vehicule.TRANSPORT_MARITIME;
            fenCheckArrivage.NbScans = vehiculeManager.getNombreVehiculeEnCoursScanne();
            fenCheckArrivage.updateArrivageView();
        }

    }
}

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
                fenCheckArrivage.vin = vehicule.Vin;
                fenCheckArrivage.modele= vehicule.Model;
                fenCheckArrivage.numLot = vehicule.Lot;
                fenCheckArrivage.updatePanView();
                if (this.vehiculeManager.scannerVehicule(vehicule.Vin))
                {
                    fenCheckArrivage.incNbScansVehicules();
                }
            }
            else 
            {
                fenCheckArrivage.setScanEchec();
                fenCheckArrivage.resetView();
                fenCheckArrivage.vin = codeScane;
                fenCheckArrivage.updatePanView();
            }
        }

        public void declarerAvarie()
        {

        }


        public void initNombreVehiculesArrivage()
        {
            LotManager lotManager = new LotManager();
            List<Lot> lots = lotManager.getCacheLots();
            VehiculeManager vehiculeManager = new VehiculeManager();
            int cumulVehicules = 0;
            foreach (Lot lot in lots)
            {
                cumulVehicules += vehiculeManager.getNombreVehiculeLot(lot.Id);
            }
            fenCheckArrivage.totalVehicules = cumulVehicules;
            fenCheckArrivage.updateArrivageView();
        }

    }
}

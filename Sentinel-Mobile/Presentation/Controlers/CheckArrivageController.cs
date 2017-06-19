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
using Sentinel_Mobile.Presentation.UIComponents.Sound;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using System.Windows.Forms;

namespace Sentinel_Mobile.Controlers
{
    class CheckArrivageController
    {
        private FEN_Check_Arri fenCheckArrivage;
        private LotManager lotManager;
        private VehiculeManager vehiculeManager;
        private ChargementManager charManager;
        public CheckArrivageController(FEN_Check_Arri fenCheckArrivage)
        {
            this.fenCheckArrivage = fenCheckArrivage;
            this.lotManager = new LotManager();
            this.vehiculeManager = new VehiculeManager();
            this.charManager = new ChargementManager();
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
                fenCheckArrivage.Modele = vehicule.Model;
                fenCheckArrivage.updatePanView();
                if (vehicule.Lot==fenCheckArrivage.NumLot)
                {
                    fenCheckArrivage.setScanSuccess();
                    SoundManager.PlaySoundSuccess();
                   
                    if (this.vehiculeManager.scannerVehicule(vehicule.Vin, Vehicule.PORT,fenCheckArrivage.CodePort))
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
                    SoundManager.PlaySoundError();
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


        public void initDonneesArrivage(Lot lot, Arrivage arrivage,PointLivrable ptLivrable)
        {
            //Initialiser les informations nécessiares
            VehiculeManager vehiculeManager = new VehiculeManager();
            fenCheckArrivage.DateArrivage = arrivage.Date.ToShortDateString(); ;
            fenCheckArrivage.Port = arrivage.Source.Designation;
            fenCheckArrivage.CodePort = ptLivrable.Code;
            fenCheckArrivage.NumLot = lot.Id;
            fenCheckArrivage.TotalVehicules = lot.vehicules.Count;
            fenCheckArrivage.NbScans = vehiculeManager.getNombreVehiculeEnCoursScanne();
            fenCheckArrivage.updateArrivageView();
        }
        public void validerAnomalies()
        {
            VehiculeManager vehiculeManager = new VehiculeManager();
            List<Vehicule> vehicules = vehiculeManager.getVehiculesByLotId(fenCheckArrivage.NumLot);
            AnomalieManager anomalieManager = new AnomalieManager();
            foreach (Vehicule vehicule in vehicules)
            {
                if (anomalieManager.vehiculeAvecAnomalie(vehicule.Vin))
                {
                    anomalieManager.setAnomalieVehiculeValidee(vehicule.Vin);
                }
            }
        }


    }
}

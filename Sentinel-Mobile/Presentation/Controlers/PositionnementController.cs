using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Presentation.UIComponents.Sound;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class PositionnementController
    {
        private FEN_Positionnement fen_positionnement;
        private LocalisationManager locaManager;
        private VehiculeManager vehiculeManager;

        public PositionnementController(FEN_Positionnement fen_positionnement)
        {
            this.fen_positionnement = fen_positionnement;
            this.locaManager = new LocalisationManager();
            this.vehiculeManager = new VehiculeManager();
        }

        public void initCbx()
        {
            updateCbxZone();
            updateCbxPlateforme();
            updateCbxRange();
        }

        public void updateCbxZone()
        {
            fen_positionnement.Cbx_Zone.Items.Clear();
            fen_positionnement.Cbx_Zone.Items.Add("<--Zone-->");
            fen_positionnement.Cbx_Zone.SelectedIndex = 0;
            List<Zone> zones = locaManager.getZonesByParc(UtilisateurCache.Affectation.Code);
            if (zones != null)
            {
                foreach (Zone zone in zones)
                {
                    fen_positionnement.Cbx_Zone.Items.Add(zone);
                }
            }
        }

        public void updateCbxPlateforme()
        {
            fen_positionnement.Cbx_Plateforme.Items.Clear();
            fen_positionnement.Cbx_Plateforme.Items.Add("<--Plateforme-->");
            fen_positionnement.Cbx_Plateforme.SelectedIndex = 0;
            if (fen_positionnement.Cbx_Zone.SelectedIndex != 0)
            {
                Zone zone = (Zone)fen_positionnement.Cbx_Zone.SelectedItem;
                List<Plateforme> listePlateformes = locaManager.getPlateformesByZone(zone.Code);
                if (listePlateformes != null)
                {
                    foreach (Plateforme plateforme in listePlateformes)
                    {
                        fen_positionnement.Cbx_Plateforme.Items.Add(plateforme);
                    }
                }
            }
        }

        public void updateCbxRange()
        {
            fen_positionnement.Cbx_Range.Items.Clear();
            fen_positionnement.Cbx_Range.Items.Add("<Range>");
            fen_positionnement.Cbx_Range.SelectedIndex = 0;
            fen_positionnement.Nmrc_numPlace.Maximum = 0;
            if ((fen_positionnement.Cbx_Plateforme.SelectedIndex != 0) &&
                (fen_positionnement.Cbx_Zone.SelectedIndex != 0))
            {
                Zone zone = (Zone)fen_positionnement.Cbx_Zone.SelectedItem;
                Plateforme plateforme = (Plateforme)fen_positionnement.Cbx_Plateforme.SelectedItem;
                List<Range> listRange = locaManager.getRangesByZonePlateforme(zone.Code, plateforme.Code);
                if (listRange != null)
                {
                    foreach (Range range in listRange)
                    {
                        fen_positionnement.Cbx_Range.Items.Add(range);
                    }
                }
            }
        }


        public void updateNmrcNumPlace()
        {
            Range range = (Range)fen_positionnement.Cbx_Range.SelectedItem;
            fen_positionnement.Nmrc_numPlace.Maximum = range.NbrMaxPlaces;
        }

        public void traiterCodeScanner(String codeScane)
        {

            if (fen_positionnement.Vin != codeScane)
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
                    fen_positionnement.Vin = vehicule.Vin;
                    fen_positionnement.Modele = vehicule.Model;
                    fen_positionnement.NumLot = vehicule.Lot;
                    fen_positionnement.updatePanView();
                    fen_positionnement.setScanSuccess();
                    //TODO: à revoir pour la récupération du parc
                }
                else
                {
                    fen_positionnement.setScanEchec();
                    fen_positionnement.resetView();
                    fen_positionnement.Vin = codeScane;
                    fen_positionnement.updatePanView();
                    
                }
                fen_positionnement.desactiverDeclarationAnomalies();
            }


        }

        public void positionnerVehicule(String vin)
        {
            if (vin != null)
            {
                Positionnement place = new Positionnement();
                place.Veicule = vehiculeManager.getVehiculeByVin(vin);
                place.CodeParc = UtilisateurCache.Affectation.Code;
                place.Rangee = ((Range)fen_positionnement.Cbx_Range.SelectedItem).Code;
                place.Plateforme = ((Plateforme)fen_positionnement.Cbx_Plateforme.SelectedItem).Code;
                place.Zone = ((Zone)fen_positionnement.Cbx_Zone.SelectedItem).Code;
                place.NumeroDsRangee = Convert.ToInt32(fen_positionnement.Nmrc_numPlace.Value);
                place.date = DateTime.Now;
                if (fen_positionnement.Positionnements.ContainsKey(vin)) fen_positionnement.incNbScansVehicules();
                fen_positionnement.Positionnements[vin] = place;
                fen_positionnement.Nmrc_numPlace.Value++;
                SoundManager.PlaySoundSuccess();
                fen_positionnement.activerDeclarationAnomalies();





                if (this.vehiculeManager.scannerVehicule(vin, fen_positionnement.getEtape(), UtilisateurCache.Affectation.Code))
                {
                    fen_positionnement.incNbScansVehicules();
                }
                else
                {
                    if (this.vehiculeManager.vehiculeAvecAnomalie(vin))
                    {
                        fen_positionnement.setScanWarnning();
                    }
                }

            }
            else
            {
                SoundManager.PlaySoundError();
            }

        }


        internal void validerPosionnement()
        {
            if (fen_positionnement.Positionnements.Count > 0)
            {
                
                locaManager.validerPositionnement(fen_positionnement.Positionnements.Values);
                AnomalieManager anomalieManager = new AnomalieManager();
                foreach (Positionnement positionnement in fen_positionnement.Positionnements.Values)
                {
                    if (anomalieManager.vehiculeAvecAnomalie(positionnement.Veicule.Vin))
                    {
                        anomalieManager.setAnomalieVehiculeValidee(positionnement.Veicule.Vin);
                    }
                }
            }
        }


    }
}

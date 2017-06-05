using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Model.Domain.Vehicules;

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
            List<Zone> zones = locaManager.getZonesBySite(UtilisateurCache.Affectation.Code);
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
                List<Plateforme> listePlateformes = locaManager.getPlateformesByZone(zone.Nom);
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
                List<Range> listRange = locaManager.getRangesByZonePlateforme(zone.Nom, plateforme.Nom);
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
            fen_positionnement.Nmrc_numPlace.Maximum = range.NbMaxPlaces;
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
                fen_positionnement.Vin = vehicule.Vin;
                fen_positionnement.Modele = vehicule.Model;
                fen_positionnement.NumLot = vehicule.Lot;
                fen_positionnement.updatePanView();
                fen_positionnement.setScanSuccess();
                if (this.vehiculeManager.scannerVehicule(vehicule.Vin, Vehicule.PORT))
                {
                    fen_positionnement.incNbScansVehicules();
                }
                else
                {
                    if (this.vehiculeManager.vehiculeAvecAnomalie(vehicule.Vin))
                    {
                        fen_positionnement.setScanWarnning();
                    }
                }
            }
            else
            {
                fen_positionnement.setScanEchec();
                fen_positionnement.resetView();
                fen_positionnement.Vin = codeScane;
                fen_positionnement.updatePanView();
            }
        }

    }
}

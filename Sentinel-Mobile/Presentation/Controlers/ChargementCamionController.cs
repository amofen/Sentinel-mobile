using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using iTextSharp.text;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class ChargementCamionController
    {
        private FEN_Char_Camions fen_char_camions = null;
        private TransportManager transportManager = null;
        private VehiculeManager vehiculeManager = null;
        private AnomalieManager anomalieManager = null;
        private ChargementManager chargementManager = null;
        public ChargementCamionController(FEN_Char_Camions fen_char_camions)
        {
            this.fen_char_camions = fen_char_camions;
            this.transportManager = new TransportManager();
            this.vehiculeManager = new VehiculeManager();
            this.chargementManager = new ChargementManager();
            this.anomalieManager = new AnomalieManager();
        }


        public void InitialiserChargement()
        {
            //Initialiser les transporteurs
            updateCbxTransporteur();
            updateCbxCamion();
            updateCbxChauffeur();

            //Initialiser les destinations
            updateCbxDestination();
        }

        public void updateCbxDestination()
        {
            fen_char_camions.Cbx_destination.Items.Clear();
            fen_char_camions.Cbx_destination.Items.Add("<--Choisir une destination-->");
            fen_char_camions.Cbx_destination.SelectedIndex = 0;
            //L'index 1 = PARC 2= SHOWROOM 3= Concessionnaire 4=Attelier 
            fen_char_camions.Cbx_destination.Items.Add("Parc");
            fen_char_camions.Cbx_destination.Items.Add("Show Room");
            fen_char_camions.Cbx_destination.Items.Add("Concessionnaire");
            fen_char_camions.Cbx_destination.Items.Add("Attelier");
        }
        public void updateCbxDesignation()
        {
            fen_char_camions.Cbx_designation.Items.Clear();
            fen_char_camions.Cbx_designation.Items.Add("<--Préciser la destination-->");
            fen_char_camions.Cbx_designation.SelectedIndex = 0;
            if (fen_char_camions.Cbx_destination.SelectedIndex != 0)
            {
                int type = fen_char_camions.Cbx_destination.SelectedIndex;
                List<PointLivrable> listPtLivrable = chargementManager.getListPointLivreableByType(type);
                if (listPtLivrable != null)
                {
                    foreach (PointLivrable ptLivrable in listPtLivrable)
                    {
                        fen_char_camions.Cbx_designation.Items.Add(ptLivrable);
                    }
                }
            }
        }

        public void updateCbxTransporteur()
        {
            fen_char_camions.Cbx_Transporteur.Items.Clear();
            fen_char_camions.Cbx_Transporteur.Items.Add("<--Transporteur-->");
            fen_char_camions.Cbx_Transporteur.SelectedIndex = 0;
            List<String> transporteurs = transportManager.getTransporteurs();
            if (transporteurs != null)
            {
                foreach (String transporteur in transporteurs)
                {
                    fen_char_camions.Cbx_Transporteur.Items.Add(transporteur);
                }
            }

        }
        public void updateCbxCamion()
        {
            fen_char_camions.Cbx_Camion.Items.Clear();
            fen_char_camions.Cbx_Camion.Items.Add("<--Camion-->");
            fen_char_camions.Cbx_Camion.SelectedIndex = 0;
            if (fen_char_camions.Cbx_Transporteur.SelectedIndex != 0)
            {
                String transporteur = (String)fen_char_camions.Cbx_Transporteur.SelectedItem;
                List<Camion> camions = transportManager.getCamionsByTransporteur(transporteur);
                foreach (Camion camion in camions)
                {
                    fen_char_camions.Cbx_Camion.Items.Add(camion);
                }

            }

        }
        public void updateCbxChauffeur()
        {
            fen_char_camions.Cbx_Chauffeur.Items.Clear();
            fen_char_camions.Cbx_Chauffeur.Items.Add("<--Chauffeur-->");
            fen_char_camions.Cbx_Chauffeur.SelectedIndex = 0;
            if (fen_char_camions.Cbx_Transporteur.SelectedIndex != 0)
            {
                String transporteur = (String)fen_char_camions.Cbx_Transporteur.SelectedItem;
                List<Chauffeur> chauffeurs = transportManager.getListChauffeurByTransporteur(transporteur);
                foreach (Chauffeur chauffeur in chauffeurs)
                {
                    fen_char_camions.Cbx_Chauffeur.Items.Add(chauffeur);
                }

            }
        }

        public void initialiserListVehicules()
        {

        }

        public void traiterCodeScanne(String codeScanne)
        {
            //Vin
            if ((codeScanne.Length == 17) && (fen_char_camions.nbVehiculesCharges < 8))
            {
                Vehicule vehicule = null;
                try
                {
                    vehicule = vehiculeManager.getVehiculeByVin(codeScanne);
                }
                catch (Exception e)
                {
                    MessagingService.showErrorMessage(e.Message);
                }
                if (vehicule != null)
                {
                    bool exist = false;
                    for (int j = 0; j <= fen_char_camions.PansVehicules.Length; j++)
                    {
                        if (fen_char_camions.PansVehicules[j].Vin != null)
                        {
                            if (fen_char_camions.PansVehicules[j].Vin == codeScanne)
                            {
                                exist = true;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (!exist)
                    {
                        int i = fen_char_camions.nbVehiculesCharges;
                        setVehiculePan(vehicule, i + 1);
                        fen_char_camions.nbVehiculesCharges++;
                        fen_char_camions.updateView();

                    }

                }
            }
            else
            {
                if (codeScanne.Length == 15)
                {
                    Chauffeur chauffeur = transportManager.getChauffeurByCode(codeScanne);
                    if (chauffeur != null)
                    {
                        fen_char_camions.Cbx_Chauffeur.Items.Clear();
                        fen_char_camions.Cbx_Chauffeur.Items.Add(chauffeur);
                        fen_char_camions.Cbx_Chauffeur.SelectedItem = chauffeur;
                    }
                }

                if (codeScanne.Length == 12)
                {
                    Camion camion = transportManager.getCamionByCode(codeScanne);
                    if (camion != null)
                    {
                        fen_char_camions.Cbx_Camion.Items.Clear();
                        fen_char_camions.Cbx_Camion.Items.Add(camion);
                        fen_char_camions.Cbx_Camion.SelectedItem = camion;
                    }
                }

            }


        }

        private bool vehiculeCharge(Vehicule vehicule)
        {
            if (chargementManager.vehiculeCharge(vehicule.Vin)) return true;
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    if (fen_char_camions.PansVehicules[i].Vin != null)
                    {
                        if (fen_char_camions.PansVehicules[i].Vin.Equals(vehicule.Vin)) return true;
                    }
                }
            }
            return false;

        }

        private void setVehiculePan(Vehicule vehicule, int ordre)
        {
            fen_char_camions.PansVehicules[ordre - 1].Vin = vehicule.Vin;
            fen_char_camions.PansVehicules[ordre - 1].Couleur = vehicule.Couleur;
            fen_char_camions.PansVehicules[ordre - 1].Modele = vehicule.Model;
            if (fen_char_camions.isUneSeulDestination())
            {
                fen_char_camions.PansVehicules[ordre - 1].Destination = (PointLivrable)fen_char_camions.Cbx_designation.SelectedItem;
            }
            else
            {
                //TODO Afficher une fenêtre pour selectionner la destination
            }
            fen_char_camions.PansVehicules[ordre - 1].updateView();
            fen_char_camions.PansVehicules[ordre - 1].Show();
            if (anomalieManager.vehiculeAvecAnomalie(vehicule.Vin)) fen_char_camions.PansVehicules[ordre - 1].setWarnning();
            else fen_char_camions.PansVehicules[ordre - 1].setSuccess();
        }

        public void supprimerVehicule(int ordre)
        {
            if (ordre < fen_char_camions.nbVehiculesCharges)
            {
                int i;
                for (i = ordre - 1; i < fen_char_camions.nbVehiculesCharges; i++)
                {
                    if (i == 7)
                    {
                        fen_char_camions.PansVehicules[i].Vin = null;
                        fen_char_camions.PansVehicules[i].Modele = null;
                        fen_char_camions.PansVehicules[i].Couleur = null;
                    }
                    else
                    {
                        fen_char_camions.PansVehicules[i].Vin = fen_char_camions.PansVehicules[i + 1].Vin;
                        fen_char_camions.PansVehicules[i].Modele = fen_char_camions.PansVehicules[i + 1].Modele;
                        fen_char_camions.PansVehicules[i].Couleur = fen_char_camions.PansVehicules[i + 1].Couleur;
                        if (fen_char_camions.PansVehicules[i].Vin != null)
                            if (anomalieManager.vehiculeAvecAnomalie(fen_char_camions.PansVehicules[i].Vin)) fen_char_camions.PansVehicules[i].setWarnning();
                            else fen_char_camions.PansVehicules[i].setSuccess();
                    }
                    fen_char_camions.PansVehicules[i].updateView();
                }

                fen_char_camions.cacherPanel(i);

            }
            else
            {
                fen_char_camions.PansVehicules[ordre - 1].Vin = null;
                fen_char_camions.cacherPanel(ordre);
            }
            fen_char_camions.nbVehiculesCharges--;
            fen_char_camions.updateView();
        }



        public void validerChargement()
        {
            if (verifierChargement())
            {
                OperationTransport operationTransport = new OperationTransport();
                operationTransport.DateDepart = DateTime.Now;
                operationTransport.CodeLieuDepart = UtilisateurCache.Affectation.Code;
                operationTransport.CodeLieuArrivee = ((PointLivrable)fen_char_camions.Cbx_designation.SelectedItem).Code;
                switch (fen_char_camions.Cbx_destination.SelectedIndex)
                {
                    case 1:
                        if (UtilisateurCache.Affectation.Type == PointLivrable.PORT)
                        {
                            operationTransport.TypeOperation = OperationTransport.TRANSIT;
                        }
                        else
                        {
                            operationTransport.TypeOperation = OperationTransport.TRANSFERT;
                        }
                        break;
                    case 2:
                        operationTransport.TypeOperation = OperationTransport.LIVRAISON;
                        break;
                    case 3:
                        operationTransport.TypeOperation = OperationTransport.LIVRAISON;
                        break;
                    case 4:
                        operationTransport.TypeOperation = OperationTransport.TRANSFERT;
                        break;
                    default:
                        break;
                }
                operationTransport.NumPermisChauffeur = ((Chauffeur)fen_char_camions.Cbx_Chauffeur.SelectedItem).NumeroPermis;
                operationTransport.NumeroImmatriculation = ((Camion)fen_char_camions.Cbx_Camion.SelectedItem).NumeroImmatriculation;

                List<DestinationVehicule> ListDestination = new List<DestinationVehicule>();
                int etape;
                String codePtLivrable = UtilisateurCache.Affectation.Code;

                if (operationTransport.TypeOperation == OperationTransport.TRANSIT)
                {
                    etape = Vehicule.PORT;
                }
                else
                {
                    etape = Vehicule.PARC_LIBRE;
                }
                for (int i = 0; i < fen_char_camions.PansVehicules.Length; i++)
                {
                    if (fen_char_camions.PansVehicules[i].Vin == null) break;
                    DestinationVehicule destination = new DestinationVehicule();
                    destination.Vin = fen_char_camions.PansVehicules[i].Vin;
                    destination.CodeDestination = fen_char_camions.PansVehicules[i].Destination.Code;
                    ListDestination.Add(destination);
                    VehiculeManager manager = new VehiculeManager();
                    manager.scannerVehicule(fen_char_camions.PansVehicules[i].Vin, etape, codePtLivrable);
                    AnomalieManager anomalieManager = new AnomalieManager(); 
                    if (anomalieManager.vehiculeAvecAnomalie(fen_char_camions.PansVehicules[i].Vin))
                    {
                        anomalieManager.setAnomalieVehiculeValidee(fen_char_camions.PansVehicules[i].Vin);
                    }
                }
                operationTransport.DestinationsVehicules = ListDestination;
                chargementManager.validerChargement(operationTransport);
            }
        }


        //Vérifier que tous les champs sont bien saisis avant de valider le chargement.
        public bool verifierChargement()
        {

            bool cnd1 = (fen_char_camions.Cbx_Camion.SelectedItem.GetType() == typeof(Camion)) &&
                    (fen_char_camions.Cbx_Chauffeur.SelectedItem.GetType() == typeof(Chauffeur)) &&
                    (fen_char_camions.nbVehiculesCharges > 0) &&
                    (fen_char_camions.Cbx_destination.SelectedIndex != 0);

            if (cnd1)
            {
                bool cnd2 = true;
                for (int i = 0; i < fen_char_camions.nbVehiculesCharges; i++)
                {
                    if (fen_char_camions.PansVehicules[i].Destination == null) cnd2 = false;
                }
                return cnd1 && cnd2;
            }
            else
            {
                return false;
            }
        }

        internal void updateVehiculesDestination()
        {
            foreach (PAN_Char_Cam_Vehi pan in fen_char_camions.PansVehicules)
            {
                if (pan.Vin != null)
                {
                    if (fen_char_camions.Cbx_destination.SelectedIndex != 0)
                    {
                        pan.Destination = (PointLivrable)fen_char_camions.Cbx_designation.SelectedItem;
                        pan.updateView();
                    }
                    else
                    {
                        pan.Destination = null;
                        pan.updateView();
                    }

                }
            }
        }
    }
}

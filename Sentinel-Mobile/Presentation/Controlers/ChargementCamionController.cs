﻿using System;

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
            //L'index 1 = PARC 2= SHOWROOM 3= Concessionnaire
            fen_char_camions.Cbx_destination.Items.Add("Parc");
            fen_char_camions.Cbx_destination.Items.Add("Show Room");
            fen_char_camions.Cbx_destination.Items.Add("Concessionnaire");
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
                    if (!vehiculeCharge(vehicule))
                    {
                        int i = fen_char_camions.nbVehiculesCharges;
                        setVehiculePan(vehicule, i + 1);
                        fen_char_camions.nbVehiculesCharges++;
                        fen_char_camions.updateView();
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

        public void initUtilisateur()
        {
            if (UtilisateurCache.Type == Utilisateur.AGENT_PORT)
            {
                //Agent du port
                fen_char_camions.setUneSeulDest();
                fen_char_camions.disablePlusDestinations();

            }
            else if (UtilisateurCache.Type == Utilisateur.AGENT_PAC)
            {
                //Agent Parc
            }
        }

        public void validerChargement()
        {
            if (verifierChargement())
            {
                DocumentTransport documentTransport = new DocumentTransport();
                documentTransport.Id = "";
                documentTransport.DateDepart = DateTime.Now;
                documentTransport.LieuDepart = UtilisateurCache.Affectation;
                documentTransport.LieuArrive = (PointLivrable)fen_char_camions.Cbx_designation.SelectedItem;

                documentTransport.Chauffeur = (Chauffeur)fen_char_camions.Cbx_Chauffeur.SelectedValue;
                documentTransport.Camion = (Camion)fen_char_camions.Cbx_Chauffeur.SelectedValue;

                List<LigneDocumentTransport> listeLignes = new List<LigneDocumentTransport>();
                foreach (PAN_Char_Cam_Vehi pan in fen_char_camions.PansVehicules)
                {
                    LigneDocumentTransport ligne = new LigneDocumentTransport();
                    ligne.Vin = pan.Vin;
                    ligne.Destination = pan.Destination;
                    ligne.Declarations = anomalieManager.getListAnomaliesByVin(pan.Vin);
                    ligne.Modele = pan.Modele;
                    listeLignes.Add(ligne);
                }

                chargementManager.validerChargement(documentTransport);
            }
        }


        //Vérifier que tous les champs sont bien saisis avant de valider le chargement.
        public bool verifierChargement()
        {
            return true;
        }
    }
}

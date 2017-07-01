using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Presentation.UIComponents.Barcode;
using Sentinel_Mobile.Presentation.UIComponents.Sound;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Reception : Form
    {
        OpTransportReceptionneeDTO operationReceptionne { get; set; }
        public PAN_Char_Cam_Vehi[] PansVehicules { get; set; }
        private BarcodeScanner scanner;
        private bool codeBarMode { get; set; }

        public FEN_Reception(OpTransportReceptionneeDTO operationReceptionne)
        {
            InitializeComponent();
            this.operationReceptionne = operationReceptionne;
            initListVehicules();
            scanner = new HWBarcodeScanner();
            codeBarMode = false;
        }

        private void FEN_Reception_Load(object sender, EventArgs e)
        {

            ChargementManager chrManager = new ChargementManager();
            TransportManager trsManager = new TransportManager();
            Camion camion = trsManager.getCamionByCode(operationReceptionne.NumeroImmatriculation);
            Cbx_Camion.Items.Clear();
            Cbx_Camion.Items.Add(camion);
            Cbx_Camion.SelectedIndex = 0;
            Cbx_Camion.Enabled = false;

            Cbx_Chauffeur.Items.Clear();
            Cbx_Chauffeur.Items.Add(trsManager.getChauffeurByCode(operationReceptionne.NumPermisChauffeur));
            Cbx_Chauffeur.SelectedIndex = 0;
            Cbx_Chauffeur.Enabled = false;

            Cbx_Transporteur.Items.Clear();
            Cbx_Transporteur.Items.Add(camion.Transporteur);
            Cbx_Transporteur.SelectedIndex = 0;
            Cbx_Transporteur.Enabled = false;

            int i = 0;
            foreach (VehiculeDTO vehi in operationReceptionne.Vehicules)
            {
                VehiculeManager vehiManager = new VehiculeManager();
                Vehicule vehicule = vehiManager.getVehiculeByVin(vehi.Vin);
                PansVehicules[i].Vin = vehi.Vin;
                PansVehicules[i].Modele = vehicule.Model;
                PansVehicules[i].Couleur = vehicule.Couleur;
                PansVehicules[i].Destination = UtilisateurCache.Affectation;
                switch (operationReceptionne.TypeOperation)
                {
                    case OperationTransport.TRANSIT:
                        PansVehicules[i].Etape = Vehicule.TRANSIT;
                        break;
                    case OperationTransport.TRANSFERT:
                        PansVehicules[i].Etape = Vehicule.TRANSFERT;
                        break;
                    case OperationTransport.LIVRAISON:
                        PansVehicules[i].Etape = Vehicule.LIVRAISON;
                        break;
                    default:
                        break;
                }
                ChargementManager charManager = new ChargementManager();
                if (charManager.isVehiculeReceptionne(PansVehicules[i].Vin))
                {
                    AnomalieManager anoManager = new AnomalieManager();
                    if (anoManager.vehiculeAvecAnomalie(PansVehicules[i].Vin)) PansVehicules[i].setWarnning();
                    else PansVehicules[i].setSuccess();
                    PansVehicules[i].showAnomalieBtn();
                }
                PansVehicules[i].updateView();
                PansVehicules[i].Show();

                i++;
            }
            Lbl_VehiculesARecevoir.Text = operationReceptionne.Vehicules.Count + "";
            scanner.initialise();
            scanner.activate();
            handleDecodeEvent handler = handleDecodeEventMethode;
            scanner.setScanEventHandler(handler);

        }

        private void handleDecodeEventMethode(object sender, EventArgs e)
        {
            String codeScanne = scanner.getScannResult(e);
            if (codeScanne != null)
            {
                bool found = false;
                foreach (PAN_Char_Cam_Vehi pan in PansVehicules)
                {
                    if (pan.Vin != null)
                    {
                        if (pan.Vin == codeScanne)
                        {
                            found = true;
                            AnomalieManager anoManager = new AnomalieManager();
                            pan.setSuccess();

                            if (anoManager.vehiculeAvecAnomalie(pan.Vin)) pan.setWarnning();
                            pan.showAnomalieBtn();
                            pan.Hide();
                            pan.Show();
                            ChargementManager charManager = new ChargementManager();
                            charManager.setVehiculeReceptionne(pan.Vin);
                            VehiculeManager vehiculeManager = new VehiculeManager();
                            int etape = 0;
                            switch (pan.Etape)
                            {
                                case Vehicule.TRANSIT:
                                    etape = Vehicule.PARC_SOUS_DOUANE;
                                    break;
                                case Vehicule.TRANSFERT:
                                    etape = Vehicule.PARC_LIBRE;
                                    break;
                                case Vehicule.LIVRAISON:
                                    etape = Vehicule.LIVRAISON;
                                    break;
                                default:
                                    etape = pan.Etape;
                                    break;
                            }

                            vehiculeManager.scannerVehicule(pan.Vin, etape, UtilisateurCache.Affectation.Code);

                        }
                    }
                }
                if (found)
                {
                    SoundManager.PlaySoundSuccess();
                }
                else
                {
                    SoundManager.PlaySoundError();
                }
            }

        }

        private void initListVehicules()
        {
            PansVehicules = new PAN_Char_Cam_Vehi[8];
            PansVehicules[0] = paN_Char_Cam_Vehi1;
            PansVehicules[1] = paN_Char_Cam_Vehi2;
            PansVehicules[2] = paN_Char_Cam_Vehi3;
            PansVehicules[3] = paN_Char_Cam_Vehi4;
            PansVehicules[4] = paN_Char_Cam_Vehi5;
            PansVehicules[5] = paN_Char_Cam_Vehi6;
            PansVehicules[6] = paN_Char_Cam_Vehi7;
            PansVehicules[7] = paN_Char_Cam_Vehi8;
            for (int i = 0; i < 8; i++)
            {
                PansVehicules[i].Ordre = i + 1;
                PansVehicules[i].Hide();
                PansVehicules[i].Vin = null;
                PansVehicules[i].setReceptionMode();
                PansVehicules[i].updateView();
            }
        }



        private void Cbx_Transporteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_destination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rbx_plusDest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Valider_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            bool cond = false;
            foreach (PAN_Char_Cam_Vehi pan in PansVehicules)
            {
                if (pan.BackColor != Color.Red && pan.Vin != null)
                {
                    cond = true;
                }

            }
            if (!cond)
            {
                MessagingService.showErrorMessage("Aucun véhicule n'a été réceptionné !");
            }
            else if(MessagingService.confirmation("Voulez vous vraiment valider la réception des véhcules?")==DialogResult.Yes)
            {
                AnomalieManager anomalieManager = new AnomalieManager();
                foreach (PAN_Char_Cam_Vehi pan in PansVehicules)
                {
                    if (pan.BackColor != Color.Red && pan.Vin != null)
                    {
                        ChargementManager charManager = new ChargementManager();
                        charManager.validerReception(operationReceptionne.Code);
                        if (anomalieManager.vehiculeAvecAnomalie(pan.Vin))
                        {
                            anomalieManager.setAnomalieVehiculeValidee(pan.Vin);
                        }
                    }

                }
                Close();

            }
            
        }

        private void FEN_Reception_Closing(object sender, CancelEventArgs e)
        {
            scanner.disactivate();
            FEN_Ordres_Transport fen = (FEN_Ordres_Transport)this.Tag;
            fen.updateDataGrid();
        }
    }
}
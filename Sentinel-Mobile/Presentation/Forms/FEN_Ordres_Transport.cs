using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Presentation.Util;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Ordres_Transport : Form
    {
        public bool ModeChargement { get; set; }
        public FEN_Ordres_Transport()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click_1(object sender, EventArgs e)
        {

        }


        public void pauseCnxTest()
        {
            this.baR_Etat_Perso1.pauseCnxTest();
        }

        public void reprendreCnxTest()
        {
            this.baR_Etat_Perso1.reprendreCnxTest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChargementManager charManager = new ChargementManager();
            if (ModeChargement)
            {
                FEN_Char_Camions fen = new FEN_Char_Camions();
                fen.Tag = this;
                fen.Show();
                pauseCnxTest();
                Hide();
            }
            else
            {
                long code = Convert.ToInt64(Grd_Op[Grd_Op.CurrentCell.RowNumber, 0]);
                OpTransportReceptionneeDTO operation = charManager.getOperationReceptByCode(code);
                FEN_Reception fen = new FEN_Reception(operation);
                fen.Tag = this;
                fen.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        public void setModeChargement()
        {
            Btn_Programmer.Text = "Programmer";
            Btn_Imprimmer.Text = "Imprimer";
            ModeChargement = true;
        }

        public void setModeReception()
        {
            Btn_Programmer.Text = "Vérifier";
            Btn_Imprimmer.Text = "Actualiser";
            ModeChargement = false;
        }

        public void updateMode()
        {
            if (Rbx_Chargement.Checked == true)
            {
                setModeChargement();
            }
            else
            {
                setModeReception();
            }
        }

        public void updateDataGrid()
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7]
                          { new DataColumn("Code", typeof(long)),
                            new DataColumn("Date Départ",typeof(string)),
                            new DataColumn("Lieu Depart",typeof(string)),
                            new DataColumn("Lieu d'arrivée",typeof(string)),
                            new DataColumn("Chauffeur",typeof(Chauffeur)),
                            new DataColumn("Camion",typeof(Camion)),
                            new DataColumn("Nombre de vehicule",typeof(string))
                          });
            ChargementManager chrManager = new ChargementManager();
            TransportManager trspManager = new TransportManager();
            if (ModeChargement)
            {
                List<OperationTransport> operationsTrans = chrManager.getOperationTransport();
                foreach (OperationTransport op in operationsTrans)
                {
                    Chauffeur chauffeur = trspManager.getChauffeurByCode(op.NumPermisChauffeur);
                    Camion camion = trspManager.getCamionByCode(op.NumeroImmatriculation);
                    int nbVehicule = trspManager.getNbVehiculesByOp(op.Id);
                    dt.Rows.Add(op.Id, op.DateDepart, op.CodeLieuDepart, op.CodeLieuArrivee, chauffeur, camion, nbVehicule);
                }
            }
            else
            {
                List<OpTransportReceptionneeDTO> opérations = chrManager.getOperationReceptionnePrRecept();
                if (opérations != null)
                {
                    foreach (OpTransportReceptionneeDTO op in opérations)
                    {
                        Chauffeur chauffeur = trspManager.getChauffeurByCode(op.NumPermisChauffeur);
                        Camion camion = trspManager.getCamionByCode(op.NumeroImmatriculation);
                        int nbVehicule = trspManager.getNbVehiculesByOpReceptionne(op.Code);
                        dt.Rows.Add(op.Code, op.DateDepart, op.CodeLieuDepart, op.CodeLieuArrive, chauffeur, camion, nbVehicule);
                    }
                }

            }
            Grd_Op.DataSource = dt;
            SplashManager.CloseSplashScreen();
        }

        private void FEN_Ordres_Transport_Load(object sender, EventArgs e)
        {
            setModeChargement();
            updateDataGrid();
            if (UtilisateurCache.Affectation.Type == PointLivrable.PORT) Rbx_Reception.Enabled = false;
        }

        private void Rbx_Chargement_CheckedChanged(object sender, EventArgs e)
        {

            if (Rbx_Chargement.Checked)
            {
                setModeChargement();
            }
            else
            {
                setModeReception();
            }
            updateDataGrid();
        }

        private void Grd_Op_CurrentCellChanged(object sender, EventArgs e)
        {
            Grd_Op.Select(Grd_Op.CurrentCell.RowNumber);
        }

        private void FEN_Ordres_Transport_Closing(object sender, CancelEventArgs e)
        {
            
            FEN_Principale fen = (FEN_Principale)this.Tag;
            fen.Show();
        }

        private void Btn_Imprimmer_Click(object sender, EventArgs e)
        {
            if (ModeChargement)
            {

            }
            else
            {
                try
                {
                    ChargementManager charManager = new ChargementManager();
                    charManager.getRemoteOperationReceptionnee(UtilisateurCache.Affectation.Code);

                }
                catch (Exception ee)
                {

                }
            }
        }

        private void FEN_Ordres_Transport_Closed(object sender, EventArgs e)
        {
            baR_Etat_Perso1.stopTimer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessagingService.showInfoMessage("La fonctionnalitée sera implémantée prochainement");
        }
    }
}
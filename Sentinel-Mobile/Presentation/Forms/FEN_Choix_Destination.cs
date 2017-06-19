using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.UIComponents;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Choix_Destination : Form
    {
        PAN_Char_Cam_Vehi panCamChar;
        public FEN_Choix_Destination(PAN_Char_Cam_Vehi pan)
        {
            InitializeComponent();
            this.panCamChar = pan;
        }

        private void Cbx_destination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Valider_Click_1(object sender, EventArgs e)
        {

        }

        private void Cbx_destination_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cbx_destination.SelectedIndex == 0)
            {
                Cbx_designation.Hide();
            }
            else
            {
                updateCbxDesignation();
                Cbx_designation.Show();
            }
        }
        public void updateCbxDestination()
        {
            Cbx_destination.Items.Clear();
            Cbx_destination.Items.Add("<--Choisir une destination-->");
            Cbx_destination.SelectedIndex = 0;
            //L'index 1 = PARC 2= SHOWROOM 3= Concessionnaire 4=Attelier 
            Cbx_destination.Items.Add("Parc");
            Cbx_destination.Items.Add("Show Room");
            Cbx_destination.Items.Add("Concessionnaire");
            Cbx_destination.Items.Add("Attelier");
        }

        public void updateCbxDesignation()
        {
            Cbx_designation.Items.Clear();
            Cbx_designation.Items.Add("<--Préciser la destination-->");
            Cbx_designation.SelectedIndex = 0;
            if (Cbx_destination.SelectedIndex != 0)
            {
                ChargementManager chargementManager = new ChargementManager();
                int type = Cbx_destination.SelectedIndex;
                List<PointLivrable> listPtLivrable = chargementManager.getListPointLivreableByType(type);
                if (listPtLivrable != null)
                {
                    foreach (PointLivrable ptLivrable in listPtLivrable)
                    {
                        Cbx_designation.Items.Add(ptLivrable);
                    }
                }
            }
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (Cbx_designation.SelectedIndex != 0)
            {
                panCamChar.Destination = (PointLivrable)Cbx_designation.SelectedItem;
                panCamChar.updateView();
                Close();
            }
            else
            {
                MessagingService.showErrorMessage("Vous devez précisez une destination valide");
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEN_Choix_Destination_Load(object sender, EventArgs e)
        {
            updateCbxDestination();
        }

        private void label5_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}
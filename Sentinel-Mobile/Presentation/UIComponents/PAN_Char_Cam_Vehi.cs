using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Model.Domain.Utilisateur;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Presentation.UIComponents
{
    public delegate void handleDeleteEvent(object sender, EventArgs e);
    public partial class PAN_Char_Cam_Vehi : UserControl
    {
        public int Ordre { get; set; }
        public String Modele { get; set; }
        public String Couleur { get; set; }
        public String Vin { get; set; }
        public PointLivrable Destination { get; set; }

        public PAN_Char_Cam_Vehi()
        {
            InitializeComponent();
        }


        public void setDeleteHandler(handleDeleteEvent deleteEvent)
        {
            this.Btn_supprimer.Click += new EventHandler(deleteEvent);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void updateView()
        {
            this.Lbl_Numero.Text = Ordre + "";
            this.Lbl_Model.Text = Modele;
            this.Lbl_Chasis.Text = Vin;
            this.Lbl_couleur.Text = Couleur;
            if (Destination != null) this.Lbl_destination.Text = Destination.Designation;
            else this.Lbl_destination.Text = "Destination non défini";
        }

        public void setWarnning()
        {
            this.BackColor = Color.Orange;
        }

        public void setSuccess()
        {
            this.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Vin != null)
            {
                int etape = 0;
                if (UtilisateurCache.Affectation.Type == PointLivrable.PORT)
                {
                    etape = Vehicule.TRANSIT;
                }
                else
                {
                    etape = Vehicule.TRANSFERT;
                }

                using (FEN_DEC_AVA fen = new FEN_DEC_AVA(this.Vin, etape))
                {
                    if (fen.ShowDialog() == DialogResult.No)
                    {
                        setWarnning();
                    }
                    else
                    {
                        setSuccess();
                    }
                }
            }
            
        }


        public void setDeleteBtnTag(int p)
        {
            Btn_supprimer.Tag = p;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FEN_Choix_Destination fen = new FEN_Choix_Destination(this);
            fen.ShowDialog();
        }

        public void disableDestinationButton()
        {
            this.Btn_destination.Enabled = false;
        }

        public void EnableDestinationButton()
        {
            this.Btn_destination.Enabled = true;
        }
    }
}

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace Sentinel_Mobile.Presentation.UIComponents
{
    public partial class PAN_Check_Arr_Vehi : UserControl
    {
        public String vin { get; set; }
        public String model { get; set; }
        public String numLot { get; set; }
        
        public PAN_Check_Arr_Vehi()
        {
            InitializeComponent();
        }
        public void updateView() 
        {
            LBL_Num_Chassis.Text = vin;
            LBL_Model.Text = model;
            Lbl_Lot.Text = numLot;
        }
        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void PAN_Check_Arr_Vehi_Click(object sender, EventArgs e)
        {

        }

        private void PAN_Check_Arr_Vehi_Click_1(object sender, EventArgs e)
        {

        }

        private void DEC_Controleur_DecodeEvent(object sender, Honeywell.DataCollection.Decoding.DecodeBase.DecodeEventArgs e)
        {

        }

        private void LBL_Num_Chassis_ParentChanged(object sender, EventArgs e)
        {

        }

        public void setSuccess()
        {
            this.BackColor = Color.Green;
        }

        public void setFail()
        {
            this.BackColor = Color.Red;
            this.LBL_Model.Text = "inconnu";
            this.Lbl_Lot.Text = "inconnu";
        }
        
        public void resetView()
        {
            this.LBL_Model.Text="-";
            this.Lbl_Lot.Text="-";
            this.LBL_Num_Chassis.Text="-";
        }

        internal void setWarnning()
        {
            this.BackColor = Color.Orange;
        }
    }
}

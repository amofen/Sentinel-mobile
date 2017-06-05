using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sentinel_Mobile.Presentation.UIComponents
{
    public partial class PAN_Info_Vehi : UserControl
    {
        public String vin { get; set; }
        public String model { get; set; }
        public PAN_Info_Vehi()
        {
            InitializeComponent();
        }
        public void updateView()
        {
            LBL_Num_Chassis.Text = vin;
            LBL_Model.Text = model;
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
        }

        public void resetView()
        {
            this.LBL_Model.Text = "-";
            this.LBL_Num_Chassis.Text = "-";
        }

        public void setWarnning()
        {
            this.BackColor = Color.Orange;
        }
    }
}

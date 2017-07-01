using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Host_Config : Form
    {
        public FEN_Host_Config()
        {
            InitializeComponent();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {

                ConnexionParam.SERVER_IP = Txt_Host.Text;
                ConnexionParam.SERVER_PORT = Convert.ToInt32(Txt_Port.Text);
                Close();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FEN_Host_Config_Load(object sender, EventArgs e)
        {
            Txt_Host.Text = ConnexionParam.SERVER_IP;
            Txt_Port.Text  =ConnexionParam.SERVER_PORT+"";
           
        }
    }
}
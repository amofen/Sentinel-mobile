using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Ordres_Transport : Form
    {
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
    }
}
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.Util;

namespace Sentinel_Mobile.Presentation.UIComponents
{
    public partial class BAR_Etat_Perso : UserControl
    {
        public BAR_Etat_Perso()
        {
            InitializeComponent();
            this.LBL_Utilisateur.Text = UtilisateurCache.CurrentUserName;
            if (ConnectionTester.IS_CONNECTED)
            {
                setConnecte();
            }
            else
            {
                setDeConnecte();
            }
        }

        private void BAR_Etat_Perso_Click(object sender, EventArgs e)
        {

        }

        public void setConnecte()
        {
            this.LBL_Status.ForeColor = Color.Green;
            this.LBL_Status.Text = "Connecté";
        }
        public void setDeConnecte()
        {
            this.LBL_Status.ForeColor = Color.Red;
            this.LBL_Status.Text = "Déconnecté";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ConnectionTester.IS_CONNECTED)
            {
                setConnecte();
            }
            else
            {
                setDeConnecte();
            }
        }

        public void stopTimer()
        {
            this.timer1.Enabled = false;
            this.timer1.Dispose();
            this.timer1 = null;
        }




        internal void pauseCnxTest()
        {
            timer1.Enabled = false;
        }

        internal void reprendreCnxTest()
        {
            timer1.Enabled = true;
        }
    }
}

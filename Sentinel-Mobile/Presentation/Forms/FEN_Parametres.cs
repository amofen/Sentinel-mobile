using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Parametres : Form
    {
        public FEN_Parametres()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FEM_Mise_A_Jour fen = new FEM_Mise_A_Jour();
            fen.Show();
            fen.Tag = this;
            Hide();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            FEN_Principale fen = (FEN_Principale)Tag;
            Hide();
            fen.Show();
            this.bar_etat.stopTimer();
            Close();
        }

    }
}
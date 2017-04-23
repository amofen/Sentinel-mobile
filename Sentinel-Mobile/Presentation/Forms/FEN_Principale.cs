using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Principale : Form
    {
        public FEN_Principale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click(object sender, EventArgs e)
        {
            FEN_Parametres fen = new FEN_Parametres();
            fen.Tag = this;
            Hide();
            fen.Show();
        }

        private void BTN_Positionnement_Click(object sender, EventArgs e)
        {
            FEN_Positionnement fen = new FEN_Positionnement();
            fen.Tag = this;
            fen.Show();
            Hide();
          
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {
            Hide();
            FEN_Check_Arri fen = new FEN_Check_Arri();
            fen.Tag = this;
            fen.Show();
            
        }

        private void FEN_Principale_Load(object sender, EventArgs e)
        {

        }

        private void FEN_Principale_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
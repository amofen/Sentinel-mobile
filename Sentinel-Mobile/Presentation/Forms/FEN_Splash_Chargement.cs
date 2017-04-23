using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Splash_Chargement : Form
    {
        private int numPoints = 0;
        private string message = "";
        public delegate void CloseFormDelegate();
        public CloseFormDelegate myDelegate;


        public FEN_Splash_Chargement(string message)
        {
            InitializeComponent();
            myDelegate = new CloseFormDelegate(Close);
            this.message = message;
            this.Lbl_message.Text = message;
        }


        private void FEN_Splash_Chargement_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numPoints == 10)
            {
                Lbl_chargement.Text = "";
                numPoints = 0;
            }
            else
            {
                Lbl_chargement.Text += ".";
                numPoints++;
            }
            

        }


       

    }
}
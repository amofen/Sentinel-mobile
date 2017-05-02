using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Controlers;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_DEC_AVA : Form
    {
        public String Vin { get; set; }
        public Dictionary<String,bool> declarationsOrig {get;set;}
        public Dictionary<String, bool> declarations { get; set; }
        public Dictionary<String, CheckBox> CheckBoxes { get; set; }
        public int Etape { get; set; }

        public FEN_DEC_AVA(String vin,int etape)
        {
            InitializeComponent();
            this.Vin = vin;
            this.Etape = etape;
            this.declarations = new Dictionary<String,bool>();
            declarationsOrig = new Dictionary<String, bool>();
            this.CheckBoxes = new Dictionary<String, CheckBox>();
            initCheckBoxes();
            initDeclarations();    
        }
        private void initDeclarations()
        {
            DeclarationAnomalieController decAnomalieCtrl = new DeclarationAnomalieController(this);
            decAnomalieCtrl.initialiserDictionnaires();
            decAnomalieCtrl.initialiserAnomalies();
        }
        private void initCheckBoxes()
        {
            foreach (Control tabItem in this.Controls)
            {
                if (tabItem.GetType() == typeof(TabControl))
                    foreach (Control pgItem in tabItem.Controls)
                    {
                        foreach (Control chkItem in pgItem.Controls)
                        {
                            if (chkItem.GetType() == typeof(CheckBox))
                            {
                                ((CheckBox)chkItem).CheckStateChanged += checkChanged;
                                CheckBoxes.Add(chkItem.Tag.ToString(), (CheckBox)chkItem);
                            }
                        }
                    }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void Chk_accessoire_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void Chk_piece_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeclarationAnomalieController decAnomalieCtrl = new DeclarationAnomalieController(this);
            decAnomalieCtrl.declarerAnomalies();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void checkChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            String codeAnomalie = checkBox.Tag.ToString();
            if (checkBox.CheckState == CheckState.Checked)
            {
                declarations[codeAnomalie] = true;
            }
            else
            {
                declarations[codeAnomalie] = false;
            }
        }



    }
}
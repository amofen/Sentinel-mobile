using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_DEC_AVA : Form
    {
        public String Vin { get; set; }
        public Dictionary<String,bool> declarationsOrig {get;set;}
        public Dictionary<String, bool> declarations { get; set; }
        public Dictionary<String, CheckBox> CheckBoxes { get; set; }
        public int Etape { get; set; }
        private DeclarationAnomalieController decAnomalieCtrl;

        public FEN_DEC_AVA(String vin,int etape)
        {
            InitializeComponent();
            this.Vin = vin;
            this.Etape = etape;
            this.declarations = new Dictionary<String,bool>();
            declarationsOrig = new Dictionary<String, bool>();
            this.CheckBoxes = new Dictionary<String, CheckBox>();
            decAnomalieCtrl = new DeclarationAnomalieController(this);
            initCheckBoxes1();
            initCheckBoxes2();
            initDeclarations();    
        }
        private void initDeclarations()
        {
            decAnomalieCtrl.initialiserDictionnaires();
            decAnomalieCtrl.initialiserAnomalies();
        }

        private void initCheckBoxes1()
        {
            List<CheckBox> checksManques = new List<CheckBox>();
            checksManques.Add(Chk_m_1);
            checksManques.Add(Chk_m_2);
            checksManques.Add(Chk_m_3);
            checksManques.Add(Chk_m_4);
            checksManques.Add(Chk_m_5);
            checksManques.Add(Chk_m_6);
            checksManques.Add(Chk_m_7);
            checksManques.Add(Chk_m_8);
            checksManques.Add(Chk_m_9);
            List<Anomalie> listManques = decAnomalieCtrl.getAnomaliesByType(Anomalie.MANQUE);
            for (int i = 0; i < checksManques.Count; i++)
            {
                checksManques.ToArray()[i].Tag = listManques.ToArray()[i].Id;
                checksManques.ToArray()[i].Text = listManques.ToArray()[i].Designation;

            }
            
            
            
            List<CheckBox> checksAvaries = new List<CheckBox>();
            checksAvaries.Add(Chk_a_1);
            checksAvaries.Add(Chk_a_2);
            checksAvaries.Add(Chk_a_3);
            checksAvaries.Add(Chk_a_4);
            checksAvaries.Add(Chk_a_5);
            checksAvaries.Add(Chk_a_6);
            checksAvaries.Add(Chk_a_7);
            List<Anomalie> listAvaries = decAnomalieCtrl.getAnomaliesByType(Anomalie.AVARIE);
            for (int i = 0; i < checksAvaries.Count; i++)
            {
                checksAvaries.ToArray()[i].Tag = listAvaries.ToArray()[i].Id;
                checksAvaries.ToArray()[i].Text = listAvaries.ToArray()[i].Designation;
                
            }

        }
        private void initCheckBoxes2()
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

        private void FEN_DEC_AVA_Closing(object sender, CancelEventArgs e)
        {
            if (!declarations.ContainsValue(true)) DialogResult = DialogResult.Yes;
            else DialogResult = DialogResult.No;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TPB_Avancé_Click(object sender, EventArgs e)
        {

        }



    }
}
using Sentinel_Mobile.Presentation.UIComponents;
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Positionnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMB_Plateforme = new System.Windows.Forms.ComboBox();
            this.CMB_Range = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMB_Numero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Positionner = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.LBL_Afficher_List = new System.Windows.Forms.LinkLabel();
            this.paN_Check_Arr_Vehi1 = new PAN_Check_Arr_Vehi();
            this.baR_Etat_Perso1 = new BAR_Etat_Perso();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LBL_Afficher_List);
            this.panel1.Controls.Add(this.BTN_Annuler);
            this.panel1.Controls.Add(this.BTN_Valider);
            this.panel1.Controls.Add(this.BTN_Positionner);
            this.panel1.Controls.Add(this.CMB_Numero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CMB_Range);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CMB_Plateforme);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.paN_Check_Arr_Vehi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 243);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.Text = "Positionnement :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Plateforme :";
            // 
            // CMB_Plateforme
            // 
            this.CMB_Plateforme.Location = new System.Drawing.Point(106, 115);
            this.CMB_Plateforme.Name = "CMB_Plateforme";
            this.CMB_Plateforme.Size = new System.Drawing.Size(124, 23);
            this.CMB_Plateforme.TabIndex = 4;
            // 
            // CMB_Range
            // 
            this.CMB_Range.Location = new System.Drawing.Point(106, 144);
            this.CMB_Range.Name = "CMB_Range";
            this.CMB_Range.Size = new System.Drawing.Size(124, 23);
            this.CMB_Range.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Rangé :";
            // 
            // CMB_Numero
            // 
            this.CMB_Numero.Location = new System.Drawing.Point(106, 173);
            this.CMB_Numero.Name = "CMB_Numero";
            this.CMB_Numero.Size = new System.Drawing.Size(124, 23);
            this.CMB_Numero.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Numéro :";
            // 
            // BTN_Positionner
            // 
            this.BTN_Positionner.Location = new System.Drawing.Point(141, 91);
            this.BTN_Positionner.Name = "BTN_Positionner";
            this.BTN_Positionner.Size = new System.Drawing.Size(89, 20);
            this.BTN_Positionner.TabIndex = 12;
            this.BTN_Positionner.Text = "Ajouter";
            this.BTN_Positionner.Click += new System.EventHandler(this.BTN_Positionner_Click);
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(158, 218);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(72, 20);
            this.BTN_Valider.TabIndex = 13;
            this.BTN_Valider.Text = "Valider";
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(4, 220);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(72, 20);
            this.BTN_Annuler.TabIndex = 14;
            this.BTN_Annuler.Text = "Annuler";
            // 
            // LBL_Afficher_List
            // 
            this.LBL_Afficher_List.Location = new System.Drawing.Point(130, 195);
            this.LBL_Afficher_List.Name = "LBL_Afficher_List";
            this.LBL_Afficher_List.Size = new System.Drawing.Size(100, 20);
            this.LBL_Afficher_List.TabIndex = 15;
            this.LBL_Afficher_List.Text = "Afficher Liste";
            // 
            // paN_Check_Arr_Vehi1
            // 
            this.paN_Check_Arr_Vehi1.Location = new System.Drawing.Point(2, 4);
            this.paN_Check_Arr_Vehi1.Name = "paN_Check_Arr_Vehi1";
            this.paN_Check_Arr_Vehi1.Size = new System.Drawing.Size(228, 83);
            this.paN_Check_Arr_Vehi1.TabIndex = 1;
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(1, 247);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(235, 21);
            this.baR_Etat_Perso1.TabIndex = 0;
            // 
            // FEN_Positionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Positionnement";
            this.Text = "SOVAC : Positionnement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Panel panel1;
        private PAN_Check_Arr_Vehi paN_Check_Arr_Vehi1;
        private System.Windows.Forms.ComboBox CMB_Numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_Range;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMB_Plateforme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Positionner;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.LinkLabel LBL_Afficher_List;
    }
}
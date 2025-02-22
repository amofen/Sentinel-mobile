﻿namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Choix_Arrivage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEN_Choix_Arrivage));
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_Source = new System.Windows.Forms.ComboBox();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_Arrivages = new System.Windows.Forms.ComboBox();
            this.Lst_Lots = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.Text = "Le port source :";
            // 
            // Cbx_Source
            // 
            this.Cbx_Source.Location = new System.Drawing.Point(3, 17);
            this.Cbx_Source.Name = "Cbx_Source";
            this.Cbx_Source.Size = new System.Drawing.Size(230, 23);
            this.Cbx_Source.TabIndex = 1;
            this.Cbx_Source.SelectedIndexChanged += new System.EventHandler(this.Cbx_Source_SelectedIndexChanged);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(3, 226);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(94, 19);
            this.BTN_Annuler.TabIndex = 3;
            this.BTN_Annuler.Text = "Retour";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click_1);
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Valider.ForeColor = System.Drawing.Color.Green;
            this.BTN_Valider.Location = new System.Drawing.Point(148, 226);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(85, 19);
            this.BTN_Valider.TabIndex = 2;
            this.BTN_Valider.Text = "Sélectionner";
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.Text = "Liste des lots :";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // Cbx_Arrivages
            // 
            this.Cbx_Arrivages.Location = new System.Drawing.Point(3, 63);
            this.Cbx_Arrivages.Name = "Cbx_Arrivages";
            this.Cbx_Arrivages.Size = new System.Drawing.Size(232, 23);
            this.Cbx_Arrivages.TabIndex = 8;
            this.Cbx_Arrivages.SelectedIndexChanged += new System.EventHandler(this.Cbx_Arrivages_SelectedIndexChanged);
            // 
            // Lst_Lots
            // 
            this.Lst_Lots.Location = new System.Drawing.Point(3, 106);
            this.Lst_Lots.Name = "Lst_Lots";
            this.Lst_Lots.Size = new System.Drawing.Size(230, 114);
            this.Lst_Lots.TabIndex = 9;
            this.Lst_Lots.SelectedIndexChanged += new System.EventHandler(this.Lst_Lots_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.Text = "Liste des arrivages:";
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(1, 247);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(232, 22);
            this.baR_Etat_Perso1.TabIndex = 7;
            // 
            // FEN_Choix_Arrivage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lst_Lots);
            this.Controls.Add(this.Cbx_Arrivages);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.Cbx_Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Choix_Arrivage";
            this.Text = "Sentinel : Arrivages et lots";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEN_Choix_Arrivage_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FEN_Choix_Arrivage_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Cbx_Source;
        public System.Windows.Forms.ComboBox Cbx_Arrivages;
        public System.Windows.Forms.ListBox Lst_Lots;
        public Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso baR_Etat_Perso1;
    }
}
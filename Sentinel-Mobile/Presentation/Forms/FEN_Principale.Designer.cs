﻿using Sentinel_Mobile.Presentation.UIComponents;
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Principale
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
            this.BTN_Check = new System.Windows.Forms.Button();
            this.BTN_Chargement = new System.Windows.Forms.Button();
            this.BTN_PDS = new System.Windows.Forms.Button();
            this.BTN_Positionnement = new System.Windows.Forms.Button();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.SuspendLayout();
            // 
            // BTN_Check
            // 
            this.BTN_Check.Location = new System.Drawing.Point(53, 50);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(143, 36);
            this.BTN_Check.TabIndex = 1;
            this.BTN_Check.Text = "Check";
            this.BTN_Check.Click += new System.EventHandler(this.BTN_Check_Click);
            // 
            // BTN_Chargement
            // 
            this.BTN_Chargement.Location = new System.Drawing.Point(53, 139);
            this.BTN_Chargement.Name = "BTN_Chargement";
            this.BTN_Chargement.Size = new System.Drawing.Size(143, 36);
            this.BTN_Chargement.TabIndex = 2;
            this.BTN_Chargement.Text = "Chargement";
            this.BTN_Chargement.Click += new System.EventHandler(this.BTN_Chargement_Click);
            // 
            // BTN_PDS
            // 
            this.BTN_PDS.Location = new System.Drawing.Point(53, 186);
            this.BTN_PDS.Name = "BTN_PDS";
            this.BTN_PDS.Size = new System.Drawing.Size(143, 36);
            this.BTN_PDS.TabIndex = 3;
            this.BTN_PDS.Text = "PDS";
            // 
            // BTN_Positionnement
            // 
            this.BTN_Positionnement.Location = new System.Drawing.Point(53, 95);
            this.BTN_Positionnement.Name = "BTN_Positionnement";
            this.BTN_Positionnement.Size = new System.Drawing.Size(143, 36);
            this.BTN_Positionnement.TabIndex = 6;
            this.BTN_Positionnement.Text = "Positionnement";
            this.BTN_Positionnement.Click += new System.EventHandler(this.BTN_Positionnement_Click);
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(3, 244);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(232, 23);
            this.baR_Etat_Perso1.TabIndex = 0;
            // 
            // FEN_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.BTN_Positionnement);
            this.Controls.Add(this.BTN_PDS);
            this.Controls.Add(this.BTN_Chargement);
            this.Controls.Add(this.BTN_Check);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Principale";
            this.Text = "Sentinel : Menu";
            this.Load += new System.EventHandler(this.FEN_Principale_Load);
            this.Closed += new System.EventHandler(this.FEN_Principale_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Button BTN_Check;
        private System.Windows.Forms.Button BTN_Chargement;
        private System.Windows.Forms.Button BTN_PDS;
        private System.Windows.Forms.Button BTN_Positionnement;
    }
}
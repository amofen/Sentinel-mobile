﻿using Sentinel_Mobile.Presentation.UIComponents;
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Check_Arri
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
            this.BTN_Anomalie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Nb_Scanes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Total_Vehi = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Port = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Date_Arrivage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pan_info_vehicule = new Sentinel_Mobile.Presentation.UIComponents.PAN_Check_Arr_Vehi();
            this.bar_etat = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Anomalie
            // 
            this.BTN_Anomalie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Anomalie.ForeColor = System.Drawing.Color.Orange;
            this.BTN_Anomalie.Location = new System.Drawing.Point(60, 192);
            this.BTN_Anomalie.Name = "BTN_Anomalie";
            this.BTN_Anomalie.Size = new System.Drawing.Size(119, 20);
            this.BTN_Anomalie.TabIndex = 3;
            this.BTN_Anomalie.Text = "Anomalie";
            this.BTN_Anomalie.Click += new System.EventHandler(this.BTN_Declarer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.Text = "Total de véhicules scanés";
            // 
            // LBL_Nb_Scanes
            // 
            this.LBL_Nb_Scanes.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Nb_Scanes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_Nb_Scanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBL_Nb_Scanes.Location = new System.Drawing.Point(71, 43);
            this.LBL_Nb_Scanes.Name = "LBL_Nb_Scanes";
            this.LBL_Nb_Scanes.Size = new System.Drawing.Size(40, 20);
            this.LBL_Nb_Scanes.Text = "14";
            this.LBL_Nb_Scanes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(113, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 20);
            this.label2.Text = "/";
            // 
            // LBL_Total_Vehi
            // 
            this.LBL_Total_Vehi.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Total_Vehi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_Total_Vehi.Location = new System.Drawing.Point(125, 43);
            this.LBL_Total_Vehi.Name = "LBL_Total_Vehi";
            this.LBL_Total_Vehi.Size = new System.Drawing.Size(40, 20);
            this.LBL_Total_Vehi.Text = "150";
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Valider.ForeColor = System.Drawing.Color.Green;
            this.BTN_Valider.Location = new System.Drawing.Point(180, 216);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(55, 25);
            this.BTN_Valider.TabIndex = 0;
            this.BTN_Valider.Text = "Valider";
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(3, 216);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(55, 25);
            this.BTN_Annuler.TabIndex = 1;
            this.BTN_Annuler.Text = "Retour";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Lbl_Port);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lbl_Date_Arrivage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 64);
            // 
            // Lbl_Port
            // 
            this.Lbl_Port.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Port.Location = new System.Drawing.Point(162, 6);
            this.Lbl_Port.Name = "Lbl_Port";
            this.Lbl_Port.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Port.Text = "Djen Djen";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(152, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 20);
            this.label4.Text = "-";
            // 
            // Lbl_Date_Arrivage
            // 
            this.Lbl_Date_Arrivage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Date_Arrivage.Location = new System.Drawing.Point(79, 8);
            this.Lbl_Date_Arrivage.Name = "Lbl_Date_Arrivage";
            this.Lbl_Date_Arrivage.Size = new System.Drawing.Size(75, 18);
            this.Lbl_Date_Arrivage.Text = "22/01/2017";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.Text = "Arrivage du ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 245);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 20);
            // 
            // pan_info_vehicule
            // 
            this.pan_info_vehicule.Location = new System.Drawing.Point(3, 69);
            this.pan_info_vehicule.Name = "pan_info_vehicule";
            this.pan_info_vehicule.Size = new System.Drawing.Size(232, 120);
            this.pan_info_vehicule.TabIndex = 21;
            this.pan_info_vehicule.Click += new System.EventHandler(this.pan_info_vehicule_Click);
            // 
            // bar_etat
            // 
            this.bar_etat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bar_etat.Location = new System.Drawing.Point(7, 245);
            this.bar_etat.Name = "bar_etat";
            this.bar_etat.Size = new System.Drawing.Size(221, 21);
            this.bar_etat.TabIndex = 11;
            // 
            // FEN_Check_Arri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pan_info_vehicule);
            this.Controls.Add(this.bar_etat);
            this.Controls.Add(this.LBL_Total_Vehi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Nb_Scanes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Anomalie);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Check_Arri";
            this.Text = "Sentinel : Arrivage";
            this.Load += new System.EventHandler(this.FEN_Check_Arri_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FEN_Check_Arri_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Anomalie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Nb_Scanes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Total_Vehi;
        private Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso bar_etat;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Lbl_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Date_Arrivage;
        private System.Windows.Forms.Label label3;
        public  Sentinel_Mobile.Presentation.UIComponents.PAN_Check_Arr_Vehi pan_info_vehicule;
    }
}


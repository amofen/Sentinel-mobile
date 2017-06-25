namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Char_Camions
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
            this.Tb_Crtl = new System.Windows.Forms.TabControl();
            this.Tbp_Camion = new System.Windows.Forms.TabPage();
            this.Cbx_Camion = new System.Windows.Forms.ComboBox();
            this.Cbx_Transporteur = new System.Windows.Forms.ComboBox();
            this.Cbx_Chauffeur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbp_Destination = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbx_designation = new System.Windows.Forms.ComboBox();
            this.Cbx_destination = new System.Windows.Forms.ComboBox();
            this.Rbx_plusDest = new System.Windows.Forms.RadioButton();
            this.Rbx_uneDest = new System.Windows.Forms.RadioButton();
            this.Tbp_Vehicules = new System.Windows.Forms.TabPage();
            this.paN_Char_Cam_Vehi8 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi7 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi6 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi5 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi4 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi3 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi2 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.paN_Char_Cam_Vehi1 = new Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi();
            this.Lbl_VehiculesCharges = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.Tb_Crtl.SuspendLayout();
            this.Tbp_Camion.SuspendLayout();
            this.Tbp_Destination.SuspendLayout();
            this.Tbp_Vehicules.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Crtl
            // 
            this.Tb_Crtl.Controls.Add(this.Tbp_Camion);
            this.Tb_Crtl.Controls.Add(this.Tbp_Destination);
            this.Tb_Crtl.Controls.Add(this.Tbp_Vehicules);
            this.Tb_Crtl.Location = new System.Drawing.Point(3, 3);
            this.Tb_Crtl.Name = "Tb_Crtl";
            this.Tb_Crtl.SelectedIndex = 0;
            this.Tb_Crtl.Size = new System.Drawing.Size(232, 212);
            this.Tb_Crtl.TabIndex = 0;
            // 
            // Tbp_Camion
            // 
            this.Tbp_Camion.Controls.Add(this.Cbx_Camion);
            this.Tbp_Camion.Controls.Add(this.Cbx_Transporteur);
            this.Tbp_Camion.Controls.Add(this.Cbx_Chauffeur);
            this.Tbp_Camion.Controls.Add(this.label4);
            this.Tbp_Camion.Controls.Add(this.label3);
            this.Tbp_Camion.Controls.Add(this.label2);
            this.Tbp_Camion.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Camion.Name = "Tbp_Camion";
            this.Tbp_Camion.Size = new System.Drawing.Size(224, 183);
            this.Tbp_Camion.Text = "Camion";
            // 
            // Cbx_Camion
            // 
            this.Cbx_Camion.Items.Add("Mohammed Amine");
            this.Cbx_Camion.Items.Add("Sallah Eddine Mouffok");
            this.Cbx_Camion.Items.Add("Cherif Bessai");
            this.Cbx_Camion.Items.Add("Arezki Abdellah");
            this.Cbx_Camion.Items.Add("");
            this.Cbx_Camion.Location = new System.Drawing.Point(12, 90);
            this.Cbx_Camion.Name = "Cbx_Camion";
            this.Cbx_Camion.Size = new System.Drawing.Size(199, 23);
            this.Cbx_Camion.TabIndex = 15;
            // 
            // Cbx_Transporteur
            // 
            this.Cbx_Transporteur.Items.Add("Mohammed Amine");
            this.Cbx_Transporteur.Items.Add("Sallah Eddine Mouffok");
            this.Cbx_Transporteur.Items.Add("Cherif Bessai");
            this.Cbx_Transporteur.Items.Add("Arezki Abdellah");
            this.Cbx_Transporteur.Items.Add("");
            this.Cbx_Transporteur.Location = new System.Drawing.Point(12, 37);
            this.Cbx_Transporteur.Name = "Cbx_Transporteur";
            this.Cbx_Transporteur.Size = new System.Drawing.Size(199, 23);
            this.Cbx_Transporteur.TabIndex = 14;
            this.Cbx_Transporteur.SelectedIndexChanged += new System.EventHandler(this.Cbx_Transporteur_SelectedIndexChanged);
            // 
            // Cbx_Chauffeur
            // 
            this.Cbx_Chauffeur.Items.Add("Mohammed Amine");
            this.Cbx_Chauffeur.Items.Add("Sallah Eddine Mouffok");
            this.Cbx_Chauffeur.Items.Add("Cherif Bessai");
            this.Cbx_Chauffeur.Items.Add("Arezki Abdellah");
            this.Cbx_Chauffeur.Items.Add("");
            this.Cbx_Chauffeur.Location = new System.Drawing.Point(13, 144);
            this.Cbx_Chauffeur.Name = "Cbx_Chauffeur";
            this.Cbx_Chauffeur.Size = new System.Drawing.Size(199, 23);
            this.Cbx_Chauffeur.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Chauffeur :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.Text = "Transporteur :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "Camion :";
            // 
            // Tbp_Destination
            // 
            this.Tbp_Destination.Controls.Add(this.label5);
            this.Tbp_Destination.Controls.Add(this.Cbx_designation);
            this.Tbp_Destination.Controls.Add(this.Cbx_destination);
            this.Tbp_Destination.Controls.Add(this.Rbx_plusDest);
            this.Tbp_Destination.Controls.Add(this.Rbx_uneDest);
            this.Tbp_Destination.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Destination.Name = "Tbp_Destination";
            this.Tbp_Destination.Size = new System.Drawing.Size(224, 183);
            this.Tbp_Destination.Text = "Destination";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.Text = "Choisir la destination :";
            // 
            // Cbx_designation
            // 
            this.Cbx_designation.Items.Add("Parc A ");
            this.Cbx_designation.Items.Add("Parc B");
            this.Cbx_designation.Items.Add("Parc C");
            this.Cbx_designation.Items.Add("Parc D");
            this.Cbx_designation.Location = new System.Drawing.Point(20, 151);
            this.Cbx_designation.Name = "Cbx_designation";
            this.Cbx_designation.Size = new System.Drawing.Size(171, 23);
            this.Cbx_designation.TabIndex = 3;
            this.Cbx_designation.SelectedIndexChanged += new System.EventHandler(this.Cbx_designation_SelectedIndexChanged);
            // 
            // Cbx_destination
            // 
            this.Cbx_destination.Items.Add("Client");
            this.Cbx_destination.Items.Add("Parc");
            this.Cbx_destination.Location = new System.Drawing.Point(20, 122);
            this.Cbx_destination.Name = "Cbx_destination";
            this.Cbx_destination.Size = new System.Drawing.Size(171, 23);
            this.Cbx_destination.TabIndex = 2;
            this.Cbx_destination.SelectedIndexChanged += new System.EventHandler(this.Cbx_destination_SelectedIndexChanged);
            // 
            // Rbx_plusDest
            // 
            this.Rbx_plusDest.Location = new System.Drawing.Point(20, 25);
            this.Rbx_plusDest.Name = "Rbx_plusDest";
            this.Rbx_plusDest.Size = new System.Drawing.Size(171, 20);
            this.Rbx_plusDest.TabIndex = 1;
            this.Rbx_plusDest.TabStop = false;
            this.Rbx_plusDest.Text = "Plusieurs destinations";
            this.Rbx_plusDest.CheckedChanged += new System.EventHandler(this.Rbx_plusDest_CheckedChanged);
            // 
            // Rbx_uneDest
            // 
            this.Rbx_uneDest.Checked = true;
            this.Rbx_uneDest.Location = new System.Drawing.Point(20, 63);
            this.Rbx_uneDest.Name = "Rbx_uneDest";
            this.Rbx_uneDest.Size = new System.Drawing.Size(171, 20);
            this.Rbx_uneDest.TabIndex = 0;
            this.Rbx_uneDest.Text = "Une seule destination";
            // 
            // Tbp_Vehicules
            // 
            this.Tbp_Vehicules.AutoScroll = true;
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi8);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi7);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi6);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi5);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi4);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi3);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi2);
            this.Tbp_Vehicules.Controls.Add(this.paN_Char_Cam_Vehi1);
            this.Tbp_Vehicules.Controls.Add(this.Lbl_VehiculesCharges);
            this.Tbp_Vehicules.Controls.Add(this.label1);
            this.Tbp_Vehicules.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Vehicules.Name = "Tbp_Vehicules";
            this.Tbp_Vehicules.Size = new System.Drawing.Size(224, 183);
            this.Tbp_Vehicules.Text = "Véhicules";
            // 
            // paN_Char_Cam_Vehi8
            // 
            this.paN_Char_Cam_Vehi8.Location = new System.Drawing.Point(3, 487);
            this.paN_Char_Cam_Vehi8.Name = "paN_Char_Cam_Vehi8";
            this.paN_Char_Cam_Vehi8.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi8.TabIndex = 20;
            // 
            // paN_Char_Cam_Vehi7
            // 
            this.paN_Char_Cam_Vehi7.Location = new System.Drawing.Point(3, 421);
            this.paN_Char_Cam_Vehi7.Name = "paN_Char_Cam_Vehi7";
            this.paN_Char_Cam_Vehi7.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi7.TabIndex = 19;
            // 
            // paN_Char_Cam_Vehi6
            // 
            this.paN_Char_Cam_Vehi6.Location = new System.Drawing.Point(3, 355);
            this.paN_Char_Cam_Vehi6.Name = "paN_Char_Cam_Vehi6";
            this.paN_Char_Cam_Vehi6.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi6.TabIndex = 18;
            // 
            // paN_Char_Cam_Vehi5
            // 
            this.paN_Char_Cam_Vehi5.Location = new System.Drawing.Point(3, 289);
            this.paN_Char_Cam_Vehi5.Name = "paN_Char_Cam_Vehi5";
            this.paN_Char_Cam_Vehi5.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi5.TabIndex = 17;
            // 
            // paN_Char_Cam_Vehi4
            // 
            this.paN_Char_Cam_Vehi4.Location = new System.Drawing.Point(3, 223);
            this.paN_Char_Cam_Vehi4.Name = "paN_Char_Cam_Vehi4";
            this.paN_Char_Cam_Vehi4.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi4.TabIndex = 16;
            // 
            // paN_Char_Cam_Vehi3
            // 
            this.paN_Char_Cam_Vehi3.Location = new System.Drawing.Point(3, 157);
            this.paN_Char_Cam_Vehi3.Name = "paN_Char_Cam_Vehi3";
            this.paN_Char_Cam_Vehi3.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi3.TabIndex = 15;
            // 
            // paN_Char_Cam_Vehi2
            // 
            this.paN_Char_Cam_Vehi2.Location = new System.Drawing.Point(3, 91);
            this.paN_Char_Cam_Vehi2.Name = "paN_Char_Cam_Vehi2";
            this.paN_Char_Cam_Vehi2.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi2.TabIndex = 14;
            // 
            // paN_Char_Cam_Vehi1
            // 
            this.paN_Char_Cam_Vehi1.Location = new System.Drawing.Point(3, 25);
            this.paN_Char_Cam_Vehi1.Name = "paN_Char_Cam_Vehi1";
            this.paN_Char_Cam_Vehi1.Size = new System.Drawing.Size(203, 65);
            this.paN_Char_Cam_Vehi1.TabIndex = 4;
            // 
            // Lbl_VehiculesCharges
            // 
            this.Lbl_VehiculesCharges.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_VehiculesCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl_VehiculesCharges.Location = new System.Drawing.Point(157, 4);
            this.Lbl_VehiculesCharges.Name = "Lbl_VehiculesCharges";
            this.Lbl_VehiculesCharges.Size = new System.Drawing.Size(29, 20);
            this.Lbl_VehiculesCharges.Text = "14";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.Text = "Véhicules chargés :";
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Valider.ForeColor = System.Drawing.Color.Green;
            this.BTN_Valider.Location = new System.Drawing.Point(179, 218);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(55, 25);
            this.BTN_Valider.TabIndex = 1;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click_1);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(3, 217);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(55, 25);
            this.BTN_Annuler.TabIndex = 2;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click_1);
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(4, 246);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(231, 23);
            this.baR_Etat_Perso1.TabIndex = 3;
            // 
            // FEN_Char_Camions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.Tb_Crtl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Char_Camions";
            this.Text = "Sentinel : Transport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEN_Char_Camions_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FEN_Char_Camions_Closing);
            this.Tb_Crtl.ResumeLayout(false);
            this.Tbp_Camion.ResumeLayout(false);
            this.Tbp_Destination.ResumeLayout(false);
            this.Tbp_Vehicules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb_Crtl;
        private System.Windows.Forms.TabPage Tbp_Camion;
        private System.Windows.Forms.TabPage Tbp_Destination;
        private System.Windows.Forms.TabPage Tbp_Vehicules;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_VehiculesCharges;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi1;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi2;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi8;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi7;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi6;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi5;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi4;
        private Sentinel_Mobile.Presentation.UIComponents.PAN_Char_Cam_Vehi paN_Char_Cam_Vehi3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Rbx_uneDest;
        private System.Windows.Forms.RadioButton Rbx_plusDest;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Cbx_Chauffeur;
        public System.Windows.Forms.ComboBox Cbx_Camion;
        public System.Windows.Forms.ComboBox Cbx_Transporteur;
        public System.Windows.Forms.ComboBox Cbx_designation;
        public System.Windows.Forms.ComboBox Cbx_destination;
        private Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso baR_Etat_Perso1;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEN_Positionnement));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_Plateforme = new System.Windows.Forms.ComboBox();
            this.Cbx_Range = new System.Windows.Forms.ComboBox();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.LBL_Afficher_List = new System.Windows.Forms.LinkLabel();
            this.Nmrc_numPlace = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Zone = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_anomalie = new System.Windows.Forms.Button();
            this.pan_info_vehicule = new Sentinel_Mobile.Presentation.UIComponents.PAN_Info_Vehi();
            this.Btn_ajouter = new System.Windows.Forms.Button();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.Text = "Positionnement :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.Text = "Plateforme :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Rangé :";
            // 
            // Cbx_Plateforme
            // 
            this.Cbx_Plateforme.Location = new System.Drawing.Point(93, 149);
            this.Cbx_Plateforme.Name = "Cbx_Plateforme";
            this.Cbx_Plateforme.Size = new System.Drawing.Size(137, 23);
            this.Cbx_Plateforme.TabIndex = 6;
            this.Cbx_Plateforme.SelectedIndexChanged += new System.EventHandler(this.Cbx_Plateforme_SelectedIndexChanged);
            // 
            // Cbx_Range
            // 
            this.Cbx_Range.Location = new System.Drawing.Point(93, 179);
            this.Cbx_Range.Name = "Cbx_Range";
            this.Cbx_Range.Size = new System.Drawing.Size(71, 23);
            this.Cbx_Range.TabIndex = 9;
            this.Cbx_Range.SelectedIndexChanged += new System.EventHandler(this.Cbx_Range_SelectedIndexChanged);
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Valider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_Valider.Location = new System.Drawing.Point(158, 227);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(72, 20);
            this.BTN_Valider.TabIndex = 13;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(4, 229);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(72, 20);
            this.BTN_Annuler.TabIndex = 14;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // LBL_Afficher_List
            // 
            this.LBL_Afficher_List.Location = new System.Drawing.Point(147, 205);
            this.LBL_Afficher_List.Name = "LBL_Afficher_List";
            this.LBL_Afficher_List.Size = new System.Drawing.Size(100, 20);
            this.LBL_Afficher_List.TabIndex = 15;
            this.LBL_Afficher_List.Text = "Afficher la liste";
            this.LBL_Afficher_List.Click += new System.EventHandler(this.LBL_Afficher_List_Click);
            // 
            // Nmrc_numPlace
            // 
            this.Nmrc_numPlace.Location = new System.Drawing.Point(170, 178);
            this.Nmrc_numPlace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nmrc_numPlace.Name = "Nmrc_numPlace";
            this.Nmrc_numPlace.Size = new System.Drawing.Size(60, 24);
            this.Nmrc_numPlace.TabIndex = 20;
            this.Nmrc_numPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.Text = "Zone :";
            // 
            // Cbx_Zone
            // 
            this.Cbx_Zone.Location = new System.Drawing.Point(93, 121);
            this.Cbx_Zone.Name = "Cbx_Zone";
            this.Cbx_Zone.Size = new System.Drawing.Size(137, 23);
            this.Cbx_Zone.TabIndex = 23;
            this.Cbx_Zone.SelectedIndexChanged += new System.EventHandler(this.Cbx_Zone_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Btn_anomalie);
            this.panel1.Controls.Add(this.pan_info_vehicule);
            this.panel1.Controls.Add(this.Cbx_Zone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nmrc_numPlace);
            this.panel1.Controls.Add(this.LBL_Afficher_List);
            this.panel1.Controls.Add(this.BTN_Annuler);
            this.panel1.Controls.Add(this.BTN_Valider);
            this.panel1.Controls.Add(this.Btn_ajouter);
            this.panel1.Controls.Add(this.Cbx_Range);
            this.panel1.Controls.Add(this.Cbx_Plateforme);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 252);
            // 
            // Btn_anomalie
            // 
            this.Btn_anomalie.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_anomalie.ForeColor = System.Drawing.Color.Orange;
            this.Btn_anomalie.Location = new System.Drawing.Point(83, 64);
            this.Btn_anomalie.Name = "Btn_anomalie";
            this.Btn_anomalie.Size = new System.Drawing.Size(72, 20);
            this.Btn_anomalie.TabIndex = 38;
            this.Btn_anomalie.Text = "Anomalie";
            this.Btn_anomalie.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pan_info_vehicule
            // 
            this.pan_info_vehicule.Location = new System.Drawing.Point(10, 4);
            this.pan_info_vehicule.Name = "pan_info_vehicule";
            this.pan_info_vehicule.Size = new System.Drawing.Size(218, 72);
            this.pan_info_vehicule.TabIndex = 33;
            // 
            // Btn_ajouter
            // 
            this.Btn_ajouter.Location = new System.Drawing.Point(138, 92);
            this.Btn_ajouter.Name = "Btn_ajouter";
            this.Btn_ajouter.Size = new System.Drawing.Size(89, 20);
            this.Btn_ajouter.TabIndex = 12;
            this.Btn_ajouter.Text = "Ajouter";
            this.Btn_ajouter.Click += new System.EventHandler(this.BTN_Positionner_Click);
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
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Positionnement";
            this.Text = "Sentinel : Gestion du parc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEN_Positionnement_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FEN_Positionnement_Closing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Cbx_Plateforme;
        public System.Windows.Forms.ComboBox Cbx_Range;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.LinkLabel LBL_Afficher_List;
        public System.Windows.Forms.NumericUpDown Nmrc_numPlace;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Cbx_Zone;
        private System.Windows.Forms.Panel panel1;
        private PAN_Info_Vehi pan_info_vehicule;
        private System.Windows.Forms.Button Btn_ajouter;
        public System.Windows.Forms.Button Btn_anomalie;
    }
}
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEM_Mise_A_Jour
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
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.label1 = new System.Windows.Forms.Label();
            this.Chk_transport = new System.Windows.Forms.CheckBox();
            this.Chk_arrivage = new System.Windows.Forms.CheckBox();
            this.Chk_Anomalies = new System.Windows.Forms.CheckBox();
            this.Chk_PDS = new System.Windows.Forms.CheckBox();
            this.Chk_parc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(3, 244);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(231, 23);
            this.baR_Etat_Perso1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.Text = "Choisir les données à mêttre à jour :";
            // 
            // Chk_transport
            // 
            this.Chk_transport.Location = new System.Drawing.Point(3, 75);
            this.Chk_transport.Name = "Chk_transport";
            this.Chk_transport.Size = new System.Drawing.Size(209, 20);
            this.Chk_transport.TabIndex = 2;
            this.Chk_transport.Text = "Données de transport";
            // 
            // Chk_arrivage
            // 
            this.Chk_arrivage.Location = new System.Drawing.Point(3, 43);
            this.Chk_arrivage.Name = "Chk_arrivage";
            this.Chk_arrivage.Size = new System.Drawing.Size(177, 20);
            this.Chk_arrivage.TabIndex = 3;
            this.Chk_arrivage.Text = "Données des arrivages";
            // 
            // Chk_Anomalies
            // 
            this.Chk_Anomalies.Location = new System.Drawing.Point(3, 107);
            this.Chk_Anomalies.Name = "Chk_Anomalies";
            this.Chk_Anomalies.Size = new System.Drawing.Size(177, 20);
            this.Chk_Anomalies.TabIndex = 4;
            this.Chk_Anomalies.Text = "Données des anomalies";
            // 
            // Chk_PDS
            // 
            this.Chk_PDS.Location = new System.Drawing.Point(3, 171);
            this.Chk_PDS.Name = "Chk_PDS";
            this.Chk_PDS.Size = new System.Drawing.Size(135, 20);
            this.Chk_PDS.TabIndex = 5;
            this.Chk_PDS.Text = "Données PDS";
            // 
            // Chk_parc
            // 
            this.Chk_parc.Location = new System.Drawing.Point(3, 139);
            this.Chk_parc.Name = "Chk_parc";
            this.Chk_parc.Size = new System.Drawing.Size(209, 20);
            this.Chk_parc.TabIndex = 6;
            this.Chk_parc.Text = "Données de gestion du parc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mêttre à jour";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FEM_Mise_A_Jour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chk_parc);
            this.Controls.Add(this.Chk_PDS);
            this.Controls.Add(this.Chk_Anomalies);
            this.Controls.Add(this.Chk_arrivage);
            this.Controls.Add(this.Chk_transport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.Name = "FEM_Mise_A_Jour";
            this.Text = "Sentinel : Mise à jour";
            this.Load += new System.EventHandler(this.FEM_Mise_A_Jour_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox Chk_arrivage;
        public System.Windows.Forms.CheckBox Chk_transport;
        public System.Windows.Forms.CheckBox Chk_Anomalies;
        public System.Windows.Forms.CheckBox Chk_PDS;
        public System.Windows.Forms.CheckBox Chk_parc;
    }
}
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Connexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_utilisateur = new System.Windows.Forms.TextBox();
            this.Txt_mot_passe = new System.Windows.Forms.TextBox();
            this.Btn_Connexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.Text = "Mot de passe";
            // 
            // Txt_utilisateur
            // 
            this.Txt_utilisateur.Location = new System.Drawing.Point(13, 32);
            this.Txt_utilisateur.Name = "Txt_utilisateur";
            this.Txt_utilisateur.Size = new System.Drawing.Size(188, 23);
            this.Txt_utilisateur.TabIndex = 3;
            this.Txt_utilisateur.Text = "amine";
            // 
            // Txt_mot_passe
            // 
            this.Txt_mot_passe.Location = new System.Drawing.Point(13, 90);
            this.Txt_mot_passe.Name = "Txt_mot_passe";
            this.Txt_mot_passe.PasswordChar = '*';
            this.Txt_mot_passe.Size = new System.Drawing.Size(188, 23);
            this.Txt_mot_passe.TabIndex = 4;
            this.Txt_mot_passe.Text = "abc123";
            // 
            // Btn_Connexion
            // 
            this.Btn_Connexion.Location = new System.Drawing.Point(129, 128);
            this.Btn_Connexion.Name = "Btn_Connexion";
            this.Btn_Connexion.Size = new System.Drawing.Size(72, 20);
            this.Btn_Connexion.TabIndex = 5;
            this.Btn_Connexion.Text = "Connexion";
            this.Btn_Connexion.Click += new System.EventHandler(this.Btn_Connexion_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.Text = "Message d\'erreur";
            this.label3.Visible = false;
            // 
            // FEN_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(217, 157);
            this.Controls.Add(this.Btn_Connexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_mot_passe);
            this.Controls.Add(this.Txt_utilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Connexion";
            this.Text = "Sentinel : Connexion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_utilisateur;
        private System.Windows.Forms.TextBox Txt_mot_passe;
        private System.Windows.Forms.Button Btn_Connexion;
        private System.Windows.Forms.Label label3;
    }
}
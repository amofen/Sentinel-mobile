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
            this.Lbl_msg = new System.Windows.Forms.Label();
            this.Cbx_Affectation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.Text = "Mot de passe";
            // 
            // Txt_utilisateur
            // 
            this.Txt_utilisateur.Location = new System.Drawing.Point(13, 77);
            this.Txt_utilisateur.Name = "Txt_utilisateur";
            this.Txt_utilisateur.Size = new System.Drawing.Size(188, 23);
            this.Txt_utilisateur.TabIndex = 3;
            this.Txt_utilisateur.Text = "amine";
            // 
            // Txt_mot_passe
            // 
            this.Txt_mot_passe.Location = new System.Drawing.Point(13, 127);
            this.Txt_mot_passe.Name = "Txt_mot_passe";
            this.Txt_mot_passe.PasswordChar = '*';
            this.Txt_mot_passe.Size = new System.Drawing.Size(188, 23);
            this.Txt_mot_passe.TabIndex = 4;
            this.Txt_mot_passe.Text = "abc123";
            // 
            // Btn_Connexion
            // 
            this.Btn_Connexion.Location = new System.Drawing.Point(129, 166);
            this.Btn_Connexion.Name = "Btn_Connexion";
            this.Btn_Connexion.Size = new System.Drawing.Size(72, 20);
            this.Btn_Connexion.TabIndex = 5;
            this.Btn_Connexion.Text = "Connexion";
            this.Btn_Connexion.Click += new System.EventHandler(this.Btn_Connexion_Click);
            // 
            // Lbl_msg
            // 
            this.Lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.Lbl_msg.Location = new System.Drawing.Point(16, 148);
            this.Lbl_msg.Name = "Lbl_msg";
            this.Lbl_msg.Size = new System.Drawing.Size(128, 20);
            this.Lbl_msg.Text = "Message d\'erreur";
            this.Lbl_msg.Visible = false;
            // 
            // Cbx_Affectation
            // 
            this.Cbx_Affectation.Location = new System.Drawing.Point(13, 28);
            this.Cbx_Affectation.Name = "Cbx_Affectation";
            this.Cbx_Affectation.Size = new System.Drawing.Size(185, 23);
            this.Cbx_Affectation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Affectation";
            // 
            // FEN_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(217, 192);
            this.Controls.Add(this.Cbx_Affectation);
            this.Controls.Add(this.Btn_Connexion);
            this.Controls.Add(this.Txt_mot_passe);
            this.Controls.Add(this.Txt_utilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_msg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Connexion";
            this.Text = "Sentinel : Connexion";
            this.Load += new System.EventHandler(this.FEN_Connexion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_utilisateur;
        private System.Windows.Forms.TextBox Txt_mot_passe;
        private System.Windows.Forms.Button Btn_Connexion;
        private System.Windows.Forms.Label Lbl_msg;
        private System.Windows.Forms.ComboBox Cbx_Affectation;
        private System.Windows.Forms.Label label4;
    }
}
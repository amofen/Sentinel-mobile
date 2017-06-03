namespace Sentinel_Mobile.Presentation.UIComponents
{
    partial class PAN_Char_Cam_Vehi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Lbl_couleur = new System.Windows.Forms.Label();
            this.Lbl_Chasis = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_anomalie = new System.Windows.Forms.Button();
            this.Lbl_destination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Model.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Model.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_Model.Location = new System.Drawing.Point(29, -2);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(164, 22);
            this.Lbl_Model.Text = "Volkswagen Golf 7";
            this.Lbl_Model.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_couleur
            // 
            this.Lbl_couleur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_couleur.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_couleur.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_couleur.Location = new System.Drawing.Point(17, 15);
            this.Lbl_couleur.Name = "Lbl_couleur";
            this.Lbl_couleur.Size = new System.Drawing.Size(177, 22);
            this.Lbl_couleur.Text = "Bleu";
            this.Lbl_couleur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Chasis
            // 
            this.Lbl_Chasis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Chasis.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_Chasis.Location = new System.Drawing.Point(24, 30);
            this.Lbl_Chasis.Name = "Lbl_Chasis";
            this.Lbl_Chasis.Size = new System.Drawing.Size(168, 22);
            this.Lbl_Chasis.Text = "WWSAZ145267YHTGDR";
            this.Lbl_Chasis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_Numero.Location = new System.Drawing.Point(1, 20);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(21, 22);
            this.Lbl_Numero.Text = "1";
            this.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_supprimer.ForeColor = System.Drawing.Color.Red;
            this.Btn_supprimer.Location = new System.Drawing.Point(183, 1);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(19, 18);
            this.Btn_supprimer.TabIndex = 4;
            this.Btn_supprimer.Text = "S";
            this.Btn_supprimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_anomalie
            // 
            this.Btn_anomalie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_anomalie.ForeColor = System.Drawing.Color.DarkOrange;
            this.Btn_anomalie.Location = new System.Drawing.Point(183, 44);
            this.Btn_anomalie.Name = "Btn_anomalie";
            this.Btn_anomalie.Size = new System.Drawing.Size(19, 18);
            this.Btn_anomalie.TabIndex = 9;
            this.Btn_anomalie.Text = "A";
            this.Btn_anomalie.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_destination
            // 
            this.Lbl_destination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_destination.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_destination.Location = new System.Drawing.Point(35, 46);
            this.Lbl_destination.Name = "Lbl_destination";
            this.Lbl_destination.Size = new System.Drawing.Size(136, 18);
            this.Lbl_destination.Text = "Destination";
            this.Lbl_destination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PAN_Char_Cam_Vehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lbl_destination);
            this.Controls.Add(this.Btn_anomalie);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Lbl_Numero);
            this.Controls.Add(this.Lbl_Chasis);
            this.Controls.Add(this.Lbl_couleur);
            this.Controls.Add(this.Lbl_Model);
            this.Name = "PAN_Char_Cam_Vehi";
            this.Size = new System.Drawing.Size(203, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Model;
        private System.Windows.Forms.Label Lbl_couleur;
        private System.Windows.Forms.Label Lbl_Chasis;
        private System.Windows.Forms.Button Btn_supprimer;
        public System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Button Btn_anomalie;
        private System.Windows.Forms.Label Lbl_destination;
    }
}

namespace Sentinel_Mobile.Presentation.UIComponents
{
    partial class BAR_Etat_Perso
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
            this.LBL_Status = new System.Windows.Forms.Label();
            this.LBL_Utilisateur = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // LBL_Status
            // 
            this.LBL_Status.ForeColor = System.Drawing.Color.Orange;
            this.LBL_Status.Location = new System.Drawing.Point(3, 1);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(67, 20);
            this.LBL_Status.Text = "Indéfini";
            // 
            // LBL_Utilisateur
            // 
            this.LBL_Utilisateur.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LBL_Utilisateur.Location = new System.Drawing.Point(73, 1);
            this.LBL_Utilisateur.Name = "LBL_Utilisateur";
            this.LBL_Utilisateur.Size = new System.Drawing.Size(84, 20);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(221, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BAR_Etat_Perso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LBL_Utilisateur);
            this.Controls.Add(this.LBL_Status);
            this.Name = "BAR_Etat_Perso";
            this.Size = new System.Drawing.Size(240, 20);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LBL_Status;
        public System.Windows.Forms.Label LBL_Utilisateur;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Timer timer1;
    }
}

namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Splash_Chargement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEN_Splash_Chargement));
            this.Lbl_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.Lbl_chargement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_message
            // 
            resources.ApplyResources(this.Lbl_message, "Lbl_message");
            this.Lbl_message.Name = "Lbl_message";
            this.Lbl_message.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_chargement
            // 
            resources.ApplyResources(this.Lbl_chargement, "Lbl_chargement");
            this.Lbl_chargement.Name = "Lbl_chargement";
            // 
            // FEN_Splash_Chargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Lbl_chargement);
            this.Controls.Add(this.Lbl_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FEN_Splash_Chargement";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FEN_Splash_Chargement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_chargement;
    }
}
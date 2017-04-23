namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.BTN_Parametres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Parametres
            // 
            this.BTN_Parametres.Location = new System.Drawing.Point(72, 33);
            this.BTN_Parametres.Name = "BTN_Parametres";
            this.BTN_Parametres.Size = new System.Drawing.Size(49, 36);
            this.BTN_Parametres.TabIndex = 5;
            this.BTN_Parametres.Text = "Param";
            this.BTN_Parametres.Click += new System.EventHandler(this.BTN_Parametres_Click_1);
            // 
            // FEN_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(207, 237);
            this.Controls.Add(this.BTN_Parametres);
            this.Menu = this.mainMenu1;
            this.Name = "FEN_Test";
            this.Text = "FEN_Test";
            this.Load += new System.EventHandler(this.FEN_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Parametres;


    }
}
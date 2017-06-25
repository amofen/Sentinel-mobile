using Sentinel_Mobile.Presentation.UIComponents;
namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Principale
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
            this.BTN_Check = new System.Windows.Forms.Button();
            this.BTN_Chargement = new System.Windows.Forms.Button();
            this.BTN_PDS = new System.Windows.Forms.Button();
            this.BTN_Positionnement = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Check
            // 
            this.BTN_Check.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Check.Location = new System.Drawing.Point(52, 63);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(143, 36);
            this.BTN_Check.TabIndex = 1;
            this.BTN_Check.Text = "Arrivages";
            this.BTN_Check.Click += new System.EventHandler(this.BTN_Check_Click);
            // 
            // BTN_Chargement
            // 
            this.BTN_Chargement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Chargement.Location = new System.Drawing.Point(52, 106);
            this.BTN_Chargement.Name = "BTN_Chargement";
            this.BTN_Chargement.Size = new System.Drawing.Size(143, 36);
            this.BTN_Chargement.TabIndex = 2;
            this.BTN_Chargement.Text = "Transport";
            this.BTN_Chargement.Click += new System.EventHandler(this.BTN_Chargement_Click);
            // 
            // BTN_PDS
            // 
            this.BTN_PDS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_PDS.Location = new System.Drawing.Point(52, 192);
            this.BTN_PDS.Name = "BTN_PDS";
            this.BTN_PDS.Size = new System.Drawing.Size(143, 36);
            this.BTN_PDS.TabIndex = 3;
            this.BTN_PDS.Text = "PDS";
            this.BTN_PDS.Click += new System.EventHandler(this.BTN_PDS_Click);
            // 
            // BTN_Positionnement
            // 
            this.BTN_Positionnement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Positionnement.Location = new System.Drawing.Point(52, 150);
            this.BTN_Positionnement.Name = "BTN_Positionnement";
            this.BTN_Positionnement.Size = new System.Drawing.Size(143, 36);
            this.BTN_Positionnement.TabIndex = 6;
            this.BTN_Positionnement.Text = "Gestion du parc";
            this.BTN_Positionnement.Click += new System.EventHandler(this.BTN_Positionnement_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            this.mainMenu1.MenuItems.Add(this.menuItem5);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.Text = "Sentinel";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Deconnexion";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Quitter";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuItem8);
            this.menuItem4.MenuItems.Add(this.menuItem6);
            this.menuItem4.MenuItems.Add(this.menuItem7);
            this.menuItem4.Text = "Mise à jour";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Cache";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Arrivages";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Opérations transport";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.MenuItems.Add(this.menuItem9);
            this.menuItem5.Text = "?";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "A propos";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // baR_Etat_Perso1
            // 
            this.baR_Etat_Perso1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baR_Etat_Perso1.Location = new System.Drawing.Point(3, 244);
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            this.baR_Etat_Perso1.Size = new System.Drawing.Size(232, 23);
            this.baR_Etat_Perso1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.Text = "SENT";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(126, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.Text = "INEL";
            // 
            // FEN_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Positionnement);
            this.Controls.Add(this.BTN_PDS);
            this.Controls.Add(this.BTN_Chargement);
            this.Controls.Add(this.BTN_Check);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "FEN_Principale";
            this.Text = "Sentinel : Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEN_Principale_Load);
            this.Closed += new System.EventHandler(this.FEN_Principale_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Button BTN_Check;
        private System.Windows.Forms.Button BTN_Chargement;
        private System.Windows.Forms.Button BTN_PDS;
        private System.Windows.Forms.Button BTN_Positionnement;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
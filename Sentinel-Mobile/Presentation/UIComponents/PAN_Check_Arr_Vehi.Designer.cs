namespace Sentinel_Mobile.Presentation.UIComponents
{
    partial class PAN_Check_Arr_Vehi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Num_Chassis = new System.Windows.Forms.Label();
            this.LBL_Model = new System.Windows.Forms.Label();
            this.DEC_Controleur = new Honeywell.DataCollection.WinCE.Decoding.DecodeControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Lot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.Text = "Numéro de châssis :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.Text = "Modèle :";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // LBL_Num_Chassis
            // 
            this.LBL_Num_Chassis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Num_Chassis.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.LBL_Num_Chassis.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBL_Num_Chassis.Location = new System.Drawing.Point(-3, 31);
            this.LBL_Num_Chassis.Name = "LBL_Num_Chassis";
            this.LBL_Num_Chassis.Size = new System.Drawing.Size(218, 20);
            this.LBL_Num_Chassis.Text = "-";
            this.LBL_Num_Chassis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_Num_Chassis.ParentChanged += new System.EventHandler(this.LBL_Num_Chassis_ParentChanged);
            // 
            // LBL_Model
            // 
            this.LBL_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Model.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBL_Model.Location = new System.Drawing.Point(0, 70);
            this.LBL_Model.Name = "LBL_Model";
            this.LBL_Model.Size = new System.Drawing.Size(218, 22);
            this.LBL_Model.Text = "-";
            this.LBL_Model.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DEC_Controleur
            // 
            this.DEC_Controleur.AimerTimeout = 0;
            this.DEC_Controleur.AimIDDisplay = true;
            this.DEC_Controleur.AudioMode = Honeywell.DataCollection.Decoding.AudioDevice.SND_STANDARD;
            this.DEC_Controleur.AutoLEDs = true;
            this.DEC_Controleur.AutoScan = true;
            this.DEC_Controleur.AutoSounds = true;
            this.DEC_Controleur.CodeIDDisplay = false;
            this.DEC_Controleur.ContinuousScan = false;
            this.DEC_Controleur.DecodeAttemptLimit = 800;
            this.DEC_Controleur.DecodeMode = Honeywell.DataCollection.Decoding.DecodeMode.DM_STANDARD;
            this.DEC_Controleur.LightsMode = Honeywell.DataCollection.Decoding.ScanLightsMode.LM_ILLUM_AIMER;
            this.DEC_Controleur.LinearRange = 3;
            this.DEC_Controleur.Location = new System.Drawing.Point(61, 53);
            this.DEC_Controleur.ModifierDisplay = false;
            this.DEC_Controleur.Multiline = true;
            this.DEC_Controleur.Name = "DEC_Controleur";
            this.DEC_Controleur.PrintWeight = 4;
            this.DEC_Controleur.ScanTimeout = 5000;
            this.DEC_Controleur.SearchTimeLimit = 400;
            this.DEC_Controleur.Size = new System.Drawing.Size(100, 20);
            this.DEC_Controleur.TabIndex = 9;
            this.DEC_Controleur.TabStop = false;
            this.DEC_Controleur.TraceMode = false;
            this.DEC_Controleur.TriggerKey = Honeywell.DataCollection.WinCE.Decoding.TriggerKeyEnum.TK_ONSCAN;
            this.DEC_Controleur.VideoReverse = false;
            this.DEC_Controleur.VirtualKeyMode = false;
            this.DEC_Controleur.VirtualKeyTerm = Honeywell.DataCollection.Decoding.VirtualKeyTermEnum.VK_NONE;
            this.DEC_Controleur.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.Text = "Véhicule En Cours";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.Text = "N° Lot :";
            // 
            // Lbl_Lot
            // 
            this.Lbl_Lot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lot.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_Lot.Location = new System.Drawing.Point(0, 99);
            this.Lbl_Lot.Name = "Lbl_Lot";
            this.Lbl_Lot.Size = new System.Drawing.Size(218, 22);
            this.Lbl_Lot.Text = "-";
            this.Lbl_Lot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PAN_Check_Arr_Vehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lbl_Lot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DEC_Controleur);
            this.Controls.Add(this.LBL_Model);
            this.Controls.Add(this.LBL_Num_Chassis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PAN_Check_Arr_Vehi";
            this.Size = new System.Drawing.Size(218, 122);
            this.Click += new System.EventHandler(this.PAN_Check_Arr_Vehi_Click_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Model;
        private System.Windows.Forms.Label label3;
        public Honeywell.DataCollection.WinCE.Decoding.DecodeControl DEC_Controleur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Lot;
        private System.Windows.Forms.Label LBL_Num_Chassis;
    }
}

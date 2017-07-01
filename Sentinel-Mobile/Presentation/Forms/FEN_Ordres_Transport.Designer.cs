namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Ordres_Transport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEN_Ordres_Transport));
            this.Btn_Imprimmer = new System.Windows.Forms.Button();
            this.Btn_Programmer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grd_Op = new System.Windows.Forms.DataGrid();
            this.Rbx_Reception = new System.Windows.Forms.RadioButton();
            this.Rbx_Chargement = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.baR_Etat_Perso1 = new Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Imprimmer
            // 
            resources.ApplyResources(this.Btn_Imprimmer, "Btn_Imprimmer");
            this.Btn_Imprimmer.Name = "Btn_Imprimmer";
            this.Btn_Imprimmer.Click += new System.EventHandler(this.Btn_Imprimmer_Click);
            // 
            // Btn_Programmer
            // 
            resources.ApplyResources(this.Btn_Programmer, "Btn_Programmer");
            this.Btn_Programmer.Name = "Btn_Programmer";
            this.Btn_Programmer.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // Grd_Op
            // 
            this.Grd_Op.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.Grd_Op, "Grd_Op");
            this.Grd_Op.Name = "Grd_Op";
            this.Grd_Op.CurrentCellChanged += new System.EventHandler(this.Grd_Op_CurrentCellChanged);
            // 
            // Rbx_Reception
            // 
            resources.ApplyResources(this.Rbx_Reception, "Rbx_Reception");
            this.Rbx_Reception.Name = "Rbx_Reception";
            this.Rbx_Reception.TabStop = false;
            // 
            // Rbx_Chargement
            // 
            this.Rbx_Chargement.Checked = true;
            resources.ApplyResources(this.Rbx_Chargement, "Rbx_Chargement");
            this.Rbx_Chargement.Name = "Rbx_Chargement";
            this.Rbx_Chargement.CheckedChanged += new System.EventHandler(this.Rbx_Chargement_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // baR_Etat_Perso1
            // 
            resources.ApplyResources(this.baR_Etat_Perso1, "baR_Etat_Perso1");
            this.baR_Etat_Perso1.Name = "baR_Etat_Perso1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FEN_Ordres_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rbx_Chargement);
            this.Controls.Add(this.Rbx_Reception);
            this.Controls.Add(this.Grd_Op);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baR_Etat_Perso1);
            this.Controls.Add(this.Btn_Programmer);
            this.Controls.Add(this.Btn_Imprimmer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Ordres_Transport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEN_Ordres_Transport_Load);
            this.Closed += new System.EventHandler(this.FEN_Ordres_Transport_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FEN_Ordres_Transport_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Imprimmer;
        private System.Windows.Forms.Button Btn_Programmer;
        private Sentinel_Mobile.Presentation.UIComponents.BAR_Etat_Perso baR_Etat_Perso1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid Grd_Op;
        private System.Windows.Forms.RadioButton Rbx_Reception;
        private System.Windows.Forms.RadioButton Rbx_Chargement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
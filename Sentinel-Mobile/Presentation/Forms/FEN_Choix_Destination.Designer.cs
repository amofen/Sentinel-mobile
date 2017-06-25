namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Choix_Destination
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
            this.label5 = new System.Windows.Forms.Label();
            this.Cbx_designation = new System.Windows.Forms.ComboBox();
            this.Cbx_destination = new System.Windows.Forms.ComboBox();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.Text = "Choisissez la destination :";
            this.label5.ParentChanged += new System.EventHandler(this.label5_ParentChanged);
            // 
            // Cbx_designation
            // 
            this.Cbx_designation.Items.Add("Parc A ");
            this.Cbx_designation.Items.Add("Parc B");
            this.Cbx_designation.Items.Add("Parc C");
            this.Cbx_designation.Items.Add("Parc D");
            this.Cbx_designation.Location = new System.Drawing.Point(4, 59);
            this.Cbx_designation.Name = "Cbx_designation";
            this.Cbx_designation.Size = new System.Drawing.Size(161, 23);
            this.Cbx_designation.TabIndex = 6;
            // 
            // Cbx_destination
            // 
            this.Cbx_destination.Items.Add("Client");
            this.Cbx_destination.Items.Add("Parc");
            this.Cbx_destination.Location = new System.Drawing.Point(3, 28);
            this.Cbx_destination.Name = "Cbx_destination";
            this.Cbx_destination.Size = new System.Drawing.Size(162, 23);
            this.Cbx_destination.TabIndex = 5;
            this.Cbx_destination.SelectedIndexChanged += new System.EventHandler(this.Cbx_destination_SelectedIndexChanged_1);
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Valider.ForeColor = System.Drawing.Color.Green;
            this.BTN_Valider.Location = new System.Drawing.Point(114, 86);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(55, 25);
            this.BTN_Valider.TabIndex = 7;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(4, 86);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(55, 25);
            this.BTN_Annuler.TabIndex = 8;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // FEN_Choix_Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(174, 117);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbx_designation);
            this.Controls.Add(this.Cbx_destination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(40, 40);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Choix_Destination";
            this.Text = "Destination";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FEN_Choix_Destination_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Cbx_designation;
        public System.Windows.Forms.ComboBox Cbx_destination;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}
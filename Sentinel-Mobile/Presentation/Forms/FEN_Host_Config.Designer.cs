namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Host_Config
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
            this.Txt_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.Text = "Host :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_Host
            // 
            this.Txt_Host.Location = new System.Drawing.Point(50, 4);
            this.Txt_Host.Name = "Txt_Host";
            this.Txt_Host.Size = new System.Drawing.Size(153, 23);
            this.Txt_Host.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.Text = "Port :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Valider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_Valider.Location = new System.Drawing.Point(131, 66);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(72, 20);
            this.BTN_Valider.TabIndex = 14;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BTN_Annuler.Location = new System.Drawing.Point(3, 66);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(72, 20);
            this.BTN_Annuler.TabIndex = 15;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // Txt_Port
            // 
            this.Txt_Port.Location = new System.Drawing.Point(50, 33);
            this.Txt_Port.MaxLength = 5;
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(85, 23);
            this.Txt_Port.TabIndex = 18;
            // 
            // FEN_Host_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(216, 89);
            this.Controls.Add(this.Txt_Port);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Host);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(40, 60);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_Host_Config";
            this.Text = "Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FEN_Host_Config_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.TextBox Txt_Port;
    }
}
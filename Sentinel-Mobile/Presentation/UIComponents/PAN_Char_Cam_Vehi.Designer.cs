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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Chasis = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Model.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_Model.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_Model.Location = new System.Drawing.Point(29, 2);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(164, 22);
            this.Lbl_Model.Text = "Volkswagen Golf 7";
            this.Lbl_Model.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.Text = "Bleu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Chasis
            // 
            this.Lbl_Chasis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Chasis.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_Chasis.Location = new System.Drawing.Point(24, 41);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(181, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 18);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PAN_Char_Cam_Vehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Numero);
            this.Controls.Add(this.Lbl_Chasis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Model);
            this.Name = "PAN_Char_Cam_Vehi";
            this.Size = new System.Drawing.Size(203, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Chasis;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Lbl_Numero;
    }
}

namespace Sentinel_Mobile.Presentation.UIComponents
{
    partial class PAN_Info_Vehi
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
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Model = new System.Windows.Forms.Label();
            this.LBL_Num_Chassis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.Text = "Véhicule En Cours";
            // 
            // LBL_Model
            // 
            this.LBL_Model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Model.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBL_Model.Location = new System.Drawing.Point(24, 43);
            this.LBL_Model.Name = "LBL_Model";
            this.LBL_Model.Size = new System.Drawing.Size(165, 22);
            this.LBL_Model.Text = "-";
            this.LBL_Model.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Num_Chassis
            // 
            this.LBL_Num_Chassis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Num_Chassis.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.LBL_Num_Chassis.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBL_Num_Chassis.Location = new System.Drawing.Point(-1, 21);
            this.LBL_Num_Chassis.Name = "LBL_Num_Chassis";
            this.LBL_Num_Chassis.Size = new System.Drawing.Size(218, 22);
            this.LBL_Num_Chassis.Text = "-";
            this.LBL_Num_Chassis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PAN_Info_Vehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_Model);
            this.Controls.Add(this.LBL_Num_Chassis);
            this.Name = "PAN_Info_Vehi";
            this.Size = new System.Drawing.Size(216, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Model;
        private System.Windows.Forms.Label LBL_Num_Chassis;
    }
}

namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_List_Vehi_Pos
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
            this.Lst_placeRangee = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lst_placeRangee
            // 
            this.Lst_placeRangee.Items.Add("KJSKQDKJSQDKSQD - Golf 7 - PARC SD A12-123");
            this.Lst_placeRangee.Location = new System.Drawing.Point(0, 0);
            this.Lst_placeRangee.Name = "Lst_placeRangee";
            this.Lst_placeRangee.Size = new System.Drawing.Size(307, 194);
            this.Lst_placeRangee.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Lst_placeRangee);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 203);
            // 
            // FEN_List_Vehi_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(218, 235);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "FEN_List_Vehi_Pos";
            this.Text = "FEN_List_Vehi_Pos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_placeRangee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;




    }
}
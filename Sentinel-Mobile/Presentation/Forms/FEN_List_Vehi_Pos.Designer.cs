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
            this.button1 = new System.Windows.Forms.Button();
            this.Grd_List_Posi = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grd_List_Posi
            // 
            this.Grd_List_Posi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Grd_List_Posi.Location = new System.Drawing.Point(7, 24);
            this.Grd_List_Posi.Name = "Grd_List_Posi";
            this.Grd_List_Posi.Size = new System.Drawing.Size(205, 152);
            this.Grd_List_Posi.TabIndex = 1;
            this.Grd_List_Posi.CurrentCellChanged += new System.EventHandler(this.Grd_List_Posi_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.Text = "Positionnements:";
            // 
            // FEN_List_Vehi_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(218, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grd_List_Posi);
            this.Controls.Add(this.button1);
            this.Name = "FEN_List_Vehi_Pos";
            this.Text = "FEN_List_Vehi_Pos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGrid Grd_List_Posi;
        private System.Windows.Forms.Label label1;




    }
}
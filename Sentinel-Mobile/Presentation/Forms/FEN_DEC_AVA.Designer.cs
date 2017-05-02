namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_DEC_AVA
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
            this.Tb_manque = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Chk_mnq_autre = new System.Windows.Forms.CheckBox();
            this.Chk_accessoire = new System.Windows.Forms.CheckBox();
            this.Chk_caroroserie = new System.Windows.Forms.CheckBox();
            this.Chk_piece = new System.Windows.Forms.CheckBox();
            this.Tb_avarie = new System.Windows.Forms.TabPage();
            this.Chk_egratignure = new System.Windows.Forms.CheckBox();
            this.Chk_ava_autre = new System.Windows.Forms.CheckBox();
            this.Chk_cassure = new System.Windows.Forms.CheckBox();
            this.Chk_eraflure = new System.Windows.Forms.CheckBox();
            this.Chk_brulure = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tb_manque.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Tb_avarie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_manque
            // 
            this.Tb_manque.Controls.Add(this.tabPage1);
            this.Tb_manque.Controls.Add(this.Tb_avarie);
            this.Tb_manque.Location = new System.Drawing.Point(0, 3);
            this.Tb_manque.Name = "Tb_manque";
            this.Tb_manque.SelectedIndex = 0;
            this.Tb_manque.Size = new System.Drawing.Size(152, 186);
            this.Tb_manque.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Chk_mnq_autre);
            this.tabPage1.Controls.Add(this.Chk_accessoire);
            this.tabPage1.Controls.Add(this.Chk_caroroserie);
            this.tabPage1.Controls.Add(this.Chk_piece);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(144, 157);
            this.tabPage1.Text = "Manque";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Chk_mnq_autre
            // 
            this.Chk_mnq_autre.Location = new System.Drawing.Point(3, 98);
            this.Chk_mnq_autre.Name = "Chk_mnq_autre";
            this.Chk_mnq_autre.Size = new System.Drawing.Size(100, 20);
            this.Chk_mnq_autre.TabIndex = 3;
            this.Chk_mnq_autre.Tag = "MAN4";
            this.Chk_mnq_autre.Text = "Autre";
            // 
            // Chk_accessoire
            // 
            this.Chk_accessoire.Location = new System.Drawing.Point(3, 72);
            this.Chk_accessoire.Name = "Chk_accessoire";
            this.Chk_accessoire.Size = new System.Drawing.Size(100, 20);
            this.Chk_accessoire.TabIndex = 2;
            this.Chk_accessoire.Tag = "MAN3";
            this.Chk_accessoire.Text = "Accessoire";
            this.Chk_accessoire.CheckStateChanged += new System.EventHandler(this.Chk_accessoire_CheckStateChanged);
            // 
            // Chk_caroroserie
            // 
            this.Chk_caroroserie.Location = new System.Drawing.Point(3, 46);
            this.Chk_caroroserie.Name = "Chk_caroroserie";
            this.Chk_caroroserie.Size = new System.Drawing.Size(100, 20);
            this.Chk_caroroserie.TabIndex = 1;
            this.Chk_caroroserie.Tag = "MAN2";
            this.Chk_caroroserie.Text = "Carroserie";
            // 
            // Chk_piece
            // 
            this.Chk_piece.Location = new System.Drawing.Point(3, 20);
            this.Chk_piece.Name = "Chk_piece";
            this.Chk_piece.Size = new System.Drawing.Size(131, 20);
            this.Chk_piece.TabIndex = 0;
            this.Chk_piece.Tag = "MAN1";
            this.Chk_piece.Text = "Pièce mécanique";
            this.Chk_piece.CheckStateChanged += new System.EventHandler(this.Chk_piece_CheckStateChanged);
            // 
            // Tb_avarie
            // 
            this.Tb_avarie.Controls.Add(this.Chk_egratignure);
            this.Tb_avarie.Controls.Add(this.Chk_ava_autre);
            this.Tb_avarie.Controls.Add(this.Chk_cassure);
            this.Tb_avarie.Controls.Add(this.Chk_eraflure);
            this.Tb_avarie.Controls.Add(this.Chk_brulure);
            this.Tb_avarie.Location = new System.Drawing.Point(4, 25);
            this.Tb_avarie.Name = "Tb_avarie";
            this.Tb_avarie.Size = new System.Drawing.Size(144, 157);
            this.Tb_avarie.Text = "Avarie";
            // 
            // Chk_egratignure
            // 
            this.Chk_egratignure.Location = new System.Drawing.Point(3, 92);
            this.Chk_egratignure.Name = "Chk_egratignure";
            this.Chk_egratignure.Size = new System.Drawing.Size(100, 20);
            this.Chk_egratignure.TabIndex = 4;
            this.Chk_egratignure.Tag = "AVA4";
            this.Chk_egratignure.Text = "Egratignure";
            // 
            // Chk_ava_autre
            // 
            this.Chk_ava_autre.Location = new System.Drawing.Point(3, 118);
            this.Chk_ava_autre.Name = "Chk_ava_autre";
            this.Chk_ava_autre.Size = new System.Drawing.Size(100, 20);
            this.Chk_ava_autre.TabIndex = 3;
            this.Chk_ava_autre.Tag = "AVA5";
            this.Chk_ava_autre.Text = "Autre";
            // 
            // Chk_cassure
            // 
            this.Chk_cassure.Location = new System.Drawing.Point(3, 66);
            this.Chk_cassure.Name = "Chk_cassure";
            this.Chk_cassure.Size = new System.Drawing.Size(100, 20);
            this.Chk_cassure.TabIndex = 2;
            this.Chk_cassure.Tag = "AVA3";
            this.Chk_cassure.Text = "Cassure";
            // 
            // Chk_eraflure
            // 
            this.Chk_eraflure.Location = new System.Drawing.Point(3, 14);
            this.Chk_eraflure.Name = "Chk_eraflure";
            this.Chk_eraflure.Size = new System.Drawing.Size(100, 20);
            this.Chk_eraflure.TabIndex = 1;
            this.Chk_eraflure.Tag = "AVA1";
            this.Chk_eraflure.Text = "Eraflure";
            // 
            // Chk_brulure
            // 
            this.Chk_brulure.Location = new System.Drawing.Point(3, 40);
            this.Chk_brulure.Name = "Chk_brulure";
            this.Chk_brulure.Size = new System.Drawing.Size(100, 20);
            this.Chk_brulure.TabIndex = 0;
            this.Chk_brulure.Tag = "AVA2";
            this.Chk_brulure.Text = "Brulure";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(4, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Annuler";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(91, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Valider";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FEN_DEC_AVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(157, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_manque);
            this.Location = new System.Drawing.Point(25, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEN_DEC_AVA";
            this.Text = "Anomalies";
            this.TopMost = true;
            this.Tb_manque.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Tb_avarie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb_manque;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Tb_avarie;
        private System.Windows.Forms.CheckBox Chk_accessoire;
        private System.Windows.Forms.CheckBox Chk_caroroserie;
        private System.Windows.Forms.CheckBox Chk_piece;
        private System.Windows.Forms.CheckBox Chk_ava_autre;
        private System.Windows.Forms.CheckBox Chk_cassure;
        private System.Windows.Forms.CheckBox Chk_eraflure;
        private System.Windows.Forms.CheckBox Chk_brulure;
        private System.Windows.Forms.CheckBox Chk_egratignure;
        private System.Windows.Forms.CheckBox Chk_mnq_autre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}
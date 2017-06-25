namespace Sentinel_Mobile.Presentation.Forms
{
    partial class FEN_Test
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
            this.BTN_Parametres = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Parametres
            // 
            this.BTN_Parametres.Location = new System.Drawing.Point(13, 12);
            this.BTN_Parametres.Name = "BTN_Parametres";
            this.BTN_Parametres.Size = new System.Drawing.Size(49, 36);
            this.BTN_Parametres.TabIndex = 5;
            this.BTN_Parametres.Text = "Test";
            this.BTN_Parametres.Click += new System.EventHandler(this.BTN_Parametres_Click_1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Namespace = "";
            this.dataSet1.Prefix = "";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.DisplayExpression = "";
            this.dataTable1.Prefix = "";
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn1.ColumnName = "Column1";
            this.dataColumn1.DataType = typeof(string);
            this.dataColumn1.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn1.Expression = "";
            this.dataColumn1.Prefix = "";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(13, 72);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(173, 143);
            this.dataGrid1.TabIndex = 6;
            // 
            // FEN_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(207, 237);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.BTN_Parametres);
            this.Name = "FEN_Test";
            this.Text = "FEN_Test";
            this.Load += new System.EventHandler(this.FEN_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Parametres;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGrid dataGrid1;


    }
}
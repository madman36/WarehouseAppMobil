namespace MOBIL_FILIAv2
{
    partial class frmMenu
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
            this.btnPrzychod = new System.Windows.Forms.Button();
            this.btnRozchod = new System.Windows.Forms.Button();
            this.btnMagazyn = new System.Windows.Forms.Button();
            this.btnPobierzDane = new System.Windows.Forms.Button();
            this.btnKonfiguracja = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrzychod
            // 
            this.btnPrzychod.Location = new System.Drawing.Point(3, 13);
            this.btnPrzychod.Name = "btnPrzychod";
            this.btnPrzychod.Size = new System.Drawing.Size(235, 150);
            this.btnPrzychod.TabIndex = 0;
            this.btnPrzychod.Text = "PRZYCHÓD";
            // 
            // btnRozchod
            // 
            this.btnRozchod.Location = new System.Drawing.Point(242, 13);
            this.btnRozchod.Name = "btnRozchod";
            this.btnRozchod.Size = new System.Drawing.Size(235, 150);
            this.btnRozchod.TabIndex = 1;
            this.btnRozchod.Text = "ROZCHÓD";
            this.btnRozchod.Click += new System.EventHandler(this.btnRozchod_Click);
            // 
            // btnMagazyn
            // 
            this.btnMagazyn.Location = new System.Drawing.Point(242, 169);
            this.btnMagazyn.Name = "btnMagazyn";
            this.btnMagazyn.Size = new System.Drawing.Size(235, 150);
            this.btnMagazyn.TabIndex = 2;
            this.btnMagazyn.Text = "MAGAZYN";
            this.btnMagazyn.Click += new System.EventHandler(this.btnMagazyn_Click);
            // 
            // btnPobierzDane
            // 
            this.btnPobierzDane.Location = new System.Drawing.Point(3, 169);
            this.btnPobierzDane.Name = "btnPobierzDane";
            this.btnPobierzDane.Size = new System.Drawing.Size(235, 150);
            this.btnPobierzDane.TabIndex = 3;
            this.btnPobierzDane.Text = "POBIERZ DANE";
            // 
            // btnKonfiguracja
            // 
            this.btnKonfiguracja.Location = new System.Drawing.Point(3, 325);
            this.btnKonfiguracja.Name = "btnKonfiguracja";
            this.btnKonfiguracja.Size = new System.Drawing.Size(235, 150);
            this.btnKonfiguracja.TabIndex = 4;
            this.btnKonfiguracja.Text = "KONFIGURACJA";
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(242, 325);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(235, 150);
            this.btnWyjscie.TabIndex = 5;
            this.btnWyjscie.Text = "WYJŚCIE";
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
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
            this.dataTable1.DisplayExpression = "";
            this.dataTable1.Prefix = "";
            this.dataTable1.TableName = "Table1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnKonfiguracja);
            this.Controls.Add(this.btnPobierzDane);
            this.Controls.Add(this.btnMagazyn);
            this.Controls.Add(this.btnRozchod);
            this.Controls.Add(this.btnPrzychod);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrzychod;
        private System.Windows.Forms.Button btnRozchod;
        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Button btnPobierzDane;
        private System.Windows.Forms.Button btnKonfiguracja;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
    }
}
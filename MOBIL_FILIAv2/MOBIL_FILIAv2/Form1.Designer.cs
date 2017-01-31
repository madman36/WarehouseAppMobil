namespace MOBIL_FILIAv2
{
    partial class frmStanMagazynowy
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
            this.components = new System.ComponentModel.Container();
            this.stanMagazynowyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStanMagWyjscie = new System.Windows.Forms.Button();
            this.localDBDataSet1 = new MOBIL_FILIAv2.LocalDBDataSet1();
            this.stanMagazynowyTableAdapter = new MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stanMagazynowyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // stanMagazynowyBindingSource
            // 
            this.stanMagazynowyBindingSource.DataMember = "StanMagazynowy";
            this.stanMagazynowyBindingSource.DataSource = this.localDBDataSet1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.stanMagazynowyBindingSource;
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(480, 509);
            this.dataGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "SUROWIEC";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(163, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "OPAKOWANIA";
            // 
            // btnStanMagWyjscie
            // 
            this.btnStanMagWyjscie.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.btnStanMagWyjscie.Location = new System.Drawing.Point(322, 515);
            this.btnStanMagWyjscie.Name = "btnStanMagWyjscie";
            this.btnStanMagWyjscie.Size = new System.Drawing.Size(155, 70);
            this.btnStanMagWyjscie.TabIndex = 3;
            this.btnStanMagWyjscie.Text = "WYJŚCIE";
            this.btnStanMagWyjscie.Click += new System.EventHandler(this.btnStanMagWyjscie_Click);
            // 
            // localDBDataSet1
            // 
            this.localDBDataSet1.DataSetName = "LocalDBDataSet1";
            this.localDBDataSet1.Prefix = "";
            this.localDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stanMagazynowyTableAdapter
            // 
            this.stanMagazynowyTableAdapter.ClearBeforeFill = true;
            // 
            // frmStanMagazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.btnStanMagWyjscie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmStanMagazynowy";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStanMagazynowy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanMagazynowyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStanMagWyjscie;
        private LocalDBDataSet1 localDBDataSet1;
        private System.Windows.Forms.BindingSource stanMagazynowyBindingSource;
        private MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter stanMagazynowyTableAdapter;
    }
}
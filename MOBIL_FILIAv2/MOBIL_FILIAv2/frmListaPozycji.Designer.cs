namespace MOBIL_FILIAv2
{
    partial class frmListaPozycji
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.listaPozycji = new MOBIL_FILIAv2.ListaPozycji();
            this.pozycjeNaMagazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pozycjeNaMagazynTableAdapter = new MOBIL_FILIAv2.ListaPozycjiTableAdapters.PozycjeNaMagazynTableAdapter();
            this.pozycjeNaMagazynBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localDBDataSet1 = new MOBIL_FILIAv2.LocalDBDataSet1();
            this.stanMagazynowyTableAdapter = new MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stanMagazynowyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPozycji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource1)).BeginInit();
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
            this.dataGrid1.Location = new System.Drawing.Point(3, 14);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(474, 495);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "POZYCJE";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "USUŃ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "WYJŚCIE";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listaPozycji
            // 
            this.listaPozycji.DataSetName = "ListaPozycji";
            this.listaPozycji.Prefix = "";
            this.listaPozycji.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pozycjeNaMagazynBindingSource
            // 
            this.pozycjeNaMagazynBindingSource.DataMember = "PozycjeNaMagazyn";
            this.pozycjeNaMagazynBindingSource.DataSource = this.listaPozycji;
            // 
            // pozycjeNaMagazynTableAdapter
            // 
            this.pozycjeNaMagazynTableAdapter.ClearBeforeFill = true;
            // 
            // pozycjeNaMagazynBindingSource1
            // 
            this.pozycjeNaMagazynBindingSource1.DataMember = "PozycjeNaMagazyn";
            this.pozycjeNaMagazynBindingSource1.DataSource = this.listaPozycji;
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
            // frmListaPozycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmListaPozycji";
            this.Text = "frmListaPozycji";
            this.Load += new System.EventHandler(this.frmListaPozycji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanMagazynowyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPozycji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeNaMagazynBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private ListaPozycji listaPozycji;
        private System.Windows.Forms.BindingSource pozycjeNaMagazynBindingSource;
        private MOBIL_FILIAv2.ListaPozycjiTableAdapters.PozycjeNaMagazynTableAdapter pozycjeNaMagazynTableAdapter;
        private System.Windows.Forms.BindingSource pozycjeNaMagazynBindingSource1;
        private LocalDBDataSet1 localDBDataSet1;
        private System.Windows.Forms.BindingSource stanMagazynowyBindingSource;
        private MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter stanMagazynowyTableAdapter;
    }
}
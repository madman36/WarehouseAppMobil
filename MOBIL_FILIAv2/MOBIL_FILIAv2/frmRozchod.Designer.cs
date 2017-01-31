namespace MOBIL_FILIAv2
{
    partial class frmRozchod
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.stanPojemnikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaDokumentowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgRozchod = new System.Windows.Forms.DataGrid();
            this.localDBDataSet1 = new MOBIL_FILIAv2.LocalDBDataSet();
            this.localDBDataSet2 = new MOBIL_FILIAv2.LocalDBDataSet2();
            this.listaDokumentowTableAdapter = new MOBIL_FILIAv2.LocalDBDataSet2TableAdapters.ListaDokumentowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDokumentowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(4, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "ZMIEŃ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(323, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "EKSPORT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(163, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "DODAJ";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(163, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 70);
            this.button4.TabIndex = 7;
            this.button4.Text = "USUŃ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 515);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 70);
            this.button5.TabIndex = 6;
            this.button5.Text = "WYJŚCIE";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 515);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "DRUKUJ";
            // 
            // stanPojemnikiBindingSource1
            // 
            this.stanPojemnikiBindingSource1.DataMember = "StanPojemniki";
            // 
            // listaDokumentowBindingSource
            // 
            this.listaDokumentowBindingSource.DataMember = "ListaDokumentow";
            this.listaDokumentowBindingSource.DataSource = this.localDBDataSet2;
            // 
            // dgRozchod
            // 
            this.dgRozchod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgRozchod.DataSource = this.listaDokumentowBindingSource;
            this.dgRozchod.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgRozchod.Location = new System.Drawing.Point(0, 0);
            this.dgRozchod.Name = "dgRozchod";
            this.dgRozchod.PreferredRowHeight = 50;
            this.dgRozchod.Size = new System.Drawing.Size(480, 433);
            this.dgRozchod.TabIndex = 8;
            this.dgRozchod.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // localDBDataSet1
            // 
            this.localDBDataSet1.DataSetName = "LocalDBDataSet";
            this.localDBDataSet1.Prefix = "";
            this.localDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localDBDataSet2
            // 
            this.localDBDataSet2.DataSetName = "LocalDBDataSet2";
            this.localDBDataSet2.Prefix = "";
            this.localDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaDokumentowTableAdapter
            // 
            this.listaDokumentowTableAdapter.ClearBeforeFill = true;
            // 
            // frmRozchod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.dgRozchod);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmRozchod";
            this.Text = "frmRozchod";
            this.Load += new System.EventHandler(this.frmRozchod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDokumentowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGrid dgRozchod;
        private System.Windows.Forms.BindingSource stanPojemnikiBindingSource1;
        private LocalDBDataSet localDBDataSet1;
        private LocalDBDataSet2 localDBDataSet2;
        private System.Windows.Forms.BindingSource listaDokumentowBindingSource;
        private MOBIL_FILIAv2.LocalDBDataSet2TableAdapters.ListaDokumentowTableAdapter listaDokumentowTableAdapter;
    }
}
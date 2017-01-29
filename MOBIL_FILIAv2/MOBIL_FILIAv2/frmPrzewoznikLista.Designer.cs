namespace MOBIL_FILIAv2
{
    partial class frmPrzewoznikLista
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
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
            this.kONTRAHENCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.mOBIL_FILIADataSet = new MOBIL_FILIAv2.MOBIL_FILIADataSet();
            this.kONTRAHENCITableAdapter = new MOBIL_FILIAv2.MOBIL_FILIADataSetTableAdapters.KONTRAHENCITableAdapter();
            dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kONTRAHENCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBIL_FILIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kONTRAHENCIBindingSource
            // 
            this.kONTRAHENCIBindingSource.DataMember = "KONTRAHENCI";
            this.kONTRAHENCIBindingSource.DataSource = this.mOBIL_FILIADataSet;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.kONTRAHENCIBindingSource;
            this.dataGrid1.Location = new System.Drawing.Point(8, 4);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(465, 505);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "WYJSCIE";
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(dataGridTextBoxColumn2);
            // 
            // dataGridTextBoxColumn1
            // 
            dataGridTextBoxColumn1.Format = "";
            dataGridTextBoxColumn1.FormatInfo = null;
            dataGridTextBoxColumn1.MappingName = "KTR_ID";
            // 
            // dataGridTextBoxColumn2
            // 
            dataGridTextBoxColumn2.Format = "";
            dataGridTextBoxColumn2.FormatInfo = null;
            dataGridTextBoxColumn2.MappingName = "KTR_STATUS";
            // 
            // mOBIL_FILIADataSet
            // 
            this.mOBIL_FILIADataSet.DataSetName = "MOBIL_FILIADataSet";
            this.mOBIL_FILIADataSet.Prefix = "";
            this.mOBIL_FILIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kONTRAHENCITableAdapter
            // 
            this.kONTRAHENCITableAdapter.ClearBeforeFill = true;
            // 
            // frmPrzewoznikLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmPrzewoznikLista";
            this.Text = "frmPrzewoznikLista";
            this.Load += new System.EventHandler(this.frmPrzewoznikLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kONTRAHENCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBIL_FILIADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private MOBIL_FILIADataSet mOBIL_FILIADataSet;
        private System.Windows.Forms.BindingSource kONTRAHENCIBindingSource;
        private MOBIL_FILIAv2.MOBIL_FILIADataSetTableAdapters.KONTRAHENCITableAdapter kONTRAHENCITableAdapter;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
    }
}
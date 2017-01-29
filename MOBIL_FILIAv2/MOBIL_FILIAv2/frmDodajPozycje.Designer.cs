namespace MOBIL_FILIAv2
{
    partial class frmDodajPozycje
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stanPojemnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOBIL_FILIAv2DBDataSet = new MOBIL_FILIAv2.MOBIL_FILIAv2DBDataSet();
            this.dgDodajPozycje = new System.Windows.Forms.DataGrid();
            this.stanPojemnikiTableAdapter = new MOBIL_FILIAv2.MOBIL_FILIAv2DBDataSetTableAdapters.StanPojemnikiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBIL_FILIAv2DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.Text = "Symbol pojemnika:";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "20010004561234";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stanPojemnikiBindingSource
            // 
            this.stanPojemnikiBindingSource.DataMember = "StanPojemniki";
            this.stanPojemnikiBindingSource.DataSource = this.mOBIL_FILIAv2DBDataSet;
            // 
            // mOBIL_FILIAv2DBDataSet
            // 
            this.mOBIL_FILIAv2DBDataSet.DataSetName = "MOBIL_FILIAv2DBDataSet";
            this.mOBIL_FILIAv2DBDataSet.Prefix = "";
            this.mOBIL_FILIAv2DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgDodajPozycje
            // 
            this.dgDodajPozycje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgDodajPozycje.DataSource = this.stanPojemnikiBindingSource;
            this.dgDodajPozycje.Location = new System.Drawing.Point(6, 74);
            this.dgDodajPozycje.Name = "dgDodajPozycje";
            this.dgDodajPozycje.Size = new System.Drawing.Size(471, 70);
            this.dgDodajPozycje.TabIndex = 3;
            this.dgDodajPozycje.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dgDodajPozycje.Click += new System.EventHandler(this.dgDodajPozycje_Click);
            // 
            // stanPojemnikiTableAdapter
            // 
            this.stanPojemnikiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.Text = "Opakowanie:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.comboBox1.Location = new System.Drawing.Point(172, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 57);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 59);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 40);
            this.label3.Text = "Data uboju:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.Text = "Ilość:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.textBox2.Location = new System.Drawing.Point(104, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 90);
            this.textBox2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(347, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 90);
            this.button1.TabIndex = 14;
            this.button1.Text = "+";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 70);
            this.button2.TabIndex = 15;
            this.button2.Text = "DRUKUJ ETYKIETĘ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 70);
            this.button3.TabIndex = 16;
            this.button3.Text = "WYJŚCIE";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 40);
            this.label5.Text = "Waga:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(396, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 40);
            this.label6.Text = "Ilość:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.textBox3.Location = new System.Drawing.Point(402, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 64);
            this.textBox3.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(104, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 40);
            this.label7.Text = "250,00 kg";
            // 
            // frmDodajPozycje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDodajPozycje);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmDodajPozycje";
            this.Text = "DodajPozycje";
            this.Load += new System.EventHandler(this.DodajPozycje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOBIL_FILIAv2DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGrid dgDodajPozycje;
        private MOBIL_FILIAv2DBDataSet mOBIL_FILIAv2DBDataSet;
        private System.Windows.Forms.BindingSource stanPojemnikiBindingSource;
        private MOBIL_FILIAv2.MOBIL_FILIAv2DBDataSetTableAdapters.StanPojemnikiTableAdapter stanPojemnikiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}
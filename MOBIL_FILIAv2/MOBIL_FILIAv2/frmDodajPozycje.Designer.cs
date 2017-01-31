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
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.dgDodajPozycje = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.listaTypOpakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtilosc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filieTableAdapter1 = new MOBIL_FILIAv2.MOBIL_FILIADataSetTableAdapters.FILIETableAdapter();
            this.stanMagazynowyTableAdapter1 = new MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listaTypOpakBindingSource)).BeginInit();
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
            // txtNumer
            // 
            this.txtNumer.Location = new System.Drawing.Point(216, 18);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(261, 41);
            this.txtNumer.TabIndex = 2;
            this.txtNumer.Text = "20010004561234";
            this.txtNumer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgDodajPozycje
            // 
            this.dgDodajPozycje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgDodajPozycje.Location = new System.Drawing.Point(6, 74);
            this.dgDodajPozycje.Name = "dgDodajPozycje";
            this.dgDodajPozycje.Size = new System.Drawing.Size(471, 97);
            this.dgDodajPozycje.TabIndex = 3;
            this.dgDodajPozycje.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.Text = "Opakowanie:";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.comboBox1.Items.Add("beczka duza");
            this.comboBox1.Items.Add("beczka mala");
            this.comboBox1.Items.Add("palox pelny");
            this.comboBox1.Items.Add("palox azur");
            this.comboBox1.Items.Add("Nordic 660");
            this.comboBox1.Items.Add("pojemnik 630");
            this.comboBox1.Items.Add("Skrzynka EURO");
            this.comboBox1.Items.Add("Paleta Dr.Euro");
            this.comboBox1.Location = new System.Drawing.Point(6, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 64);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 59);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 40);
            this.label3.Text = "Data uboju:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.Text = "Ilość:";
            // 
            // txtilosc
            // 
            this.txtilosc.BackColor = System.Drawing.Color.LightYellow;
            this.txtilosc.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.txtilosc.Location = new System.Drawing.Point(104, 353);
            this.txtilosc.Name = "txtilosc";
            this.txtilosc.Size = new System.Drawing.Size(238, 90);
            this.txtilosc.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(348, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 90);
            this.button1.TabIndex = 14;
            this.button1.Text = "+";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(6, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 80);
            this.button2.TabIndex = 15;
            this.button2.Text = "DRUKUJ ETYKIETĘ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 80);
            this.button3.TabIndex = 16;
            this.button3.Text = "WYJŚCIE";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 40);
            this.label5.Text = "Waga:";
            this.label5.ParentChanged += new System.EventHandler(this.label5_ParentChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(402, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.Text = "Ilość:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.textBox3.Location = new System.Drawing.Point(407, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 64);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "1";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(104, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 40);
            this.label7.Text = "250,00 kg";
            // 
            // filieTableAdapter1
            // 
            this.filieTableAdapter1.ClearBeforeFill = true;
            // 
            // stanMagazynowyTableAdapter1
            // 
            this.stanMagazynowyTableAdapter1.ClearBeforeFill = true;
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
            this.Controls.Add(this.txtilosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDodajPozycje);
            this.Controls.Add(this.txtNumer);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "frmDodajPozycje";
            this.Text = "DodajPozycje";
            this.Load += new System.EventHandler(this.DodajPozycje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaTypOpakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.DataGrid dgDodajPozycje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtilosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource listaTypOpakBindingSource;
        private MOBIL_FILIAv2.MOBIL_FILIADataSetTableAdapters.FILIETableAdapter filieTableAdapter1;
        private MOBIL_FILIAv2.LocalDBDataSet1TableAdapters.StanMagazynowyTableAdapter stanMagazynowyTableAdapter1;
    }
}
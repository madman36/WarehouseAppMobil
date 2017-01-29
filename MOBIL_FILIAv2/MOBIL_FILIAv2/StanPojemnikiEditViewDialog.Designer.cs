namespace MOBIL_FILIAv2
{
    partial class StanPojemnikiEditViewDialog
    {
        public static StanPojemnikiEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new MOBIL_FILIAv2.StanPojemnikiEditViewDialog();
                defaultInstance.stanPojemnikiBindingSource.DataSource = bindingSource;
            }
            defaultInstance.idTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.stanPojemnikiBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static StanPojemnikiEditViewDialog defaultInstance;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label indeksLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label iloscLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.stanPojemnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.indeksTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.iloscTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            indeksLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            iloscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stanPojemnikiBindingSource
            // 
            this.stanPojemnikiBindingSource.DataMember = "StanPojemniki";
            this.stanPojemnikiBindingSource.DataSource = typeof(MOBIL_FILIAv2.MOBIL_FILIAv2DBDataSet);
            // 
            // idLabel
            // 
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 4);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(44, 21);
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "id", true));
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idTextBox.Location = new System.Drawing.Point(4, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 41);
            this.idTextBox.TabIndex = 1;
            // 
            // indeksLabel
            // 
            indeksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            indeksLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            indeksLabel.Location = new System.Drawing.Point(4, 85);
            indeksLabel.Name = "indeksLabel";
            indeksLabel.Size = new System.Drawing.Size(99, 21);
            indeksLabel.Text = "indeks:";
            // 
            // indeksTextBox
            // 
            this.indeksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "indeks", true));
            this.indeksTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.indeksTextBox.Location = new System.Drawing.Point(4, 114);
            this.indeksTextBox.Name = "indeksTextBox";
            this.indeksTextBox.Size = new System.Drawing.Size(100, 41);
            this.indeksTextBox.TabIndex = 3;
            // 
            // nazwaLabel
            // 
            nazwaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nazwaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nazwaLabel.Location = new System.Drawing.Point(4, 166);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(99, 21);
            nazwaLabel.Text = "nazwa:";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "nazwa", true));
            this.nazwaTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nazwaTextBox.Location = new System.Drawing.Point(4, 195);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 41);
            this.nazwaTextBox.TabIndex = 5;
            // 
            // iloscLabel
            // 
            iloscLabel.Dock = System.Windows.Forms.DockStyle.Top;
            iloscLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            iloscLabel.Location = new System.Drawing.Point(4, 247);
            iloscLabel.Name = "iloscLabel";
            iloscLabel.Size = new System.Drawing.Size(76, 21);
            iloscLabel.Text = "ilosc:";
            // 
            // iloscTextBox
            // 
            this.iloscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "ilosc", true));
            this.iloscTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iloscTextBox.Location = new System.Drawing.Point(4, 276);
            this.iloscTextBox.Name = "iloscTextBox";
            this.iloscTextBox.Size = new System.Drawing.Size(100, 41);
            this.iloscTextBox.TabIndex = 7;
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(100, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // StanPojemnikiEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.iloscTextBox);
            this.Controls.Add(iloscLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.indeksTextBox);
            this.Controls.Add(indeksLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "StanPojemnikiEditViewDialog";
            this.Text = "StanPojemnikiEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.StanPojemnikiEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource stanPojemnikiBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox indeksTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox iloscTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}
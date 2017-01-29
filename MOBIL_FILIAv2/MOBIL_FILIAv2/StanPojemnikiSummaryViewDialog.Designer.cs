namespace MOBIL_FILIAv2
{
    partial class StanPojemnikiSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static StanPojemnikiSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new MOBIL_FILIAv2.StanPojemnikiSummaryViewDialog();
                defaultInstance.stanPojemnikiBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.stanPojemnikiBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static StanPojemnikiSummaryViewDialog defaultInstance;
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
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.stanPojemnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel1 = new System.Windows.Forms.Label();
            this.indeksLabel1 = new System.Windows.Forms.Label();
            this.nazwaLabel1 = new System.Windows.Forms.Label();
            this.iloscLabel1 = new System.Windows.Forms.Label();
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
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // stanPojemnikiBindingSource
            // 
            this.stanPojemnikiBindingSource.DataMember = "StanPojemniki";
            this.stanPojemnikiBindingSource.DataSource = typeof(MOBIL_FILIAv2.MOBIL_FILIAv2DBDataSet);
            // 
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 4);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(44, 21);
            idLabel.Text = "id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 33);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // indeksLabel
            // 
            indeksLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "indeks", true));
            indeksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            indeksLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            indeksLabel.Location = new System.Drawing.Point(4, 64);
            indeksLabel.Name = "indeksLabel";
            indeksLabel.Size = new System.Drawing.Size(99, 21);
            indeksLabel.Text = "indeks:";
            // 
            // indeksLabel1
            // 
            this.indeksLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "indeks", true));
            this.indeksLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "indeks", true));
            this.indeksLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.indeksLabel1.Location = new System.Drawing.Point(4, 93);
            this.indeksLabel1.Name = "indeksLabel1";
            this.indeksLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // nazwaLabel
            // 
            nazwaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "nazwa", true));
            nazwaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nazwaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nazwaLabel.Location = new System.Drawing.Point(4, 124);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(99, 21);
            nazwaLabel.Text = "nazwa:";
            // 
            // nazwaLabel1
            // 
            this.nazwaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "nazwa", true));
            this.nazwaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "nazwa", true));
            this.nazwaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nazwaLabel1.Location = new System.Drawing.Point(4, 153);
            this.nazwaLabel1.Name = "nazwaLabel1";
            this.nazwaLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // iloscLabel
            // 
            iloscLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "ilosc", true));
            iloscLabel.Dock = System.Windows.Forms.DockStyle.Top;
            iloscLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            iloscLabel.Location = new System.Drawing.Point(4, 184);
            iloscLabel.Name = "iloscLabel";
            iloscLabel.Size = new System.Drawing.Size(76, 21);
            iloscLabel.Text = "ilosc:";
            // 
            // iloscLabel1
            // 
            this.iloscLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stanPojemnikiBindingSource, "ilosc", true));
            this.iloscLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.stanPojemnikiBindingSource, "ilosc", true));
            this.iloscLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iloscLabel1.Location = new System.Drawing.Point(4, 213);
            this.iloscLabel1.Name = "iloscLabel1";
            this.iloscLabel1.Size = new System.Drawing.Size(100, 20);
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
            // StanPojemnikiSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.iloscLabel1);
            this.Controls.Add(iloscLabel);
            this.Controls.Add(this.nazwaLabel1);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.indeksLabel1);
            this.Controls.Add(indeksLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "StanPojemnikiSummaryViewDialog";
            this.Text = "StanPojemnikiSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StanPojemnikiSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.stanPojemnikiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource stanPojemnikiBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label indeksLabel1;
        private System.Windows.Forms.Label nazwaLabel1;
        private System.Windows.Forms.Label iloscLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}
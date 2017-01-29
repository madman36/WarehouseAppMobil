namespace MOBIL_FILIAv2
{
    partial class TOWARYSummaryViewDialog
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
    
        public static TOWARYSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new MOBIL_FILIAv2.TOWARYSummaryViewDialog();
                defaultInstance.tOWARYBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.tOWARYBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static TOWARYSummaryViewDialog defaultInstance;
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
            System.Windows.Forms.Label tWR_IDLabel;
            System.Windows.Forms.Label tWR_STATUSLabel;
            System.Windows.Forms.Label tWR_NUMERLabel;
            System.Windows.Forms.Label tWR_SKROTLabel;
            System.Windows.Forms.Label tWR_NAZWALabel;
            System.Windows.Forms.Label tWR_KGLabel;
            System.Windows.Forms.Label tWR_SLJM_KODLabel;
            System.Windows.Forms.Label tWR_CZY_ROZCHODLabel;
            System.Windows.Forms.Label tWR_CZY_PRZYCHODLabel;
            System.Windows.Forms.Label tWR_STANLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.tOWARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWR_IDLabel1 = new System.Windows.Forms.Label();
            this.tWR_STATUSLabel1 = new System.Windows.Forms.Label();
            this.tWR_NUMERLabel1 = new System.Windows.Forms.Label();
            this.tWR_SKROTLabel1 = new System.Windows.Forms.Label();
            this.tWR_NAZWALabel1 = new System.Windows.Forms.Label();
            this.tWR_KGLabel1 = new System.Windows.Forms.Label();
            this.tWR_SLJM_KODLabel1 = new System.Windows.Forms.Label();
            this.tWR_CZY_ROZCHODLabel1 = new System.Windows.Forms.Label();
            this.tWR_CZY_PRZYCHODLabel1 = new System.Windows.Forms.Label();
            this.tWR_STANLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            tWR_IDLabel = new System.Windows.Forms.Label();
            tWR_STATUSLabel = new System.Windows.Forms.Label();
            tWR_NUMERLabel = new System.Windows.Forms.Label();
            tWR_SKROTLabel = new System.Windows.Forms.Label();
            tWR_NAZWALabel = new System.Windows.Forms.Label();
            tWR_KGLabel = new System.Windows.Forms.Label();
            tWR_SLJM_KODLabel = new System.Windows.Forms.Label();
            tWR_CZY_ROZCHODLabel = new System.Windows.Forms.Label();
            tWR_CZY_PRZYCHODLabel = new System.Windows.Forms.Label();
            tWR_STANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tOWARYBindingSource)).BeginInit();
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

            // 
            // tWR_IDLabel
            // 
            tWR_IDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_ID", true));
            tWR_IDLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_IDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_IDLabel.Location = new System.Drawing.Point(4, 4);
            tWR_IDLabel.Name = "tWR_IDLabel";
            tWR_IDLabel.Size = new System.Drawing.Size(116, 21);
            tWR_IDLabel.Text = "TWR ID:";
            // 
            // tWR_IDLabel1
            // 
            this.tWR_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_ID", true));
            this.tWR_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_ID", true));
            this.tWR_IDLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_IDLabel1.Location = new System.Drawing.Point(4, 33);
            this.tWR_IDLabel1.Name = "tWR_IDLabel1";
            this.tWR_IDLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_STATUSLabel
            // 
            tWR_STATUSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_STATUS", true));
            tWR_STATUSLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_STATUSLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_STATUSLabel.Location = new System.Drawing.Point(4, 64);
            tWR_STATUSLabel.Name = "tWR_STATUSLabel";
            tWR_STATUSLabel.Size = new System.Drawing.Size(180, 21);
            tWR_STATUSLabel.Text = "TWR STATUS:";
            // 
            // tWR_STATUSLabel1
            // 
            this.tWR_STATUSLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_STATUS", true));
            this.tWR_STATUSLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_STATUS", true));
            this.tWR_STATUSLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_STATUSLabel1.Location = new System.Drawing.Point(4, 93);
            this.tWR_STATUSLabel1.Name = "tWR_STATUSLabel1";
            this.tWR_STATUSLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_NUMERLabel
            // 
            tWR_NUMERLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_NUMER", true));
            tWR_NUMERLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_NUMERLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_NUMERLabel.Location = new System.Drawing.Point(4, 124);
            tWR_NUMERLabel.Name = "tWR_NUMERLabel";
            tWR_NUMERLabel.Size = new System.Drawing.Size(176, 21);
            tWR_NUMERLabel.Text = "TWR NUMER:";
            // 
            // tWR_NUMERLabel1
            // 
            this.tWR_NUMERLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_NUMER", true));
            this.tWR_NUMERLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_NUMER", true));
            this.tWR_NUMERLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_NUMERLabel1.Location = new System.Drawing.Point(4, 153);
            this.tWR_NUMERLabel1.Name = "tWR_NUMERLabel1";
            this.tWR_NUMERLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_SKROTLabel
            // 
            tWR_SKROTLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_SKROT", true));
            tWR_SKROTLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_SKROTLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_SKROTLabel.Location = new System.Drawing.Point(4, 184);
            tWR_SKROTLabel.Name = "tWR_SKROTLabel";
            tWR_SKROTLabel.Size = new System.Drawing.Size(168, 21);
            tWR_SKROTLabel.Text = "TWR SKROT:";
            // 
            // tWR_SKROTLabel1
            // 
            this.tWR_SKROTLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_SKROT", true));
            this.tWR_SKROTLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_SKROT", true));
            this.tWR_SKROTLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_SKROTLabel1.Location = new System.Drawing.Point(4, 213);
            this.tWR_SKROTLabel1.Name = "tWR_SKROTLabel1";
            this.tWR_SKROTLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_NAZWALabel
            // 
            tWR_NAZWALabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_NAZWA", true));
            tWR_NAZWALabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_NAZWALabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_NAZWALabel.Location = new System.Drawing.Point(4, 244);
            tWR_NAZWALabel.Name = "tWR_NAZWALabel";
            tWR_NAZWALabel.Size = new System.Drawing.Size(177, 21);
            tWR_NAZWALabel.Text = "TWR NAZWA:";
            // 
            // tWR_NAZWALabel1
            // 
            this.tWR_NAZWALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_NAZWA", true));
            this.tWR_NAZWALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_NAZWA", true));
            this.tWR_NAZWALabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_NAZWALabel1.Location = new System.Drawing.Point(4, 273);
            this.tWR_NAZWALabel1.Name = "tWR_NAZWALabel1";
            this.tWR_NAZWALabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_KGLabel
            // 
            tWR_KGLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_KG", true));
            tWR_KGLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_KGLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_KGLabel.Location = new System.Drawing.Point(4, 304);
            tWR_KGLabel.Name = "tWR_KGLabel";
            tWR_KGLabel.Size = new System.Drawing.Size(121, 21);
            tWR_KGLabel.Text = "TWR KG:";
            // 
            // tWR_KGLabel1
            // 
            this.tWR_KGLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_KG", true));
            this.tWR_KGLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_KG", true));
            this.tWR_KGLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_KGLabel1.Location = new System.Drawing.Point(4, 333);
            this.tWR_KGLabel1.Name = "tWR_KGLabel1";
            this.tWR_KGLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_SLJM_KODLabel
            // 
            tWR_SLJM_KODLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_SLJM_KOD", true));
            tWR_SLJM_KODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_SLJM_KODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_SLJM_KODLabel.Location = new System.Drawing.Point(4, 364);
            tWR_SLJM_KODLabel.Name = "tWR_SLJM_KODLabel";
            tWR_SLJM_KODLabel.Size = new System.Drawing.Size(208, 21);
            tWR_SLJM_KODLabel.Text = "TWR SLJM KOD:";
            // 
            // tWR_SLJM_KODLabel1
            // 
            this.tWR_SLJM_KODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_SLJM_KOD", true));
            this.tWR_SLJM_KODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_SLJM_KOD", true));
            this.tWR_SLJM_KODLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_SLJM_KODLabel1.Location = new System.Drawing.Point(4, 393);
            this.tWR_SLJM_KODLabel1.Name = "tWR_SLJM_KODLabel1";
            this.tWR_SLJM_KODLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_CZY_ROZCHODLabel
            // 
            tWR_CZY_ROZCHODLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_CZY_ROZCHOD", true));
            tWR_CZY_ROZCHODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_CZY_ROZCHODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_CZY_ROZCHODLabel.Location = new System.Drawing.Point(4, 424);
            tWR_CZY_ROZCHODLabel.Name = "tWR_CZY_ROZCHODLabel";
            tWR_CZY_ROZCHODLabel.Size = new System.Drawing.Size(260, 21);
            tWR_CZY_ROZCHODLabel.Text = "TWR CZY ROZCHOD:";
            // 
            // tWR_CZY_ROZCHODLabel1
            // 
            this.tWR_CZY_ROZCHODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_CZY_ROZCHOD", true));
            this.tWR_CZY_ROZCHODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_CZY_ROZCHOD", true));
            this.tWR_CZY_ROZCHODLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_CZY_ROZCHODLabel1.Location = new System.Drawing.Point(4, 453);
            this.tWR_CZY_ROZCHODLabel1.Name = "tWR_CZY_ROZCHODLabel1";
            this.tWR_CZY_ROZCHODLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_CZY_PRZYCHODLabel
            // 
            tWR_CZY_PRZYCHODLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_CZY_PRZYCHOD", true));
            tWR_CZY_PRZYCHODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_CZY_PRZYCHODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_CZY_PRZYCHODLabel.Location = new System.Drawing.Point(4, 484);
            tWR_CZY_PRZYCHODLabel.Name = "tWR_CZY_PRZYCHODLabel";
            tWR_CZY_PRZYCHODLabel.Size = new System.Drawing.Size(274, 21);
            tWR_CZY_PRZYCHODLabel.Text = "TWR CZY PRZYCHOD:";
            // 
            // tWR_CZY_PRZYCHODLabel1
            // 
            this.tWR_CZY_PRZYCHODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_CZY_PRZYCHOD", true));
            this.tWR_CZY_PRZYCHODLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_CZY_PRZYCHOD", true));
            this.tWR_CZY_PRZYCHODLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_CZY_PRZYCHODLabel1.Location = new System.Drawing.Point(4, 513);
            this.tWR_CZY_PRZYCHODLabel1.Name = "tWR_CZY_PRZYCHODLabel1";
            this.tWR_CZY_PRZYCHODLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // tWR_STANLabel
            // 
            tWR_STANLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_STAN", true));
            tWR_STANLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_STANLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_STANLabel.Location = new System.Drawing.Point(4, 544);
            tWR_STANLabel.Name = "tWR_STANLabel";
            tWR_STANLabel.Size = new System.Drawing.Size(151, 21);
            tWR_STANLabel.Text = "TWR STAN:";
            // 
            // tWR_STANLabel1
            // 
            this.tWR_STANLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_STAN", true));
            this.tWR_STANLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.tOWARYBindingSource, "TWR_STAN", true));
            this.tWR_STANLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_STANLabel1.Location = new System.Drawing.Point(4, 573);
            this.tWR_STANLabel1.Name = "tWR_STANLabel1";
            this.tWR_STANLabel1.Size = new System.Drawing.Size(100, 20);
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
            // TOWARYSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.tWR_STANLabel1);
            this.Controls.Add(tWR_STANLabel);
            this.Controls.Add(this.tWR_CZY_PRZYCHODLabel1);
            this.Controls.Add(tWR_CZY_PRZYCHODLabel);
            this.Controls.Add(this.tWR_CZY_ROZCHODLabel1);
            this.Controls.Add(tWR_CZY_ROZCHODLabel);
            this.Controls.Add(this.tWR_SLJM_KODLabel1);
            this.Controls.Add(tWR_SLJM_KODLabel);
            this.Controls.Add(this.tWR_KGLabel1);
            this.Controls.Add(tWR_KGLabel);
            this.Controls.Add(this.tWR_NAZWALabel1);
            this.Controls.Add(tWR_NAZWALabel);
            this.Controls.Add(this.tWR_SKROTLabel1);
            this.Controls.Add(tWR_SKROTLabel);
            this.Controls.Add(this.tWR_NUMERLabel1);
            this.Controls.Add(tWR_NUMERLabel);
            this.Controls.Add(this.tWR_STATUSLabel1);
            this.Controls.Add(tWR_STATUSLabel);
            this.Controls.Add(this.tWR_IDLabel1);
            this.Controls.Add(tWR_IDLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "TOWARYSummaryViewDialog";
            this.Text = "TOWARYSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TOWARYSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tOWARYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource tOWARYBindingSource;
        private System.Windows.Forms.Label tWR_IDLabel1;
        private System.Windows.Forms.Label tWR_STATUSLabel1;
        private System.Windows.Forms.Label tWR_NUMERLabel1;
        private System.Windows.Forms.Label tWR_SKROTLabel1;
        private System.Windows.Forms.Label tWR_NAZWALabel1;
        private System.Windows.Forms.Label tWR_KGLabel1;
        private System.Windows.Forms.Label tWR_SLJM_KODLabel1;
        private System.Windows.Forms.Label tWR_CZY_ROZCHODLabel1;
        private System.Windows.Forms.Label tWR_CZY_PRZYCHODLabel1;
        private System.Windows.Forms.Label tWR_STANLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}
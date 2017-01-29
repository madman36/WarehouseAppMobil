namespace MOBIL_FILIAv2
{
    partial class TOWARYEditViewDialog
    {
        public static TOWARYEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new MOBIL_FILIAv2.TOWARYEditViewDialog();
                defaultInstance.tOWARYBindingSource.DataSource = bindingSource;
            }
            defaultInstance.tWR_IDTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.tOWARYBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static TOWARYEditViewDialog defaultInstance;
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
            this.tOWARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWR_IDTextBox = new System.Windows.Forms.TextBox();
            this.tWR_STATUSTextBox = new System.Windows.Forms.TextBox();
            this.tWR_NUMERTextBox = new System.Windows.Forms.TextBox();
            this.tWR_SKROTTextBox = new System.Windows.Forms.TextBox();
            this.tWR_NAZWATextBox = new System.Windows.Forms.TextBox();
            this.tWR_KGTextBox = new System.Windows.Forms.TextBox();
            this.tWR_SLJM_KODTextBox = new System.Windows.Forms.TextBox();
            this.tWR_CZY_ROZCHODTextBox = new System.Windows.Forms.TextBox();
            this.tWR_CZY_PRZYCHODTextBox = new System.Windows.Forms.TextBox();
            this.tWR_STANTextBox = new System.Windows.Forms.TextBox();
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
            // tOWARYBindingSource
            // 
            this.tOWARYBindingSource.DataMember = "TOWARY";
            // 
            // tWR_IDLabel
            // 
            tWR_IDLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_IDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_IDLabel.Location = new System.Drawing.Point(4, 4);
            tWR_IDLabel.Name = "tWR_IDLabel";
            tWR_IDLabel.Size = new System.Drawing.Size(116, 21);
            tWR_IDLabel.Text = "TWR ID:";
            // 
            // tWR_IDTextBox
            // 
            this.tWR_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_ID", true));
            this.tWR_IDTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_IDTextBox.Location = new System.Drawing.Point(4, 33);
            this.tWR_IDTextBox.Name = "tWR_IDTextBox";
            this.tWR_IDTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_IDTextBox.TabIndex = 1;
            // 
            // tWR_STATUSLabel
            // 
            tWR_STATUSLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_STATUSLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_STATUSLabel.Location = new System.Drawing.Point(4, 85);
            tWR_STATUSLabel.Name = "tWR_STATUSLabel";
            tWR_STATUSLabel.Size = new System.Drawing.Size(180, 21);
            tWR_STATUSLabel.Text = "TWR STATUS:";
            // 
            // tWR_STATUSTextBox
            // 
            this.tWR_STATUSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_STATUS", true));
            this.tWR_STATUSTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_STATUSTextBox.Location = new System.Drawing.Point(4, 114);
            this.tWR_STATUSTextBox.Name = "tWR_STATUSTextBox";
            this.tWR_STATUSTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_STATUSTextBox.TabIndex = 3;
            // 
            // tWR_NUMERLabel
            // 
            tWR_NUMERLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_NUMERLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_NUMERLabel.Location = new System.Drawing.Point(4, 166);
            tWR_NUMERLabel.Name = "tWR_NUMERLabel";
            tWR_NUMERLabel.Size = new System.Drawing.Size(176, 21);
            tWR_NUMERLabel.Text = "TWR NUMER:";
            // 
            // tWR_NUMERTextBox
            // 
            this.tWR_NUMERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_NUMER", true));
            this.tWR_NUMERTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_NUMERTextBox.Location = new System.Drawing.Point(4, 195);
            this.tWR_NUMERTextBox.Name = "tWR_NUMERTextBox";
            this.tWR_NUMERTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_NUMERTextBox.TabIndex = 5;
            // 
            // tWR_SKROTLabel
            // 
            tWR_SKROTLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_SKROTLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_SKROTLabel.Location = new System.Drawing.Point(4, 247);
            tWR_SKROTLabel.Name = "tWR_SKROTLabel";
            tWR_SKROTLabel.Size = new System.Drawing.Size(168, 21);
            tWR_SKROTLabel.Text = "TWR SKROT:";
            // 
            // tWR_SKROTTextBox
            // 
            this.tWR_SKROTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_SKROT", true));
            this.tWR_SKROTTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_SKROTTextBox.Location = new System.Drawing.Point(4, 276);
            this.tWR_SKROTTextBox.Name = "tWR_SKROTTextBox";
            this.tWR_SKROTTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_SKROTTextBox.TabIndex = 7;
            // 
            // tWR_NAZWALabel
            // 
            tWR_NAZWALabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_NAZWALabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_NAZWALabel.Location = new System.Drawing.Point(4, 328);
            tWR_NAZWALabel.Name = "tWR_NAZWALabel";
            tWR_NAZWALabel.Size = new System.Drawing.Size(177, 21);
            tWR_NAZWALabel.Text = "TWR NAZWA:";
            // 
            // tWR_NAZWATextBox
            // 
            this.tWR_NAZWATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_NAZWA", true));
            this.tWR_NAZWATextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_NAZWATextBox.Location = new System.Drawing.Point(4, 357);
            this.tWR_NAZWATextBox.Name = "tWR_NAZWATextBox";
            this.tWR_NAZWATextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_NAZWATextBox.TabIndex = 9;
            // 
            // tWR_KGLabel
            // 
            tWR_KGLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_KGLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_KGLabel.Location = new System.Drawing.Point(4, 409);
            tWR_KGLabel.Name = "tWR_KGLabel";
            tWR_KGLabel.Size = new System.Drawing.Size(121, 21);
            tWR_KGLabel.Text = "TWR KG:";
            // 
            // tWR_KGTextBox
            // 
            this.tWR_KGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_KG", true));
            this.tWR_KGTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_KGTextBox.Location = new System.Drawing.Point(4, 438);
            this.tWR_KGTextBox.Name = "tWR_KGTextBox";
            this.tWR_KGTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_KGTextBox.TabIndex = 11;
            // 
            // tWR_SLJM_KODLabel
            // 
            tWR_SLJM_KODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_SLJM_KODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_SLJM_KODLabel.Location = new System.Drawing.Point(4, 490);
            tWR_SLJM_KODLabel.Name = "tWR_SLJM_KODLabel";
            tWR_SLJM_KODLabel.Size = new System.Drawing.Size(208, 21);
            tWR_SLJM_KODLabel.Text = "TWR SLJM KOD:";
            // 
            // tWR_SLJM_KODTextBox
            // 
            this.tWR_SLJM_KODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_SLJM_KOD", true));
            this.tWR_SLJM_KODTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_SLJM_KODTextBox.Location = new System.Drawing.Point(4, 519);
            this.tWR_SLJM_KODTextBox.Name = "tWR_SLJM_KODTextBox";
            this.tWR_SLJM_KODTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_SLJM_KODTextBox.TabIndex = 13;
            // 
            // tWR_CZY_ROZCHODLabel
            // 
            tWR_CZY_ROZCHODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_CZY_ROZCHODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_CZY_ROZCHODLabel.Location = new System.Drawing.Point(4, 571);
            tWR_CZY_ROZCHODLabel.Name = "tWR_CZY_ROZCHODLabel";
            tWR_CZY_ROZCHODLabel.Size = new System.Drawing.Size(260, 21);
            tWR_CZY_ROZCHODLabel.Text = "TWR CZY ROZCHOD:";
            // 
            // tWR_CZY_ROZCHODTextBox
            // 
            this.tWR_CZY_ROZCHODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_CZY_ROZCHOD", true));
            this.tWR_CZY_ROZCHODTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_CZY_ROZCHODTextBox.Location = new System.Drawing.Point(4, 600);
            this.tWR_CZY_ROZCHODTextBox.Name = "tWR_CZY_ROZCHODTextBox";
            this.tWR_CZY_ROZCHODTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_CZY_ROZCHODTextBox.TabIndex = 15;
            // 
            // tWR_CZY_PRZYCHODLabel
            // 
            tWR_CZY_PRZYCHODLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_CZY_PRZYCHODLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_CZY_PRZYCHODLabel.Location = new System.Drawing.Point(4, 652);
            tWR_CZY_PRZYCHODLabel.Name = "tWR_CZY_PRZYCHODLabel";
            tWR_CZY_PRZYCHODLabel.Size = new System.Drawing.Size(274, 21);
            tWR_CZY_PRZYCHODLabel.Text = "TWR CZY PRZYCHOD:";
            // 
            // tWR_CZY_PRZYCHODTextBox
            // 
            this.tWR_CZY_PRZYCHODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_CZY_PRZYCHOD", true));
            this.tWR_CZY_PRZYCHODTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_CZY_PRZYCHODTextBox.Location = new System.Drawing.Point(4, 681);
            this.tWR_CZY_PRZYCHODTextBox.Name = "tWR_CZY_PRZYCHODTextBox";
            this.tWR_CZY_PRZYCHODTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_CZY_PRZYCHODTextBox.TabIndex = 17;
            // 
            // tWR_STANLabel
            // 
            tWR_STANLabel.Dock = System.Windows.Forms.DockStyle.Top;
            tWR_STANLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tWR_STANLabel.Location = new System.Drawing.Point(4, 733);
            tWR_STANLabel.Name = "tWR_STANLabel";
            tWR_STANLabel.Size = new System.Drawing.Size(151, 21);
            tWR_STANLabel.Text = "TWR STAN:";
            // 
            // tWR_STANTextBox
            // 
            this.tWR_STANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOWARYBindingSource, "TWR_STAN", true));
            this.tWR_STANTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tWR_STANTextBox.Location = new System.Drawing.Point(4, 762);
            this.tWR_STANTextBox.Name = "tWR_STANTextBox";
            this.tWR_STANTextBox.Size = new System.Drawing.Size(100, 41);
            this.tWR_STANTextBox.TabIndex = 19;
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
            // TOWARYEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.tWR_STANTextBox);
            this.Controls.Add(tWR_STANLabel);
            this.Controls.Add(this.tWR_CZY_PRZYCHODTextBox);
            this.Controls.Add(tWR_CZY_PRZYCHODLabel);
            this.Controls.Add(this.tWR_CZY_ROZCHODTextBox);
            this.Controls.Add(tWR_CZY_ROZCHODLabel);
            this.Controls.Add(this.tWR_SLJM_KODTextBox);
            this.Controls.Add(tWR_SLJM_KODLabel);
            this.Controls.Add(this.tWR_KGTextBox);
            this.Controls.Add(tWR_KGLabel);
            this.Controls.Add(this.tWR_NAZWATextBox);
            this.Controls.Add(tWR_NAZWALabel);
            this.Controls.Add(this.tWR_SKROTTextBox);
            this.Controls.Add(tWR_SKROTLabel);
            this.Controls.Add(this.tWR_NUMERTextBox);
            this.Controls.Add(tWR_NUMERLabel);
            this.Controls.Add(this.tWR_STATUSTextBox);
            this.Controls.Add(tWR_STATUSLabel);
            this.Controls.Add(this.tWR_IDTextBox);
            this.Controls.Add(tWR_IDLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "TOWARYEditViewDialog";
            this.Text = "TOWARYEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.TOWARYEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.tOWARYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tOWARYBindingSource;
        private System.Windows.Forms.TextBox tWR_IDTextBox;
        private System.Windows.Forms.TextBox tWR_STATUSTextBox;
        private System.Windows.Forms.TextBox tWR_NUMERTextBox;
        private System.Windows.Forms.TextBox tWR_SKROTTextBox;
        private System.Windows.Forms.TextBox tWR_NAZWATextBox;
        private System.Windows.Forms.TextBox tWR_KGTextBox;
        private System.Windows.Forms.TextBox tWR_SLJM_KODTextBox;
        private System.Windows.Forms.TextBox tWR_CZY_ROZCHODTextBox;
        private System.Windows.Forms.TextBox tWR_CZY_PRZYCHODTextBox;
        private System.Windows.Forms.TextBox tWR_STANTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}
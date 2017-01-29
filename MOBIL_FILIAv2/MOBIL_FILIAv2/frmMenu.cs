using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOBIL_FILIAv2
{
    public partial class frmMenu : Form
    {
        public static Form PreviousForm;
        public int Id=1;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello User!");
        }

        private void btnRozchod_Click(object sender, EventArgs e)
        {
            frmRozchod frmRoz = new frmRozchod(this);
            frmRoz.Show();
            this.Hide();

        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            frmMagazyn frmMag = new frmMagazyn(this);
            frmMag.Show();
            this.Hide();
        }
    }
}
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
    public partial class frmStanMagazynowy : Form
    {
        frmMagazyn prvForm;
        public frmStanMagazynowy(frmMagazyn form)
        {
            InitializeComponent();
            prvForm = form;
        }

        private void frmStanMagazynowy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDBDataSet1.StanMagazynowy' table. You can move, or remove it, as needed.
            this.stanMagazynowyTableAdapter.Fill(this.localDBDataSet1.StanMagazynowy);

        }

        private void btnStanMagWyjscie_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
        }
    }
}
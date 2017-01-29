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
    public partial class frmDodajNaMagazynPodsumowanie : Form
    {
        public frmDodajNaMagazynPodsumowanie()
        {
            InitializeComponent();
        }

        private void frmDodajNaMagazynPodsumowanie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDBDataSet.PozycjeNaMagazyn' table. You can move, or remove it, as needed.
            this.pozycjeNaMagazynTableAdapter.Fill(this.localDBDataSet.PozycjeNaMagazyn);


        }
    }
}
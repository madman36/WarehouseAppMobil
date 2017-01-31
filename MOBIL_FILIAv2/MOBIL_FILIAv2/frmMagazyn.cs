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
    public partial class frmMagazyn : Form
    {
        frmMenu prvForm;
        public frmMagazyn(frmMenu form)
        {
            InitializeComponent();
            prvForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDodajPozycje frmDP = new frmDodajPozycje(this);
            frmDP.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStanMagazynowy frmSM = new frmStanMagazynowy(this);
            frmSM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
        }

        private void frmMagazyn_Load(object sender, EventArgs e)
        {

        }
 
    }
}
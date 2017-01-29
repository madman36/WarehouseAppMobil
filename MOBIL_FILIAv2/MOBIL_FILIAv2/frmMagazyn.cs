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
        public frmMagazyn(Form form)
        {
            InitializeComponent();
            frmMenu.PreviousForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDodajPozycje frmDodajPoz = new frmDodajPozycje(this);
            frmDodajPoz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.PreviousForm.Show();
        }
    }
}
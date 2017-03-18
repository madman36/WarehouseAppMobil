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
    public partial class frmDokumentTransportowy : Form
    {
        frmRozchod prvForm;
        public frmDokumentTransportowy(frmRozchod form)
        {
            InitializeComponent();
            prvForm = form; // poprzednia formatka
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_ParentChanged(object sender, EventArgs e)
        {

        }

        private void DokumentTransportowy_Load(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            frmPrzewoznikLista frmPL = new frmPrzewoznikLista(this);
            this.Hide();
            frmPL.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPozycjeDokumentu frmPD = new frmPozycjeDokumentu(this);
            frmPD.Show();
        }
    }
}
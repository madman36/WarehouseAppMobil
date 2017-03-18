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
    public partial class frmPozycjeDokumentu : Form
    {
        frmDokumentTransportowy prvForm;
        public frmPozycjeDokumentu(frmDokumentTransportowy form)
        {
            InitializeComponent();
            prvForm = form;
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void frmPozycjeDokumentu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDBDataSet1.StanMagazynowy' table. You can move, or remove it, as needed.
            this.stanMagazynowyTableAdapter.Fill(this.localDBDataSet1.StanMagazynowy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tutaj pojawi się stan magazynowy z mozliwością wyboru pojemnika i dodania go do listy wysyłkowej");
        }
    }
}
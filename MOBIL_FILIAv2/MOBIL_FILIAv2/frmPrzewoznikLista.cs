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
    public partial class frmPrzewoznikLista : Form
    {
        frmDokumentTransportowy prvForm;
        public frmPrzewoznikLista(frmDokumentTransportowy form)
        {
            InitializeComponent();
            prvForm = form;
            
        }

        private void frmPrzewoznikLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOBIL_FILIADataSet.KONTRAHENCI' table. You can move, or remove it, as needed.
            this.kONTRAHENCITableAdapter.Fill(this.mOBIL_FILIADataSet.KONTRAHENCI);

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
        }
    }
}
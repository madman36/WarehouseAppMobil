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
    public partial class frmDodajPozycje : Form
    {
        private Form PreviousForm;
        public frmDodajPozycje(Form form)
        {
            InitializeComponent();
            frmMenu.PreviousForm = form;
        }


        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            dgDodajPozycje.Select(dgDodajPozycje.CurrentRowIndex);
        }

        private void DodajPozycje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOBIL_FILIAv2DBDataSet.StanPojemniki' table. You can move, or remove it, as needed.
            this.stanPojemnikiTableAdapter.Fill(this.mOBIL_FILIAv2DBDataSet.StanPojemniki);


        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            stanPojemnikiBindingSource.AddNew();
            MOBIL_FILIAv2.StanPojemnikiEditViewDialog stanpojemnikiEditViewDialog = MOBIL_FILIAv2.StanPojemnikiEditViewDialog.Instance(this.stanPojemnikiBindingSource);
            stanpojemnikiEditViewDialog.ShowDialog();

        }

        private void dgDodajPozycje_Click(object sender, EventArgs e)
        {
            MOBIL_FILIAv2.StanPojemnikiSummaryViewDialog stanpojemnikiSummaryViewDialog = MOBIL_FILIAv2.StanPojemnikiSummaryViewDialog.Instance(this.stanPojemnikiBindingSource);
            stanpojemnikiSummaryViewDialog.ShowDialog();

        }
    }
}
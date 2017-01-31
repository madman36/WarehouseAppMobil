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
    public partial class frmListaPozycji : Form
    {
        frmMagazyn prvForm;
        public frmListaPozycji(frmMagazyn form)
        {
            InitializeComponent();
            prvForm = form;
        }

        private void frmListaPozycji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDBDataSet1.StanMagazynowy' table. You can move, or remove it, as needed.
            this.stanMagazynowyTableAdapter.Fill(this.localDBDataSet1.StanMagazynowy);
            // TODO: This line of code loads data into the 'listaPozycji.PozycjeNaMagazyn' table. You can move, or remove it, as needed.
            this.pozycjeNaMagazynTableAdapter.Fill(this.listaPozycji.PozycjeNaMagazyn);
            // TODO: This line of code loads data into the 'listaPozycji.PozycjeNaMagazyn' table. You can move, or remove it, as needed.
            this.pozycjeNaMagazynTableAdapter.Fill(this.listaPozycji.PozycjeNaMagazyn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            this.dataGrid1.CurrentCellChanged += new EventHandler(Grid_CurCellChange);
        }

        private void Grid_CurCellChange(object sender, EventArgs e)
        {
            // String variable used to show message.
            string myString = "CurrentCellChanged event raised, cell focus is at ";
            // Get the co-ordinates of the focussed cell.
            string myPoint = dataGrid1.CurrentCell.ColumnNumber + "," +
                           dataGrid1.CurrentCell.RowNumber;
            // Create the alert message.
            myString = myString + "(" + myPoint + ")";
            // Show Co-ordinates when CurrentCellChanged event is raised.
            MessageBox.Show(myString, "Current cell co-ordinates");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
        }
    }
}
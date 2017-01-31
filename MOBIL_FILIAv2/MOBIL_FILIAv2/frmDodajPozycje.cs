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
        frmMagazyn prvForm;
        
        public frmDodajPozycje(frmMagazyn form)
        {
            InitializeComponent();
            prvForm = form;
            button1.BackColor = Color.Red;
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

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prvForm.Show();
            
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string numer = txtNumer.Text;
            string opk = comboBox1.Text;
            string date = dateTimePicker1.Text;
            string ilosc = txtilosc.Text;
            if (numer != null && opk != null && date != null && ilosc != null)
            {
                stanMagazynowyTableAdapter1.Insert(numer, "Towar", ilosc, date, opk);
                button1.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
        }
    }
}
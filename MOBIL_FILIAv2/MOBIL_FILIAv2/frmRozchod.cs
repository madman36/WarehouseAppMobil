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
    public partial class frmRozchod : Form
    {

        public frmRozchod(frmMenu form)
        {
            InitializeComponent();
            frmMenu.PreviousForm = form;

            DataGridTableStyle dgts = new DataGridTableStyle();
            dgts.MappingName = "StanPojemniki";

            DataGridColumnStyle textCol = new DataGridTextBoxColumn();
            textCol.MappingName = "id";
            textCol.HeaderText = "Id";
            textCol.Width = 45;
            dgts.GridColumnStyles.Add(textCol);
            DataGridColumnStyle textCol1 = new DataGridTextBoxColumn();
            textCol1.MappingName = "indeks";
            textCol1.HeaderText = "Indeks";
            textCol1.Width = 110;
            dgts.GridColumnStyles.Add(textCol1);
            DataGridColumnStyle textCol2 = new DataGridTextBoxColumn();
            textCol2.MappingName = "nazwa";
            textCol2.HeaderText = "Nazwa";
            textCol2.Width = 170;
            dgts.GridColumnStyles.Add(textCol2);
            DataGridColumnStyle textCol3 = new DataGridTextBoxColumn();
            textCol3.MappingName = "ilosc";
            textCol3.HeaderText = "Ilosc";
            textCol3.Width = 90;
            dgts.GridColumnStyles.Add(textCol3);

            dgRozchod.TableStyles.Add(dgts);

           // PropertyDescriptorCollection pcol = this.BindingContext[tableStanPojemniki, "MOBIL_FILIAv2DBDataSet.StanPojemniki"].GetItemProperties();


        }

        //public frmRozchod(Form form)
        //    : this()
        //{
        //    PreviousForm = form;
        //}

        

       


        private void frmRozchod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobiL_FILIAv2DBDataSet1.StanPojemniki' table. You can move, or remove it, as needed.
            this.stanPojemnikiTableAdapter.Fill(this.mobiL_FILIAv2DBDataSet1.StanPojemniki);

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            dgRozchod.Select(dgRozchod.CurrentRowIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            this.Hide();
            frmMenu.PreviousForm.Show();
        }

       

        public static void SortDataGrid(object sender, MouseEventArgs e)
        {
            DataGrid.HitTestInfo hitTest;
            DataTable dataTable;
            DataView dataView;
            string columnName;
            DataGrid dataGrid;

            // Use only left mouse button clicks
            if (e.Button == MouseButtons.Left)
            {
                // Set dataGrid equal to the object that called this event handler
                dataGrid = (DataGrid)sender;

                // Perform a hit test to determine where the mousedown event occurred
                hitTest = dataGrid.HitTest(e.X, e.Y);

                // If the MouseDown event occurred on a column header,
                // then perform the sorting operation.
                if (hitTest.Type == DataGrid.HitTestType.ColumnHeader)
                {
                    // Get the DataTable associated with this DataGrid.
                    dataTable = (DataTable)dataGrid.DataSource;

                    // Get the DataView associated with the DataTable.
                    dataView = dataTable.DefaultView;

                    // Get the name of the column that was clicked.
                    if (dataGrid.TableStyles.Count != 0)
                        columnName = dataGrid.TableStyles[0].GridColumnStyles[hitTest.Column].MappingName;
                    else
                        columnName = dataTable.Columns[hitTest.Column].ColumnName;

                    // If the sort property of the DataView is already the current
                    // column name, sort that column in descending order.
                    // Otherwise, sort on the column name.
                    if (dataView.Sort == columnName)
                        dataView.Sort = columnName + " DESC";
                    else
                        dataView.Sort = columnName;
                }
            }
        }


        private void dgDataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dgRozchod.VisibleRowCount == 0) return;
            SortDataGrid(sender, e);
            dgRozchod.Select(dgRozchod.CurrentRowIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDokumentTransportowy frmDokTr = new frmDokumentTransportowy(this);
            this.Hide();
            frmDokTr.Show();
        }

        private void stanPojemnikiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
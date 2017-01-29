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
    public partial class TOWARYEditViewDialog : Form
    {
        public TOWARYEditViewDialog()
        {
            InitializeComponent();
        }

        private void TOWARYEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.tOWARYBindingSource.EndEdit();

        }
    }
}
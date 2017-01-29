using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace MOBIL_FILIAv2
{
    static class Program
    {
        static int CURRENT_FORM_ID { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            frmMenu frmMenu = new frmMenu();
            Application.Run(frmMenu);
        }
    }
}
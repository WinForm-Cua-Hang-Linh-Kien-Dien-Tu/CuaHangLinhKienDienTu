using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Main
{
    static class Program
    {
        static Form_DangNhap frmDN = null;
        static Form1 frm1 = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new Form_DangNhap();
            frm1 = new Form1();
            Application.Run(frm1);
        }
    }
}

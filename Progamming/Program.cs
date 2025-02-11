using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progamming
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form9());
            Application.Run(new frmMainMenu());
            //Application.Run(new frmLogin());
            //Application.Run(new frmSupplier());
            //Application.Run(new frmProductType());
            //Application.Run(new _4COM_IT_App.frmProducts());
            //Application.Run(new frmProduct());

        }
    }
}

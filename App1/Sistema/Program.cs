using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MenuPrincipal());
            }

            login.Dispose();


            


           



        }
    }
}

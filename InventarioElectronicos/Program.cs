using System;
using System.Windows.Forms;

namespace GestionInventariosElectronicos
{
    internal static class Programa
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal());
        }
    }
}

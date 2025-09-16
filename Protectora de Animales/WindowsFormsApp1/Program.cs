using System;
using System.Windows.Forms;
using WindowsFormsApp1.menuAdopter;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fm_ShowAvailableAnimals());
        }
    }
}

using Sub3PAW.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3PAW
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Salariat> salariati = new List<Salariat>() { new Salariat(13, "Gigi", 35.3f, 1975.39m), new Salariat(15, "Maricica", 19.76f, 2741.92m), new Salariat(21, "Ionica", 49.32f, 5723.11m)};
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(salariati));
        }
    }
}

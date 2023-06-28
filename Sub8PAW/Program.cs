using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub8PAW
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Prod> produse = new List<Prod>();
            using(var sr = new StreamReader("../../date.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    produse.Add(new Prod(int.Parse(values[0]), values[1], float.Parse(values[2], CultureInfo.InvariantCulture)));
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(produse));
        }
    }
}

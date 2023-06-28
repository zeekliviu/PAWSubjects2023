using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub4PAW
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Tren> trenuri = new List<Tren>();
            using(var sr = new StreamReader("../../date.txt"))
            {
                string line;
                while((line = sr.ReadLine())!=null)
                {
                    var values = line.Split(',');
                    var codT = int.Parse(values[0]);
                    var nrV = int.Parse(values[1]);
                    List<Vagon> vagoane = new List<Vagon>();
                    for(int i=0; i<nrV; i++)
                    {
                        var valuesVagoane = sr.ReadLine().Split(',');
                        vagoane.Add(new Vagon(int.Parse(valuesVagoane[0]), valuesVagoane[1], float.Parse(valuesVagoane[2], CultureInfo.InvariantCulture)));
                    }
                    trenuri.Add(new Tren(codT, vagoane));
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(trenuri));
        }
    }
}

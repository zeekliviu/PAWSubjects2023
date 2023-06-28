using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub9PAW
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<ProgramStudiu> programe = new List<ProgramStudiu>();
            List<Candidat> candidati = new List<Candidat>();
            using(var sr = new StreamReader("../../programe.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    programe.Add(new ProgramStudiu(int.Parse(values[0]), values[1], int.Parse(values[2]), int.Parse(values[3])));
                }
            }
            using(var sr = new StreamReader("../../candidati.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    var length = int.Parse(values[3]);
                    var optiuniMaster = new int[length];
                    for(int i=0; i<length; i++)
                    {
                        optiuniMaster[i] = int.Parse(sr.ReadLine());
                    }
                    candidati.Add(new Candidat(int.Parse(values[0]), values[1], float.Parse(values[2], CultureInfo.InvariantCulture), optiuniMaster));
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(candidati, programe));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicicleteCiureaByZeek
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Bicicleta> biciclete = new List<Bicicleta>();  
            List<Utilizator> utilizatori = new List<Utilizator>();
            using(var sr = new StreamReader("../../biciclete.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    biciclete.Add(new Bicicleta(int.Parse(values[0]), values[1], int.Parse(values[2])));
                }
            }
            using(var sr = new StreamReader("../../utilizatori.txt"))
            {
                string line;
                while(( line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    utilizatori.Add(new Utilizator(int.Parse(values[0]), values[1], int.Parse(values[2]), int.Parse(values[3])));
                }
            }
            Dictionary<Bicicleta, List<Utilizator>> inchirieri = new Dictionary<Bicicleta, List<Utilizator>>();
            foreach(var bicla in biciclete)
            {
                List<Utilizator> utilizariBicla = new List<Utilizator>();
                foreach(var user in utilizatori)
                {
                    if (bicla.CodB == user.CodB)
                        utilizariBicla.Add(user);
                }
                inchirieri.Add(bicla, utilizariBicla);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(inchirieri));
        }
    }
}

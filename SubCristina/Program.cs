using SubCristina.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubCristina
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CardTransport[] carduri = new CardTransport[50];
            Calatorie[] calatorii = new Calatorie[50];
            using (var reader = new StreamReader("../../carduri.txt"))
            {
                string linie;
                int i = 0;
                while ((linie = reader.ReadLine()) != null)
                {
                    var values = linie.Split(',');
                    carduri[i] = new CardTransport(int.Parse(values[0]), values[1], float.Parse(values[2], CultureInfo.InvariantCulture));
                    i++;
                }
            }
            using (var reader = new StreamReader("../../calatorii.txt"))
            {
                string linie;
                int i = 0;
                while ((linie = reader.ReadLine()) != null)
                {
                    var values = linie.Split(',');
                    calatorii[i] = new Calatorie(float.Parse(values[0], CultureInfo.InvariantCulture), int.Parse(values[1]), int.Parse(values[2]));
                    i++;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(carduri, calatorii));
        }
    }
}

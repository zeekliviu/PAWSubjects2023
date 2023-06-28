using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicleteCiureaByZeek
{
    [Serializable]
    public class Bicicleta
    {
        private readonly int codB;
        private string denumireStatieParcare;
        private int kmParcursi;

        public int CodB { get => codB; }
        public string Denumire { get => denumireStatieParcare; set => denumireStatieParcare = value; }
        public int KM { get => kmParcursi; set => kmParcursi = value; }

        public Bicicleta()
        {

        }

        public Bicicleta(int codB, string denumireStatieParcare, int kmParcursi)
        {
            this.codB = codB;
            this.denumireStatieParcare = denumireStatieParcare;
            this.kmParcursi = kmParcursi;
        }


    }
}

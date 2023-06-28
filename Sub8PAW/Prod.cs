using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub8PAW
{
    public class Prod
    {
        public int cod;
        public string denumire;
        private float pret;

        public float Pret { get => pret; set => pret = value; }

        public Prod() { }


        public Prod(int cod, string denumire, float pret)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
        }

        public static bool operator <(Prod lhs, Prod rhs)
        {
            return lhs.pret < rhs.pret;
        }

        public static bool operator >(Prod lhs, Prod rhs)
        {
            return lhs.pret > rhs.pret;
        }

        public override string ToString()
        {
            return "Cod " + cod + " Denumire " + denumire + " Pret " + pret;
        }
    }
}

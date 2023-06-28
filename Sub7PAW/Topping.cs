using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub7PAW
{
    public class Topping
    {
        private string denumire;
        private float pret;
        private float cantitate;
        private readonly int cod;

        public float Pret { get => pret; set => pret = value; }
        public float Cantitate { get => cantitate; set => cantitate = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public int Cod => cod;

        public Topping(string denumire, float pret, int cod)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cod = cod;
        }

        public Topping(string denumire, float pret, float cantitate, int cod):this(denumire, pret, cod)
        {
            this.cantitate = cantitate;
        }
        public override string ToString()
        {
            return "Cod " + cod + " Denumire " + denumire + " Cantitate " + cantitate + " Pret " + pret.ToString("C");
        }
    }
}

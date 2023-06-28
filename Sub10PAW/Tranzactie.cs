using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub10PAW
{
    public class Tranzactie
    {
        private string tip;
        private float valoare;

        public string Tip { get => tip; set => tip = value; }
        public float Valoare { get => valoare; set => valoare = value; }

        public Tranzactie() { }

        public Tranzactie(string tip, float valoare)
        {
            this.tip = tip;
            this.valoare = valoare;
        }

        public override string ToString()
        {
            return "Tip " + tip + " Valoare " + valoare;
        }
    }
}

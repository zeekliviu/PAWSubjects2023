using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubCristina.entities
{
    public class Calatorie
    {
        private float valoare;
        private int codC;
        private int distanta;

        public float Valoare { get => valoare; set => valoare = value; }
        public int CodC { get => codC; set => codC = value; }
        public int Distanta { get => distanta; set => distanta = value; }

        public Calatorie() { }

        public Calatorie(float valoare, int codC, int distanta): this()
        {
            this.valoare = valoare;
            this.codC = codC;
            this.distanta = distanta;
        }

        public override string ToString()
        {
            return "Calatoria clientului cu codul: " + codC + " pe distanta de " + distanta + " in valoare de " + valoare;
        }
    }
}

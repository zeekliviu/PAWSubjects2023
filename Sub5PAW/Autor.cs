using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub5PAW
{
    public class Autor
    {
        private string nume;
        private string grad_didactic;
        private int marca;

        public string Nume { get => nume; set=> nume = value; }
        public string Grad_Didactic { get => grad_didactic; set => grad_didactic = value; }
        public int Marca { get => marca; set => marca = value; }

        public Autor()
        {

        }

        public Autor(string nume, string grad_didactic, int marca)
        {
            this.nume = nume;
            this.grad_didactic = grad_didactic;
            this.marca = marca;
        }
        public override string ToString()
        {
            return "Marca: " + marca + " Grad didactic: " + grad_didactic + " Nume: " + nume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub3PAW.entities
{
    public class Salariat
    {
        private int marca;
        private string nume;
        private float nr_ore;
        private decimal salariu;

        public int Marca { get => marca; set => marca = value; }
        public string Nume { get => nume; set => nume = value; }
        public float NrOre { get=>nr_ore; set => nr_ore = value; }
        public decimal Salariu { get=>salariu; set => salariu = value; }

        public Salariat()
        {
        }

        public Salariat(int marca, string nume, float nr_ore, decimal salariu)
        {
            this.marca = marca;
            this.nume = nume;
            this.nr_ore = nr_ore;
            this.salariu = salariu;
        }

        public decimal CalculSalariu()
        {
            return salariu * (decimal)nr_ore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub11PAW
{
    public class Vehicul
    {
        private int marca;
        private int an_fabricatie;

        public int Marca { get => marca; set => marca = value; }
        public int An { get => an_fabricatie; set => an_fabricatie = value; }

        public Vehicul() { }

        public Vehicul(int marca, int an_fabricatie)
        {
            this.marca = marca;
            this.an_fabricatie = an_fabricatie;
        }
    }
}

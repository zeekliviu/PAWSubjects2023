using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub11PAW
{
    public class Autoturism: Vehicul
    {
        private int nrUsi;

        public int NrUsi { get=> nrUsi; set => nrUsi = value; }

        public Autoturism()
        {
            
        }

        public Autoturism(int marca, int an_fab, int nrUsi): base(marca, an_fab)
        {
            this.nrUsi = nrUsi;
        }


    }
}

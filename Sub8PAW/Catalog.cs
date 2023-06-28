using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub8PAW
{
    public class Catalog
    {
        private List<Prod> produse;

        public List<Prod> Produse { get => produse; set => produse = value; }

        public Catalog() {
            produse = new List<Prod>();
        }

        public Catalog(List<Prod> produse):this()
        {
            this.produse = produse;
        }
    }
}

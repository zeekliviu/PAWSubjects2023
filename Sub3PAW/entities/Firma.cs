using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub3PAW.entities
{
    public class Firma
    {
        private List<Salariat> salariati;

        public List<Salariat> Salariati { get => salariati; set => salariati = value; }

        public Firma()
        {
            salariati = new List<Salariat>();
        }

        public Firma(List<Salariat> salariati)
        {
            this.salariati = salariati;
        }

        public decimal FondSalariati()
        {
            if (salariati.Count == 0)
                return 0;
            decimal result = 0;
            foreach (var salariat in salariati)
                result += salariat.Salariu * (decimal)salariat.NrOre;
            return result;
        }

        public Salariat this[int index]
        {
            get { return salariati[index]; }
            set { salariati[index] = value; }
        }

        public void addSalariat(Salariat salariat)
        {
            salariati.Add(salariat);
        }
    }
}

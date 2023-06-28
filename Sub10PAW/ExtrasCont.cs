using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub10PAW
{
    public class ExtrasCont
    {
        private string numeClient;
        private string adresa;
        private Tranzactie[] tranzactii;

        public string Nume { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public Tranzactie[] Tranzactii { get => tranzactii; set => tranzactii = value; }

        public ExtrasCont()
        {
            
        }

        public ExtrasCont(string numeClient, string adresa, Tranzactie[] tranzactii)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzactii = tranzactii;
        }

        public Tranzactie this[int index]
        {
            get { if (index >= 0 && index < tranzactii.Length) return tranzactii[index]; return null; }
            set { if (index >= 0 && index < tranzactii.Length) tranzactii[index] = value; }
        }
    }
}

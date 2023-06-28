using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubCristina.entities
{
    public class CardTransport: IComparable<CardTransport>
    {
        private readonly int codC;
        private string nume;
        private float sold;

        public int CodC { get => codC; }
        public string Nume { get => nume; set => nume = value; }
        public float Sold { get => sold; set => sold = value; }

        public CardTransport()
        {

        }

        public CardTransport(int codC, string nume, float sold): this()
        {
            this.codC = codC;
            this.nume = nume;
            this.sold = sold;
        }
        public override string ToString()
        {
            return nume + ", Sold: " + sold + " lei";
        }

        public static float operator +(float f, CardTransport ct)
        {
            return f + ct.sold;
        }

        public int CompareTo(CardTransport other)
        {
            return sold.CompareTo(other.sold);
        }
    }
}

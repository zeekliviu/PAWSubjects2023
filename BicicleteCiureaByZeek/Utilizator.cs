using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicleteCiureaByZeek
{
    [Serializable]
    public class Utilizator
    {
        private readonly int codU;
        private string nume;
        private int codB;
        private int durataUtilizare;

        public int CodU { get => codU; }
        public string Nume { get => nume; set=> nume = value; }
        public int CodB { get => codB; set => codB = value; }
        public int Durata { get => durataUtilizare; set => durataUtilizare = value;}

        public Utilizator()
        {

        }

        public Utilizator(int codU, string nume, int codB, int durataUtilizare)
        {
            this.codU = codU;
            this.nume = nume;
            this.codB = codB;
            this.durataUtilizare = durataUtilizare;
        }

        public override string ToString()
        {
            return codU + " " + nume + " " + codB + " " + durataUtilizare;
        }
    }
}

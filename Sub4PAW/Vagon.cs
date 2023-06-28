using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub4PAW
{
    public class Vagon
    {
        private int codV;
        private string descriereTIP;
        private float capacitate;

        public int CodV { get => codV; set => codV = value; }
        public string DescriereTIP { get => descriereTIP; set => descriereTIP = value; }
        public float Capacitate { get => capacitate; set => capacitate = value; }

        public Vagon() { }

        public Vagon(int codV, string descriereTIP, float capacitate):this()
        {
            this.codV = codV;
            this.descriereTIP = descriereTIP;
            this.capacitate = capacitate;
        }

        public override string ToString()
        {
            return "Vagon " + codV + " Descriere: " + descriereTIP + " Capacitate " + capacitate;
        }
    }
}

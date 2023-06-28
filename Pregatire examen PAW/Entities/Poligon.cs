using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_examen_PAW.Entities
{
    [Serializable]
    public class Poligon
    {
        private Punct[] puncte;
        private int nrPuncte;
        private Color color;
        public float grosime_linie { get; set; }
        private readonly int cod_figura;
        public string eticheta { get; set; }

        public Color Color { get=>color; set => color = value; }
        public int NrPuncte => nrPuncte;
        public Punct[] Puncte => puncte;

        public Poligon()
        {
            puncte = new Punct[0];
            nrPuncte = 0;
            color = Color.White;
            grosime_linie = 0;
            cod_figura = 0;
            eticheta = string.Empty;
        }
        public Poligon(Punct[] puncte, Color color, float grosime_linie, int cod_figura, string eticheta): this()
        {
            this.puncte = puncte;
            this.nrPuncte = puncte.Length;
            this.color = color;
            this.grosime_linie = grosime_linie;
            this.cod_figura = cod_figura;
            this.eticheta = eticheta;
        }
        public Punct this[int index]
        {
            get { if (nrPuncte != 0 && index >= 0 && index <= nrPuncte) return puncte[index]; else return new Punct(); }
            set { if (nrPuncte != 0 && index >= 0 && index <= nrPuncte) puncte[index] = value; }
        }

        public int getCod()
        {
            return cod_figura;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub11PAW
{
    public sealed class Camion: Autoturism, ICloneable, IComparable<Camion>
    {
        private int[] marfuri;

        public int[] Marfuri { get => marfuri; set => marfuri = value; }

        public Camion() {
        }

        public Camion(int marca, int an_fab, int nrUsi, int[] marfuri):base(marca, an_fab, nrUsi)
        {
            this.marfuri = marfuri;
        }

        public int CompareTo(Camion other)
        {
            return marfuri.Length.CompareTo(other.marfuri.Length);
        }

        public object Clone()
        {
            var c = new Camion();
            c.marfuri = new int[marfuri.Length];
            Array.Copy(marfuri, c.marfuri, marfuri.Length);
            return c;
        }

        public static Camion operator +(Camion a, int b)
        {
            var aux = new int[a.marfuri.Length+1];
            Array.Copy(a.marfuri, aux, a.marfuri.Length);
            aux[a.marfuri.Length] = b;
            a.marfuri = aux;
            return a;
        }

        public static implicit operator double(Camion a)
        {
            var total = 0;
            foreach (var el in a.marfuri)
                total += el;
            return total/a.marfuri.Length;
        }
        public override string ToString()
        {
            var sb = new StringBuilder("Marca: " + Marca + " An fabricatie: " + An + " Nr. usi: " + NrUsi + " Cantitati marfuri: ");
            foreach(var el in marfuri)
                sb.Append(el.ToString()).Append(", ");
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}

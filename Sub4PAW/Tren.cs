using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub4PAW
{
    public class Tren
    {
        private List<Vagon> vagoane;
        private int nrVagoane;
        private int codT;

        public List<Vagon> Vagoane { get => vagoane; set => vagoane = value; }
        public int NrVagoane { get => nrVagoane; set => nrVagoane = value; }
        public int CodT { get => codT; set => codT = value; }

        public Tren()
        {
            vagoane = new List<Vagon>();
            nrVagoane = 0;
            codT = 0;
        }

        public Tren(int codT, List<Vagon> vagoane): this()
        {
            this.vagoane = vagoane;
            nrVagoane = vagoane.Count;
            this.codT = codT;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var v in vagoane)
                sb.AppendLine(v.ToString());
            return sb.ToString();
        }

        public static Tren operator +(Tren v1, Tren v2)
        {
            var rez = new Tren();
            foreach(var v in v1.vagoane)
            {
                rez.vagoane.Add(v);
            }
            foreach(var v in v2.vagoane)
            {
                rez.vagoane.Add(v);
            }
            rez.nrVagoane = v1.nrVagoane + v2.nrVagoane;
            rez.codT = v1.codT;
            return rez;
        }

        public static int operator <(Tren v1, Tren v2)
        {
            return v1.nrVagoane.CompareTo(v2.nrVagoane);
        }

        public static int operator >(Tren v1, Tren v2)
        {
            return v1.nrVagoane.CompareTo(v2.nrVagoane);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub9PAW
{
    public class ProgramStudiu
    {
        private int codProgram;
        private string denumireProgram;
        private int numarLocuriBuget;
        private int numarLocuriTaxa;

        public int CodProgram { get=>codProgram; set => codProgram = value; }
        public string DenumireProgram { get => denumireProgram; set => denumireProgram = value; }
        public int NumarLocuriBuget { get => numarLocuriBuget; set=> numarLocuriBuget = value; }
        public int NumarLocuriTaxa { get => numarLocuriTaxa; set=> numarLocuriTaxa = value; }
        
        public ProgramStudiu() { }

        public ProgramStudiu(int codProgram, string denumireProgram, int numarLocuriBuget, int numarLocuriTaxa)
        {
            this.codProgram = codProgram;
            this.denumireProgram = denumireProgram;
            this.numarLocuriBuget = numarLocuriBuget;
            this.numarLocuriTaxa = numarLocuriTaxa;
        }

        public override string ToString()
        {
            return "Cod: " + codProgram + " Denumire: " + denumireProgram + " Nr. locuri la buget: " + numarLocuriBuget + " Nr. locuri la taxa: " + numarLocuriTaxa;
        }
    }
}

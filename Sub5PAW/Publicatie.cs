using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub5PAW
{
    public abstract class Publicatie
    {
        private string titlu;
        private float pret;

        public string Titlu {get=>titlu; set=>titlu=value; }
        public float Pret { get => pret; set=>pret=value; } 
        
        public abstract string genereazaReferinta();
    }
}

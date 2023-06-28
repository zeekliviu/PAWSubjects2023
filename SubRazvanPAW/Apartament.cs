using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubRazvanPAW
{
    public class Apartament
    {
        private Camera[] camere;

        public Camera[] Camere { get => camere; set => camere = value; }

        public Apartament()
        {
            
        }

        public Apartament(Camera[] camere)
        {
            this.camere = camere;
        }

        public float calculSuprafata()
        {
            float s = 0f;
            if (camere.Length != 0)
                foreach (var cam in camere)
                    s += cam.Suprafata;
            return s;
        }
    }
}

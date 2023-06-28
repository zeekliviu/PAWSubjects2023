using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubRazvanPAW
{
    public class Camera
    {
        private float latime;
        private float lungime;
        private Orientare orientare;

        public float Latime { get => latime;set => latime = value; }
        public float Lungime { get => lungime; set => lungime = value; }
        public Orientare Orientare { get => orientare; set => orientare = value; }
        public float Suprafata { get; set; }

        public Camera()
        {
            
        }

        public Camera(float latime, float lungime, Orientare orientare)
        {
            this.latime = latime;
            this.lungime = lungime;
            this.orientare = orientare;
        }
    }
    public enum Orientare
    {
        E,
        V,
        S,
        N
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_examen_PAW.Entities
{
    [Serializable]
    public class Punct
    {
        private float X, Y;

        public float x => X;
        public float y => Y;

        public Punct()
        {
            X = 0;
            Y = 0;
        }

        public Punct(float x, float y): this()
        {
            X = x;
            Y = y;
        }

       public static implicit operator float(Punct p)
        {
            return p.X;
        }

       public static float operator +(float left, Punct p)
        {
            return left + (float)p;
        }
    }
}

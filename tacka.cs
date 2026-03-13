using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026_3_10_A
{
    class tacka
    {
        public double x, y;
        public tacka(double a,double b)
        {
            x = a;
            y = b;
        }
        public tacka()
        {
            x = 0;
            y = 0;
        }
        public double d()
        {
            double dist = Math.Sqrt(x * x + y * y);
            return dist;
        }
        public double ugao()
        {
            return Math.Atan2(x, y)*180/Math.PI;
        }
    }
}

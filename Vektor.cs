using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026_3_10_A
{
    class Vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public Vektor(tacka a,tacka b)
        {
            pocetak =  a;
            kraj = b;

        }
        public Vektor(tacka a)
        {
            tacka poc = new tacka();
            pocetak = poc;
            kraj = a;
        }
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
       static public double SP(Vektor a,Vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
       static public double VP(Vektor a,Vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_3_10_a
{
    internal class vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public vektor(tacka A, tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public vektor(tacka A)
        {
            tacka poc = new tacka();
            pocetak = poc;
            kraj = A;
        }
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
        static public double SP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
        static public double VP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }
        public double duzina()
        {
            tacka finalna = this.centriraj();
            return finalna.d();
        }
        static public bool seku_se(vektor a, vektor b)
        {
            int a_b = ravan.SIS(a, b.pocetak, b.kraj);
            Console.WriteLine("a b" + a_b.ToString());
            int b_a = ravan.SIS(b, a.pocetak, a.kraj);
            Console.WriteLine("b a" + b_a.ToString());
            if (a_b * b_a != 0)
            {
                return true;
            }
            return false;
        }
    }
}
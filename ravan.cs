using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026_3_10_A
{
    class ravan
    {
        public static int SIS(Vektor AB,tacka C,tacka D)
        {
            Vektor AC = new Vektor(AB.pocetak, C);
            Vektor AD = new Vektor(AB.pocetak, D);
            double ABAC = Vektor.VP(AB, AC);
            double ABAD = Vektor.VP(AB, AD);
            if (ABAC*ABAD == 0) { return 1; }
            if (ABAC*ABAD > 0) { return 0; }
            return -1;
        }
    }
}

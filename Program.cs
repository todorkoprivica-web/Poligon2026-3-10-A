using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026_3_10_A
{
    class Program
    {
        static void Main(string[] args)
        {/*
            tacka a = new tacka(-1,-1);
            Console.WriteLine(a.ugao());
            Console.WriteLine(a.d());
            tacka A = new tacka(3, 1);
            tacka B = new tacka(-1, 3);
            tacka C = new tacka(3, 3);
            Vektor OA = new Vektor(A);
            Vektor OB = new Vektor(B);
            Vektor AC = new Vektor(A, C);
            Console.WriteLine(Vektor.SP(OA, OB));
            Console.WriteLine(Vektor.VP(OA, AC));
            */
            //tacka A = new tacka(1, 2);
           // tacka B = new tacka(3, 2);
           // tacka C = new tacka(2, 3);
            //tacka D = new tacka(2, 2);
           // Console.WriteLine("Kolko temena?");
            //int n = Convert.ToInt32(Console.ReadLine());
           // poligon prvi = new poligon(n);
           // prvi.unos();
            //prvi.stampaj();
            //prvi.snimi();
            poligon drugi = poligon.ucitaj();
            drugi.stampaj();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026_3_10_A
{
    class poligon
    {
         int br_temena;
         tacka[] teme;
       public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
            for (int i = 0; i < n; i++) {
                teme[i] = new tacka();
            }
        }
        public void unos()
        {
            for(int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Ax({0})=", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ay({0})=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                teme[i].x = x;teme[i].y = y; 
            }
        }
        public void stampaj() {
            Console.WriteLine("Poligon od " + br_temena + "tacaka");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("A({0})"+"("+teme[i].x+","+teme[i].y+")",i+1);
            }
        }

    }
}

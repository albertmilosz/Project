using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiara
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b, c;
            double odleglosc;

            Console.WriteLine("Witaj w programie do obliczania odległości punktu od prostej!\nPodaj współrzędne punktu(x):");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współrzędne punktu(y):");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Teraz będziemy potrzebować współczynników liczbowy z postaci ogólnej: Ax+By+C=0\nPodaj 'A'");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj 'B'");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj 'C'");
            c = Convert.ToInt32(Console.ReadLine());

            odleglosc = Math.Abs(a * x + b * y + c) / Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("Odległosć punktu do prostej to {0,1}", odleglosc);
           
            Console.ReadKey();
        }
    }
}

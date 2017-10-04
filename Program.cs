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
            Console.WriteLine("Witaj w programie do liczenia miejsc zerowych!");

            double a, b, c, delta, x0=0,x1=0, x2=0;

            Console.WriteLine("Podaj współczynnik 'a'");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik 'b'");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik 'c'");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("Delta jest równa:{0,2}",delta);

            if (delta > 0)
            {
                x1 = -b - Math.Sqrt(delta) / (2 * a);

                x2 = -b + Math.Sqrt(delta) / (2 * a);

                Console.WriteLine("Miejsca zerowe to: \nx1 = {0,2} \nx2 = {1,2}", x1, x2);
            }
            else if (delta == 0)
            {
                x0 = -b / (2 * a);
                Console.WriteLine("Miejce zerowe to:\nx0={0,2}", x0);
            }
            else
            {
                Console.WriteLine("Błąd");
            }
            Console.ReadKey();
        }
    }
}

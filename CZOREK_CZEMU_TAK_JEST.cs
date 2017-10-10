using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void metoda(out int x, out int y)
        {
            x = 2;
            y = 3;
            Console.WriteLine("{0,1} {1,1}", x, y);
        }

        static void Main(string[] args)
        {
            int a = 5, b = 2;
            Console.WriteLine("{0,1} {1,1}", a,b);
            metoda(out a, out b);
            Console.WriteLine("{0,1} {1,1}", a,b);

        }
    }
}

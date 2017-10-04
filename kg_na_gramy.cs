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
            string x;
            double kg, g;
            Console.WriteLine("W czym chcesz podać wartość? kg/g");
            x = Convert.ToString(Console.ReadLine());

            if (x == "kg")
            {
                Console.WriteLine("Podaj wartość w kg:");
                kg = Convert.ToDouble(Console.ReadLine());
                g = kg * 1000;
                Console.WriteLine("{0,1} kilogramów to {1,1} gramów", kg, g);
            } else if( x == "g")
            {
                Console.WriteLine("Podaj wartość w g:");
                g = Convert.ToDouble(Console.ReadLine());
                kg = g / 1000;
                Console.WriteLine("{0,1} gramów to {1,1} kilogramów", g, kg);
            } else { Console.WriteLine("błąd"); }

            Console.ReadKey();
        }
    }
}

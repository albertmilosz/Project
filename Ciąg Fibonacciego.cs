using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0;

           

            for (x = 1, y = 1;z < 1000; )
            {
                
                z = x + y;
                y = x;
                x = z;

                Console.WriteLine(z);
            }
           
        }
    }
}

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
            int y = 0,x;
            int[] a = { 10, 12, 14 };
            for (x = 0; x <= 2; x++)
            {
                y += 2 * x;
                
                
                for(int i = 0; i < a.Length; i++)
                {
                    y += 2 * a[i];
                }
                Console.WriteLine(y);
            }

            Console.WriteLine(y);
        }
    }
}

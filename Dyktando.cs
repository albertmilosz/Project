using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyktando
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] tab1 = {"górnik","lekarz" };
            string[] tab2 = {"g*rnik", "leka*"};
            string[] bledy = new string[tab2.Length];
            string slowo;
            int punkty = 0;

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("uzupełnij poprawnie luki w słowie: " + tab2[i]);
                slowo = Convert.ToString(Console.ReadLine());
                if (slowo == tab1[i])
                {
                    punkty++;
                }
                else
                {
                    bledy[i] = tab1[i];
                }
            }
            Console.WriteLine("Uzyskałeś {0,1} pkt. Gratulacje!", punkty);

            if (bledy[] = 0)
            {
                Console.WriteLine("\npoprawne odpowiedzi to: ");
                
                foreach (string i in bledy)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}

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

            string[] tab1 = { "górnik", "lekarz", "helikopter", "herbata","krowa" };
            string[] tab2 = { "g*rnik", "leka*", "*elikopter", "*erbata", "k**wa" };
            string[] bledy = new string[tab2.Length];
            string[] bledy_zapisane = new string[tab2.Length];
            string slowo,slowo_lower;
            int punkty = 0,x = 0;

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("uzupełnij poprawnie luki w słowie: " + tab2[i]);
                slowo = Convert.ToString(Console.ReadLine());
                slowo_lower = slowo.ToLower();
                if (slowo_lower == tab1[i])
                {
                    punkty++;
                }
                else
                {
                   
                    bledy_zapisane[x] = slowo;
                    bledy[x] = tab1[i];
                    x++;
                }
            }
            Console.WriteLine("\nUzyskałeś {0,1} pkt.", punkty);

            if (x > 0)
            {
                Console.WriteLine("\nIlość błędów {0,1}", x);
                Console.WriteLine("\nPopełniłeś błąd w: ");

               for ( int i = 0; i < x; i++)
                {
                    
                    Console.WriteLine("Twoja odpowiedź: {0,1} poprawna: {1,1}", bledy_zapisane[i], bledy[i]);
                }
            }
            else
            {
                
                Console.WriteLine("Udało Ci się rozwiązać dyktando bezbłędnie! Brawo!");
            }
            Console.ReadKey();

        }
    }
}
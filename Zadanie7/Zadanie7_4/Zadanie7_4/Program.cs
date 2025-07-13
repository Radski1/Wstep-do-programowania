using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_4
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {//funkcja ile cyfr
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }
            static void Main(string[]args)
            {
                Console.WriteLine("Liczba 0 ma {0} cyfre", ile_cyfr(0));
                Console.WriteLine("Liczba 1234 ma {0} cyfry", ile_cyfr(1234));
            int a;
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.Read());
            Console.WriteLine("Liczba {0} ma {1} cyfer",a,ile_cyfr(a));
            Console.ReadKey(true);
            }
            
       
    }
}

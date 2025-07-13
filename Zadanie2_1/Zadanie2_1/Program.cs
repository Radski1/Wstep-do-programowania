using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe calkowita: ");

            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia, większa od 0", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} jest ujemna, mniejsza od 0", a);
            else
                Console.WriteLine("Liczba {0} jest równa 0", a);

            Console.ReadKey(true);
        }
    }
}

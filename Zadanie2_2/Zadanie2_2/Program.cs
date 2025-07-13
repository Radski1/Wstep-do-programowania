using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj liczbe nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());

            //najmniejsza liczba
            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else 
                    Console.WriteLine("Liczba {0} jest najmniejsza", c);

            //rowna liczba
            if (a == b)
                Console.WriteLine("Liczba    {0} jest rowna liczbie {1}", a, b);
            else if (b == c)
                Console.WriteLine("Liczba {0} jest rowna liczbie {1}", b, c);
            else
                Console.WriteLine("Zadna liczba nie jest rowna");

            //najwieksza liczba
            if ((a >= b) && (a >= c))
                    Console.WriteLine("Liczba {0} jest najwieksza", a);
            else if ((b >= a) && (b >= c))
                    Console.WriteLine("Liczba {0} jest najwieksza", b);
            else 
                    Console.WriteLine("Liczba {0} jest najwieksza", c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //funkcja kwadratowa

            int a, b, c, Delta, x0 = 0,x1 = 0 ,x2 = 0 ;
            Console.WriteLine("Ten program ogarnia funkcje kwadratowa");
            Console.WriteLine("f(x)=ax^2 + bx + c");
            Console.WriteLine("Podaj wartosc wspolczynnika a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartosc wspolczynnika b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartosc wspolczynnika c:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("f(x)={0}x^2 + {1}x + {2}",a,b,c);

            Delta = (int)((Math.Pow(b, 2)) - (4 * a * c));
           
            Console.WriteLine("Delta wynosi {0}", Delta);
            Console.WriteLine();

            if (Delta > 0)
            {
                x1 = (int)((-b - (Math.Sqrt(Delta))) % (2 * a));
                x2 = (int)((-b + (Math.Sqrt(Delta))) % (2 * a));

                Console.WriteLine($"Pierwsze miejsce zerowe wynosi {x1}");
                Console.WriteLine($"Drugie miejsce zerowe wynosi {x2}");
            }

            if (Delta == 0)
            {
                x0 = (-b % (2 * a));
                Console.WriteLine("Miejsce zerowe wynosi {0}", x0);
            }

            if (Delta < 0)
            {
                Console.WriteLine("Delta jest ujemna");
            }
            Console.ReadKey();




        }
    }
}

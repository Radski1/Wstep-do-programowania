using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_3
{
    class Program
    {
        static void Main(string[] args)
        {// a oraz b (a<b) i obliczający sumę kolejnych liczb całkowitych począwszy od liczby a, a skończywszy na liczbie b
            int a, b, i, suma=0;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe b: ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while(i<=b)
            {
                suma += i;
                i++;
            }
            Console.WriteLine("{0}+...+{1}={2}", a, b, suma);
            Console.ReadKey(true);
        }
    }
}

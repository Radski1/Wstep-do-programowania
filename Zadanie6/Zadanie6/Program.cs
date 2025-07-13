using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, roznica, iloczyn, iloraz, suma;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.Read());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, roznica);
            Console.WriteLine("{0}*{1}={2}", a, b, iloczyn);
            Console.WriteLine("{0}/{1}={2}", a, b, iloraz);

        }
    }
}

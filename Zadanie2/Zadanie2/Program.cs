using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string marka;//ustawienie zmiennej
            Console.WriteLine("Podaj marke swojego samochodu");//text output
            marka = Console.ReadLine();//wpisanie zmiennej (input)
            Console.WriteLine();
            Console.ReadKey(true);//pauza
            Console.WriteLine("{0} to dobra marka", marka);//text output
            Console.WriteLine();
            Console.WriteLine("Kliknij klawisz, by kontynuować");//text output

        }
    }
}

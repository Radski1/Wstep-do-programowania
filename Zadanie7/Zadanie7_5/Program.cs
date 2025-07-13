using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_5
{
    class Program
    {
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy 12 jest 1 l.pierw.: {0}", czy_pierwsza(12));
            Console.WriteLine("Czy 13 jest 1 l.pierw.: {0}", czy_pierwsza(13));
        }
    }
}

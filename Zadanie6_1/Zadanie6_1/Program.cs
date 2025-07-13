using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program wczytuje ciag 1<=n<=1000, liczby calkowite
            int[] tab = new int[1000];//tablica roz 1000 typ int
            int i, n;//i dla petli, n dla elementow tablicy

            Console.Write("Podaj liczbe elementow (max 1000): ");
            n = Convert.ToInt32(Console.ReadLine());
                for(i=0;i<n;i++)
            {
                Console.Write("Podaj tab[{0}] ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elementy tablicy: ");
            for(i=0;i<n;i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}

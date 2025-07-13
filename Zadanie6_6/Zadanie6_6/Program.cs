using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_6
{
    class Program
    {
        static void Main(string[] args)
        {//Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach
            string[] tab = new string[] { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            foreach (string elements in tab)
                Console.Write("{0} ", elements); Console.ReadKey(true);
        }
    }
}

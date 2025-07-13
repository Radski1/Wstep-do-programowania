using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9_1
{
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba a;
            Console.Write("Podaj imie: ");
            a.imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            a.nazwisko = Console.ReadLine();
            Console.Write("Podaj rok urodzenia: ");
            a.rok_urodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} urodzil sie w roku {2}.", a.imie, a.nazwisko, a.rok_urodzenia);
            Console.ReadKey(true);
        }
    }
}

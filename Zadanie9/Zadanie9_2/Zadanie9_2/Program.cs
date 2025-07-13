using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9_2
{
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] ocena;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int ile_ucz, ile_ocen, i, j;

            Console.Write("Podaj liczbe uczniow w klasie: ");
            ile_ucz = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[ile_ucz];
            for(i=0; i<ile_ucz; i++)
            {
                Console.Write("Podaj imie ucznia {0}: ",i+1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.Write("Ile ma ocen {0} {1}? ", uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].ocena = new byte[ile_ocen];
                for(j=0; j<ile_ocen; j++)
                {
                    Console.Write("Podaj ocene numer {0}: ", j + 1);
                    uczniowie[i].ocena[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();//pusta linijka
            }
            for(i=0; i<ile_ucz; i++)
            {
                Console.Write("{0}. {1} {2}: ", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach (byte o in uczniowie[i].ocena)
                    Console.Write("{0}, ", o);
                Console.WriteLine("");//nowy wiersz
            }
            Console.ReadKey(true);
        }
    }
}

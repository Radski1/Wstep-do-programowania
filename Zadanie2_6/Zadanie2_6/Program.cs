using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //program wypisuje miesiac po jego liczbie

            int a;
            Console.WriteLine("Ten program podaje miesiac po podaniu jego numeru");
            Console.Write("Podaj numer miesiaca: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) Console.WriteLine("Styczen to {0} miesiac roku", a);
            else if (a == 2) Console.WriteLine("Luty to {0} miesiac roku", a);
            else if (a == 3) Console.WriteLine("Marzec to {0} miesiac roku", a);
            else if (a == 4) Console.WriteLine("Kwiecien to {0} miesiac roku", a);
            else if (a == 5) Console.WriteLine("Maj to {0} miesiac roku", a);
            else if (a == 6) Console.WriteLine("Czerwiec to {0} miesiac roku", a);
            else if (a == 7) Console.WriteLine("Lipiec to {0} miesiac roku", a);
            else if (a == 8) Console.WriteLine("Sierpien to {0} miesiac roku", a);
            else if (a == 9) Console.WriteLine("Wrzesien to {0} miesiac roku", a);
            else if (a == 10) Console.WriteLine("Pazdziernik to {0} miesiac roku", a);
            else if (a == 11) Console.WriteLine("Listopad to {0} miesiac roku", a);
            else if (a == 12) Console.WriteLine("Grudzien to {0} miesiac roku", a);

            else Console.WriteLine("Rok nie ma tylu miesiecy");

            Console.ReadKey();

        }
    }
}

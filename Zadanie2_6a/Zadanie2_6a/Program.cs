using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_6a
{
    class Program
    {
        static void Main(string[] args)
        {// druga wersja programu - z uzyciem funkcji switch

            int a;
            Console.Write("Podaj numer miesiaca: ");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Styczen"); break;
                case 2: Console.WriteLine("Luty"); break;
                case 3: Console.WriteLine("Marzec"); break;
                case 4: Console.WriteLine("Kwiecien"); break;
                case 5: Console.WriteLine("Maj"); break;
                case 6: Console.WriteLine("Czerwiec"); break;
                case 7: Console.WriteLine("Lipiec"); break;
                case 8: Console.WriteLine("Sierpien"); break;
                case 9: Console.WriteLine("Wrzesien"); break;
                case 10: Console.WriteLine("Pazdziernik"); break;
                case 11: Console.WriteLine("Listopad"); break;
                case 12: Console.WriteLine("Grudzien"); break;

                default: Console.WriteLine("Nie ma takiego miesiaca"); break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zmienia liczbe na slowa");
            Console.WriteLine("Zakres od 0 do 1 000 000");
            int a;
            Console.Write("Podaj liczbe: ");
            a=Convert.ToInt32(Console.ReadLine());
            if (a==1000000) Console.WriteLine("Milion");
            else if (a >= 900000) Console.WriteLine("Dziewiecset tysiecy");
            else if (a >= 800000) Console.WriteLine("Osiemset tysiecy");
            else if (a >= 700000) Console.WriteLine("Siedemset tysiecy");
            else if (a >= 600000) Console.WriteLine("Szescset tysiecy");
            else if (a >= 500000) Console.WriteLine("Piecset tysiecy");
            else if (a >= 400000) Console.WriteLine("Czterysta tysiecy");
            else if (a >= 300000) Console.WriteLine("Trzysta tysiecy");
            else if (a >= 200000) Console.WriteLine("Dwiescie tysiecy");
            else if (a >= 100000) Console.WriteLine("Sto tysiecy");

            if (a>=90000) Console.WriteLine("Dziewiedziesiat tysiecy");
            else if (a >= 80000) Console.WriteLine("Osiemdziesiat tysiecy");
            else if (a >= 70000) Console.WriteLine("Siedemdziesiat tysiecy");
            else if (a >= 60000) Console.WriteLine("Szescdziesiat tysiecy");
            else if (a >= 50000) Console.WriteLine("Piecdziesiat tysiecy");
            else if (a >= 40000) Console.WriteLine("Czterdziesci tysiecy");
            else if (a >= 30000) Console.WriteLine("Trzydziesci tysiecy");
            else if (a >= 20000) Console.WriteLine("Dwadziescia tysiecy");
            else if (a >= 10000) Console.WriteLine("Dziesiec tysiecy");
            
            if (a >= 9000) Console.WriteLine("Dziewiec tysiecy");
            else if (a >= 8000) Console.WriteLine("Osiem tysiecy");
            else if (a >= 7000) Console.WriteLine("Siedem tysiecy");
            else if (a >= 6000) Console.WriteLine("Szesc tysiecy");
            else if (a >= 5000) Console.WriteLine("Piec tysiecy");
            else if (a >= 4000) Console.WriteLine("Cztery tysiecy");
            else if (a >= 3000) Console.WriteLine("Trzy tysiecy");
            else if (a >= 2000) Console.WriteLine("Dwa tysiecy");
            else if (a >= 1000) Console.WriteLine("Jeden tysiac");

            if (a >= 900) Console.WriteLine("Osiemdziesiat tysiecy");
            else if (a >= 800) Console.WriteLine("Osiemset");
            else if (a >= 700) Console.WriteLine("Siedemset");
            else if (a >= 600) Console.WriteLine("Szescset");
            else if (a >= 500) Console.WriteLine("Piecset");
            else if (a >= 400) Console.WriteLine("Czterysta");
            else if (a >= 300) Console.WriteLine("Trzysta");
            else if (a >= 200) Console.WriteLine("Dwiescie");
            else if (a >= 100) Console.WriteLine("Sto");

            if (a >= 90) Console.WriteLine("Dziewiecdziesiat");
            else if (a >= 80) Console.WriteLine("Osiemdziesiat");
            else if (a >= 70) Console.WriteLine("Siedemdziesiat");
            else if (a >= 60) Console.WriteLine("Szescdziesiat");
            else if (a >= 50) Console.WriteLine("Piecdziesiat");
            else if (a >= 40) Console.WriteLine("Czterdziesci");
            else if (a >= 30) Console.WriteLine("Trzydziesci");
            else if (a >= 20) Console.WriteLine("Dwadziescia");
            else if (a >= 10) Console.WriteLine("Dziesiec");

            switch (a)
            {
                case 1: Console.Write("Jeden");
                case 2: Console.Write("Dwa");

                default: Console.Write();
            }




            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //program sprawdza czy trojkat istnieje
            Console.WriteLine("Program sprawdza czy trojkat o danych wymiarach istnieje");
            int a, b,c;
            Console.Write("Podaj dlugosc boku a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj dlugosc boku b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj dlugosc boku c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b + c) || (b > a + c) || (c > a + b)) Console.WriteLine("Taki nie trojkat istnieje");
            
            else if ((a == b) && (b == c)) Console.WriteLine("Taki trojkat istnieje");
            else Console.WriteLine("Taki trojkat istnieje");

            Console.ReadKey();
        }
    }
}

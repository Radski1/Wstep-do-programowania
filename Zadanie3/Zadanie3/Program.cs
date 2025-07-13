using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; //ustawienie zmiennej a
            Console.WriteLine("Program do liczenia szescianu podanej liczby");//text output
            Console.WriteLine("Podaj liczbe");//text output
            Console.Write("a=");//text output
            a = Convert.ToInt32(Console.ReadLine());//konwersja zmiennej na liczbe (system liczbowy int32)
            Console.WriteLine("a^3={0}",a*a*a);//text output, równanie ze zmienną
            Console.ReadKey(true);//pauza

        }
    }
}

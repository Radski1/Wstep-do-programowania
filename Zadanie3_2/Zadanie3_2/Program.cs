using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do
            //potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024
            //uzyj petli for

            int a, wynik = 1, n;
            Console.Write("Podaj liczbe naturalna n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)// a=1 -> od czego zaczynamy (zmienna podana), a mniejsze rowne n, a++ -> zwiekszamy co kazda
                wynik *= 2;
            Console.WriteLine("2^{0}={1}", n, wynik);
            Console.ReadKey(true);



        }
    }
}

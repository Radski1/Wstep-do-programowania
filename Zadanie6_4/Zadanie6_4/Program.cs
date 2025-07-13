using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_4
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie sumę wczytanych liczb
            int[] tab = new int[1000];
            int i, n, suma;
            Console.Write("Podaj liczbe elementow tablicy: ");
            n = Convert.ToInt32(Console.ReadLine());//ustalenie ilosci elementow w tablicy
            for(i=0;i<n;i++)// petla wartosci elementow tablicy
            { Console.Write("Podaj Tab[{0}]: ", i); tab[i] = Convert.ToInt32(Console.ReadLine()); }
            //liczenie
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i];
            Console.WriteLine("Suma elementow tablicy wynosi {0}", suma);Console.ReadKey(true);
        }
    }
}

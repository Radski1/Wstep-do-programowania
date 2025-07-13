using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_3
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
         // wypisujący posortowane liczby na ekranie
            int[] tab = new int[1000];//tablica do 1000
            int i, j,n,tmp;//i,j - liczniki petli, n-ilosc elementow, tmp-zmienna pomocnicza
            Console.Write("Podaj ilosc elementow tablicy (max 1000): ");
            n = Convert.ToInt32(Console.ReadLine());//tutaj ilosc elementow 
            for(i=0;i<n;i++)//petla jakie elementy w tablicy
            {
                Console.Write("Podaj Tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)//sortowanie
                for (j = i + 1; j < n; j++)
                    if (tab[i] > tab[j])//zamiana kolejnosci tablic
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp;  }
            //wyswietlanie elementow
            Console.Write("Elementy tablicy: ");
            for(i=0;i<n;i++)
            { Console.Write("{0} ", tab[i]); }
            Console.ReadKey(true);
        }
    }
}

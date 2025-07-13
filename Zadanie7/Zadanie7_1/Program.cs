using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_1
{
    class Program
    {
        static int suma(int a, int b)
        {//Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma
            return a + b;
        }//test
        static void Main(string[]args)
        { Console.WriteLine("2+5={0}", suma(2, 5));
            Console.ReadKey(true);
        }
    }
}

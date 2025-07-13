using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7_2
{
    class Program
    {//Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
       // zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.
        static double max(double x, double y)
        {if (x > y) return x;
            else return y;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Max z 2 i 3 to {0}", max(2, 3));
            Console.WriteLine("Max z 5 i 4 to {0}", max(5, 4));
            Console.WriteLine("Max z 6 i 6 to {0}", max(6, 6));
            Console.ReadKey(true);
        }
    }
}

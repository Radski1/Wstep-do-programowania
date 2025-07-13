using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //program czy rok jest przestepny
            int rok;
            Console.WriteLine("Ten program powie ci czy rok jest przestepny");
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
                Console.WriteLine("Rok {0} jest przestepny", rok);
            else
                Console.WriteLine("Rok {0} nie jest przestepny", rok);

            Console.ReadKey();
        }
    }
}

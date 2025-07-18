using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WazRzeczny
{
    internal class Ustawienia
    {
        public static int Szerokosc { get; set; }
        public static int Wysokosc { get; set; }
        public static string Kierunki { get; set; }

        public Ustawienia()
        {
            Szerokosc = 16;
            Wysokosc = 16;
            Kierunki = "Lewo";
        }
    }
}

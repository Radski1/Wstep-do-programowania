using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WazRzeczny
{
    public partial class Form1 : Form
    {
        private List<Kolko> Waz = new List<Kolko>();
        private Kolko jablka = new Kolko();

        int maxSzerokosc;
        int maxWysokosc;
        int wynik;
        int nwynik; 

        Random losowo=new Random();
        bool idzLewo, idzPrawo, idzGora, idzDol;
        public Form1()
        {
            InitializeComponent();
            new Ustawienia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kd(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Ustawienia.Kierunki != "Prawo")
            {
                idzLewo = true;
            }
            if (e.KeyCode == Keys.Right && Ustawienia.Kierunki != "Lewo")
            {
                idzPrawo = true;
            }
            if (e.KeyCode == Keys.Down && Ustawienia.Kierunki != "Gora")
            {
                idzDol = true;
            }
            if (e.KeyCode == Keys.Up && Ustawienia.Kierunki != "Dol")
            {
                idzGora = true;
            }

        }

        private void Ku(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                idzLewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                idzPrawo = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                idzDol = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                idzGora = false;
            }
        }

        
        private void ZmienObrazek(object sender, PaintEventArgs e)
        {
            Graphics ramka = e.Graphics;
            Brush WazKolor;
            for (int i = 0; i < Waz.Count; i++)
            {
                if(i== 0)
                {
                    WazKolor = Brushes.DarkGreen;
                }
                else
                {
                    WazKolor= Brushes.LightGreen;
                }

                ramka.FillEllipse(WazKolor,new Rectangle
                    (Waz[i].x*Ustawienia.Szerokosc, Waz[i].y * Ustawienia.Wysokosc,Ustawienia.Szerokosc,Ustawienia.Wysokosc));

            }
            ramka.FillEllipse(Brushes.DarkRed, new Rectangle
                    (jablka.x * Ustawienia.Szerokosc, jablka.y * Ustawienia.Wysokosc, Ustawienia.Szerokosc, Ustawienia.Wysokosc));


        }

        private void CzasGry(object sender, EventArgs e)
        {
            if (idzLewo)
            { Ustawienia.Kierunki = "Lewo"; }
            if (idzPrawo)
            { Ustawienia.Kierunki = "Prawo"; }
            if (idzGora)
            { Ustawienia.Kierunki = "Gora"; }
            if (idzDol)
            { Ustawienia.Kierunki = "Dol"; }

            for (int i = Waz.Count - 1; i >= 0; i--)
            {
                if(i==0)
                {
                    switch(Ustawienia.Kierunki)
                    {
                        case "Lewo":
                            Waz[i].x--;
                            break;
                        case "Prawo":
                            Waz[i].x++;
                            break;
                        case "Gora":
                            Waz[i].y--;
                            break;
                        case "Dol":
                            Waz[i].y++;
                            break;
                    }
                    if (Waz[i].x < 0) 
                    {
                        Waz[i].x = maxSzerokosc;
                    }
                    if (Waz[i].x > maxSzerokosc)
                    {
                        Waz[i].x =0;
                    }
                    if (Waz[i].y < 0)
                    {
                        Waz[i].y = maxWysokosc;
                    }
                    if (Waz[i].y > maxWysokosc)
                    {
                        Waz[i].y = 0;
                    }

                    if (Waz[i].x == jablka.x && Waz[i].y==jablka.y)
                    {
                        JedzJablka();
                    }
                    for (int j=1;j< Waz.Count;j++)
                    {
                        if (Waz[i].x == Waz[j].x&& Waz[i].y == Waz[j].y)
                        {
                            Koniecgry();
                        }
                    }

                }
                else
                {
                    Waz[i].x=Waz[i-1].x;
                    Waz[i].y = Waz[i - 1].y;
                }    
            }
            Ramka.Invalidate();
        }

        private void StartGry(object sender, EventArgs e)
        {
            Restart();
            NwynikLabel.ForeColor = Color.Black;
        }

        

        private void Restart()
        {
            maxSzerokosc = Ramka.Width / Ustawienia.Szerokosc - 1;
            maxWysokosc = Ramka.Height / Ustawienia.Wysokosc - 1;

            Waz.Clear();
            GuzikStart.Enabled = false;
            wynik = 0;
            WynikLabel.Text = "Wynik: " + wynik;

            Kolko glowa = new Kolko { x = 10, y = 5 };
            Waz.Add(glowa);

            for (int i = 0; i < 10; i++)
            {
                Kolko cialo = new Kolko();
                Waz.Add(cialo);
            }
            jablka = new Kolko {x=losowo.Next(2, maxSzerokosc), y = losowo.Next(2, maxWysokosc) };
            czas.Start();

            }
        
        private void JedzJablka()
        {
            wynik += 1;
            WynikLabel.Text = "Wynik: " + wynik;
            Kolko cialo = new Kolko
            {
                x = Waz[Waz.Count - 1].x,
                y = Waz[Waz.Count - 1].y
            };
            Waz.Add(cialo);
            jablka = new Kolko { x = losowo.Next(2, maxSzerokosc), y = losowo.Next(2, maxWysokosc) };
        }
        private void Koniecgry()
        {
            czas.Stop();
            GuzikStart.Enabled = true;

            if (wynik > nwynik)
            {
                nwynik = wynik;
                NwynikLabel.Text="Najwyzszy wynik: "+nwynik;
                NwynikLabel.ForeColor = Color.Magenta;
                
            }
        }
        

    }
}

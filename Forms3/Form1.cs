using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Forms3
{
    public partial class pozostalyCzas : Form
    {
        Random randomizer = new Random();
        int zmienna1;
        int zmienna2;
        int zmienna3;
        int zmienna4;
        int zmienna5;
        int zmienna6;
        int zmienna7;
        int zmienna8;
        int pozczas;
        
        public pozostalyCzas()
        {
            InitializeComponent();
        }

        public void StartQuizu()
        {
            zmienna1 = randomizer.Next(51);
            zmienna2 = randomizer.Next(51);
            lewaLiczbaLbl.Text = zmienna1.ToString();
            prawaLiczbaLbl.Text = zmienna2.ToString();
            wynik1.Value = 0;

            zmienna3 = randomizer.Next(1, 101);
            zmienna4 = randomizer.Next(1, zmienna3);
            minus1.Text = zmienna3.ToString();
            minus2.Text = zmienna4.ToString();
            wynik2.Value = 0;

            zmienna5 = randomizer.Next(2, 11);
            zmienna6 = randomizer.Next(2, 11);
            razy1.Text = zmienna5.ToString();
            razy2.Text = zmienna6.ToString();
            wynik3.Value = 0;

            zmienna8 = randomizer.Next(2, 11);
            int zmienna9 = randomizer.Next(2, 11);
            zmienna7 = zmienna8 * zmienna9;
            dzielenie1.Text = zmienna7.ToString();
            dzielenie2.Text = zmienna8.ToString();
            wynik4.Value = 0;

            pozczas = 30;
            czasLbl.Text = "30 sekund";
            stoper.Start();
        }

        private void czasLbl_Click(object sender, EventArgs e)
        {

        }

        private void pozostalyCzas_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            StartQuizu();
            button1.Enabled = false;
        }

        private bool Odpowiedzi()
        {
            if ((zmienna1 + zmienna2 == wynik1.Value)
                &&(zmienna3 - zmienna4 == wynik2.Value)
                &&(zmienna5 * zmienna6 == wynik3.Value)
                &&(zmienna7 / zmienna8 == wynik4.Value))
                return true;
            else
                return false;
        }

        private void pzczasLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Odpowiedzi())
            {
                stoper.Stop();
                MessageBox.Show("Wszystkie odpowiedzi poprawne!",
                                "Gratulacje!");
                button1.Enabled = true;
            }
            else if (pozczas > 0)
            {
                pozczas = pozczas - 1;
                czasLbl.Text = pozczas + " sekund";
            }
            else
            {
                stoper.Stop();
                czasLbl.Text = "Koniec czasu!";
                MessageBox.Show("Nie ukonczyles w pore.", "Trudno!");
                wynik1.Value = zmienna1 + zmienna2;
                wynik2.Value = zmienna3 - zmienna4;
                wynik3.Value = zmienna5 * zmienna6;
                wynik4.Value = zmienna7 / zmienna8;
                button1.Enabled = true;
            }
        }
    }
}

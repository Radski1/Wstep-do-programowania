using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms4
{
    public partial class Gra : Form
    {
        Random random = new Random();
        List<string> ikony = new List<string>()
        {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };

        Label Clicked1 = null;
        Label Clicked2 = null;

        public Gra()
        {
            InitializeComponent();
            PrzypiszIkonyDoKwadratow();
        }

        private void Gra_Load(object sender, EventArgs e)
        {

        }
        private void PrzypiszIkonyDoKwadratow()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label ikonyLabel = control as Label;
                if (ikonyLabel != null)
                {
                    int losowaLiczba = random.Next(ikony.Count);
                    ikonyLabel.Text = ikony[losowaLiczba];
                    ikonyLabel.ForeColor = ikonyLabel.BackColor;
                    ikony.RemoveAt(losowaLiczba);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                clickedLabel.ForeColor = Color.Black;
            }

            if (Clicked1 == null)
            {
                Clicked1 = clickedLabel;
                Clicked1.ForeColor = Color.Black;
                return;
            }

            Clicked2 = clickedLabel;
            Clicked2.ForeColor = Color.Black;
            timer1.Start();
            CzyWygrana();
            if (Clicked1.Text == Clicked2.Text)
            {
                Clicked1 = null;
                Clicked2 = null;
                return;
            }

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Clicked1.ForeColor = Clicked1.BackColor;
            Clicked2.ForeColor = Clicked2.BackColor;
            Clicked1 = null;
            Clicked2 = null;
        }

        private void CzyWygrana()
            {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label ikonyLabel = control as Label;
                if(ikonyLabel != null)
                {
                    if (ikonyLabel.ForeColor == ikonyLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Udalo ci sie dopasowac wszystkie ikony!", "Gratulacje!");
            Close();

            }

    }
}

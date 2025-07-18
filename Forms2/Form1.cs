using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rozciagnijBtn.Checked)
                zdjecieBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                zdjecieBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (wybierzKolor.ShowDialog() == DialogResult.OK)
                zdjecieBox.BackColor = wybierzKolor.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (wybierzPlik.ShowDialog() == DialogResult.OK)
            {
                zdjecieBox.Load(wybierzPlik.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zdjecieBox.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

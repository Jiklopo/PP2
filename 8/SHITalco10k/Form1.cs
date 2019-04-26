using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHITalco10k
{
    public partial class Form1 : Form
    {
        public static SverhRazum AI = new SverhRazum();
        public Form1()
        {
            InitializeComponent();
        }

        private void Cifra(object sender, EventArgs e)
        {
            Telik.Text = AI.Ciferka(((Button)sender).Text, Telik.Text);
        }

        private void ZnakNazhal(object sender, EventArgs e)
        {
            Telik.Text = AI.ZnakZnachit(((Button)sender).Text, Telik.Text);
        }

        private void Ravno(object sender, EventArgs e)
        {
            Telik.Text = AI.Uravnyat(Telik.Text);
        }

        private void Tochka(object sender, EventArgs e)
        {
            Telik.Text = AI.SlozhnoeChislo(Telik.Text);
        }

        private void Clean(object sender, EventArgs e)
        {
            Telik.Clear();
            AI.Seychas = SverhRazum.ChtoTvoritsya.Nichego;
            AI.Drob = false;
        }

        private void CleanOdnoTolko(object sender, EventArgs e)
        {
            string s = Telik.Text;
            Telik.Text = s.Remove(s.Length - 1);
        }

        private void NazhalKnopku(object sender, KeyEventArgs e)
        {
            Keys a = e.KeyCode;
            if (a == Keys.D1 || a == Keys.NumPad1)
                button1.PerformClick();
            else if (a == Keys.D2 || a == Keys.NumPad2)
                button2.PerformClick();
            else if (a == Keys.D3 || a == Keys.NumPad3)
                button3.PerformClick();
            else if (a == Keys.D4 || a == Keys.NumPad4)
                button4.PerformClick();
            else if (a == Keys.D5 || a == Keys.NumPad5)
                button5.PerformClick();
            else if (a == Keys.D6 || a == Keys.NumPad6)
                button6.PerformClick();
            else if (a == Keys.D7 || a == Keys.NumPad7)
                button7.PerformClick();
            else if (a == Keys.D8 || a == Keys.NumPad8)
                button8.PerformClick();
            else if (a == Keys.D9 || a == Keys.NumPad9)
                button9.PerformClick();
            else if (a == Keys.D0 || a == Keys.NumPad0)
                button0.PerformClick();
            else if (a == Keys.D0 || a == Keys.NumPad0)
                button0.PerformClick();
            else if (a == Keys.Add)
                Plus.PerformClick();
            else if (a == Keys.Subtract)
                Minus.PerformClick();
            else if (a == Keys.Multiply)
                Umnojenie.PerformClick();
            else if (a == Keys.Divide)
                Delenie.PerformClick();
            else if (a == Keys.End)
                Ravenstvo.PerformClick();
        }
    }
}

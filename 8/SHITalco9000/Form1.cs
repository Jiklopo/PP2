using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHITalco9000
{
    public partial class Form1 : Form
    {
        public static double a, b = 0;
        static CheDelat ShasCheDelat = new CheDelat();
        static ChtoProishodit ChtoProishodit = new ChtoProishodit();
        public enum CheDelat
        {
            Plus,
            Minus,
            Delit,
            Umnoj
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Cifra(object sender, EventArgs e)
        {
            if(ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Nichego || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Slomali || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Poshitali)
            {
                textBox1.Clear();
                ChtoProishodit.chtodelaem = ChtoProishodit.ChtoDelaem.Vvodim_A;
            }
            else if(ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.ChtoDelaem_S_A)
            {
                ChtoProishodit.chtodelaem = ChtoProishodit.ChtoDelaem.Vvodim_B;
            }
            if(ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_A || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_B)
            {
                Button but = (Button)sender;
                textBox1.Text += but.Text;
            }
        }

        private void ZnakNazhal(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_A || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_B || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.ChtoDelaem_S_A || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Poshitali)
            {
                if(ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_A || ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Poshitali)
                    a = double.Parse(textBox1.Text);
                if (but.Text == "+")
                    ShasCheDelat = CheDelat.Plus;
                else if (but.Text == "-")
                    ShasCheDelat = CheDelat.Minus;
                else if (but.Text == "x")
                    ShasCheDelat = CheDelat.Umnoj;
                else if (but.Text == ":")
                    ShasCheDelat = CheDelat.Delit;
                if(ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_B)
                {
                    b = Double.Parse(textBox1.Text);
                    textBox1.Text = Skolko(a, b).ToString();
                }
                textBox1.Clear();
                ChtoProishodit.chtodelaem = ChtoProishodit.ChtoDelaem.ChtoDelaem_S_A;
            }
            else
            {
                ChtoProishodit.chtodelaem = ChtoProishodit.ChtoDelaem.Slomali;
                textBox1.Text = "Snachala vvedi chislo";
            }
        }

        private void Ravno(object sender, EventArgs e)
        {
            if (ChtoProishodit.chtodelaem == ChtoProishodit.ChtoDelaem.Vvodim_B)
            {
                b = Double.Parse(textBox1.Text);                
                textBox1.Text = Skolko(a, b).ToString();
                ChtoProishodit.chtodelaem = ChtoProishodit.ChtoDelaem.Poshitali;
            }
        }

        private double Skolko(double a, double b)
        {
            double result = 0;
            switch (ShasCheDelat)
            {
                case CheDelat.Plus:
                    result = a + b;
                    break;
                case CheDelat.Minus:
                    result = a - b;
                    break;
                case CheDelat.Delit:
                    result = a / b;
                    break;
                case CheDelat.Umnoj:
                    result = a * b;
                    break;
            }
            return result;
        }
    }

}

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
        public static bool IsDrob = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Cifra(object sender, EventArgs e)
        {
            if(AI.Seychas == SverhRazum.ChtoTvoritsya.Nichego || AI.Seychas == SverhRazum.ChtoTvoritsya.Poshitali || AI.Seychas == SverhRazum.ChtoTvoritsya.Sdoh)
            {
                if(!IsDrob)
                    Telik.Clear();
                AI.Seychas = SverhRazum.ChtoTvoritsya.A;
            }
            else if (AI.Seychas == SverhRazum.ChtoTvoritsya.Znak)
            {
                Telik.Clear();
                AI.Seychas = SverhRazum.ChtoTvoritsya.B;
            }
            Telik.Text += ((Button)sender).Text;
        }

        private void ZnakNazhal(object sender, EventArgs e)
        {
            if (AI.Seychas == SverhRazum.ChtoTvoritsya.A || AI.Seychas == SverhRazum.ChtoTvoritsya.Poshitali)
            {
                AI.Uznak(((Button)sender).Text);
                AI.A = double.Parse(Telik.Text);
                IsDrob = false;
                AI.Seychas = SverhRazum.ChtoTvoritsya.Znak;
                Telik.Clear();
            }
            else if(AI.Seychas == SverhRazum.ChtoTvoritsya.B)
            {
                IsDrob = false;
                AI.B = double.Parse(Telik.Text);
                Telik.Text = AI.Shitalco();
                AI.Uznak(((Button)sender).Text);
                AI.A = double.Parse(Telik.Text);
                AI.Seychas = SverhRazum.ChtoTvoritsya.Znak;
            }
            else if (AI.Seychas == SverhRazum.ChtoTvoritsya.Znak)
            {
                AI.Uznak(((Button)sender).Text);
            }
        }

        private void Ravno(object sender, EventArgs e)
        {
            if(AI.Seychas == SverhRazum.ChtoTvoritsya.B)
            {
                AI.B = double.Parse(Telik.Text);
                Telik.Text = AI.Shitalco();
                AI.Seychas = SverhRazum.ChtoTvoritsya.Poshitali;
            }
            else if(AI.Seychas == SverhRazum.ChtoTvoritsya.Poshitali)
            {
                AI.A = double.Parse(Telik.Text);
                Telik.Text = AI.Shitalco();
            }
        }

        private void Tochka(object sender, EventArgs e)
        {
            if (!IsDrob)
            {
                if(AI.Seychas == SverhRazum.ChtoTvoritsya.Nichego)
                {
                    Telik.Text = "0";
                }
                else if(AI.Seychas == SverhRazum.ChtoTvoritsya.Znak)
                {
                    Telik.Text = "0";
                    AI.Seychas = SverhRazum.ChtoTvoritsya.B;
                }
                Telik.Text += ",";
                IsDrob = true;
            }
        }

        private void Clean(object sender, EventArgs e)
        {
            Telik.Clear();
            AI.Seychas = SverhRazum.ChtoTvoritsya.Nichego;
            IsDrob = false;
        }
    }

}

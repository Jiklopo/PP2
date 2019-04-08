using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_1._0
{
    public partial class Form1 : Form
    {
        public static bool a = false;
        PaintMaster Lexa = new PaintMaster();
        public Form1()
        {
            InitializeComponent();
        }

        private void Cvetik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Lexa.Crasit_V = b.BackColor;
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            a = true;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (a)
            {
                Paint.Image = Lexa.Risuet(Paint, e.X, e.Y);
            }
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            a = false;
        }

        private void Razmer(object sender, EventArgs e)
        {
            Lexa.Razmer = int.Parse(Izmer.Value.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cvetochnik.ShowDialog();
            Lexa.Crasit_V = Cvetochnik.Color;
        }
        private void Razrabotka(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция еще в разработке.\n Спасибо, что вы с нами!");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otkryvalka.ShowDialog();
            Paint.ImageLocation = Otkryvalka.FileName;
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paint.Image = Paint.InitialImage;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sohranyalka.ShowDialog();
            Paint.Image.Save(Sohranyalka.FileName);
        }
    }
}

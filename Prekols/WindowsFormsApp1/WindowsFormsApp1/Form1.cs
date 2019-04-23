using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public double v, t;
        Rectangle r;
        Point a, b;
        Graphics g;
        Pen p = new Pen(Color.Red, 2);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            a = e.Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g.DrawEllipse(p, r);
            r.X = (int)(20 + v * t);
            t++;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            b = e.Location;
            v = Math.Sqrt(((b.X - a.X) * (b.X - a.X)) + ((b.Y - a.Y) * (b.Y - a.Y)));
            r = new Rectangle(20, 20, 50, 50);
            timer1.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoditBrodit
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static Pen p;
        public static Random rs = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            p = new Pen(Color.Green, 30);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Color c = Color.Tomato;
            int width, height;
            double s1, s2;
            s1 = 0;
            s2 = 30;
            width = pictureBox1.Width-100;
            height = pictureBox1.Height - 100;
            Point a = new Point(10, 10);
            Rectangle r = new Rectangle(a.X, a.Y, width, height);
            while (true)
            {
                g.Clear(Color.White);
                g.DrawArc(p, r, (float)s1, (float)s2);
                Thread.Sleep(120);
                //a.X += 10;
                s2 += 10;
                s1 += 10;
                if (s2 > 360)
                {
                    s1 += s2;
                    s2 = 20;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                p.Color = Color.FromArgb(rs.Next(256), rs.Next(256), rs.Next(256));

        }
    }
}

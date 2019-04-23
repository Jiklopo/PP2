using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dozhdiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = button1.Location.Y + 10;
            label1.Text = y.ToString();
            button1.Location = new Point(button1.Location.X, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
           if (Collision(button1, pictureBox1))
            {
                button1.Location = new Point(20, 20);
            }
        }

        private bool Collision(Button b, PictureBox p)
        {
            int a = p.Location.Y - b.Location.Y + b.Height;
            if (a <=10 && a>0 )
            {
                if(b.Location.X == p.Location.X)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

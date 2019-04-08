using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_0._5
{
    public partial class Form1 : Form
    {
        public static bool a = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            a = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (a)
            {
                Bitmap B = new Bitmap(pictureBox1.Image);
                B.SetPixel(e.Location.X, e.Location.Y, Color.Aqua);
                pictureBox1.Image = B;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            a = false;
        }
    }
}

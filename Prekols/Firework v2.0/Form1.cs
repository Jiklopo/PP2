using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firework_v2._0
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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sender.ToString();
            SuperMega();
        }

        public void SuperMega()
        {
            Bitmap FireWork = new Bitmap(pictureBox1.Image);
            int height = pictureBox1.Image.Height - 1;
            int width = pictureBox1.Image.Width - 1;
            for (int i = height / 2; i < height; i++)
            {
                pictureBox1.Image = FireWork;
                FireWork.SetPixel(width / 2, i, Color.Cyan);
                FireWork.SetPixel(width / 2 + 1, i, Color.Cyan);
                FireWork.SetPixel(width / 2 - 1, i, Color.Cyan);
                //Thread.Sleep(50);
            }
        }
    }
}

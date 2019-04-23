using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_1._0
{
    class PaintMaster
    {
        public Color Crasit_V;
        public int Razmer;
        public MouseEventArgs a, b;
        public PaintMaster()
        {
            Crasit_V = Color.Black;
            Razmer = 5;
        }
        public Bitmap Karandash(PictureBox Holst, int x, int y)
        {
            Bitmap b = new Bitmap(Holst.Image);
            for(int i=0; i<=Razmer; i++)
            {
                for(int j=0; j<=Razmer; j++)
                {
                    try { b.SetPixel(x + i, y + j, Crasit_V); }
                    catch { }
                }
            }
            return b;
        }
        public Bitmap Liniya(PictureBox Holst)
        {
            float x1, x2, y1, y2, dx, dy;
            Bitmap baaa = new Bitmap(Holst.Image);
            x1 = a.X;
            x2 = b.X;
            y1 = a.Y;
            y2 = b.Y;
            dx = x2 - x1;
            dy = y2 - y1;
            for (float i = x1; i <= x2; i+=dx)
            {
                for (float j = y1; j <= y2; j+=dy)
                {
                    try {baaa.SetPixel((int) x1 + (int)i,(int)y1 + (int)j, Crasit_V); }
                    catch { }
                }
            }
            return baaa;
        }
    }
}

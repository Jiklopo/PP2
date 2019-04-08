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
        public PaintMaster()
        {
            Crasit_V = Color.Black;
            Razmer = 5;
        }
        public Bitmap Risuet(PictureBox Holst, int x, int y)
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
    }
}

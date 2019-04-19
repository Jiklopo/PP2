using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Paint_2._0
{
    public class Secretar
    {
        public Color[] VybCvet;
        public int KakoiNomer;
        public Secretar()
        {
            KakoiNomer = 0;
            VybCvet = new Color[4];
        }


        public void Sled()
        {
            KakoiNomer++;
            if (KakoiNomer > 3) KakoiNomer = 0;
        }
        public void Pokraska(Color cvet)
        {
            VybCvet[KakoiNomer] = cvet;
        }


        public List<Point> Zvezda4(Point a, Point b)
        {
            List<Point> list = new List<Point>();
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list.Add(new Point(a.X + width/2, a.Y));
            list.Add(new Point(a.X +(width/5)*3 ,a.Y + (height/5)*2));
            list.Add(new Point(b.X, a.Y + height/2));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X + width/2, b.Y));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X, a.Y + height / 2));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 2));
            return list;
        }

        public List<Point> Zvezda5(Point a, Point b)
        {
            List<Point> list = new List<Point>();
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list.Add(new Point(a.X + width / 2, a.Y));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 2));
            list.Add(new Point(b.X, a.Y + (height / 5)*2));
            list.Add(new Point(a.X + (width / 3) * 2, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X + (width / 5) * 4, b.Y));
            list.Add(new Point(a.X + width / 2, a.Y + (height / 5) * 4));
            list.Add(new Point(a.X + width / 5, b.Y));
            list.Add(new Point(a.X + width / 3, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X, a.Y + (height / 5) * 2));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 2));
            return list;
        }
        
    }
}

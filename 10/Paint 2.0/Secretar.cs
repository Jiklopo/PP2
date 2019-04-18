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
        public Form1.Tool KakoiInstrum(string name)
        {
            Form1.Tool Instrument;
            switch (name)
            {
                case "Pencil":
                    Instrument = Form1.Tool.Pencil;
                    break;
                case "Oshirgish":
                    Instrument = Form1.Tool.Oshirgish;
                    break;
                case "Line":
                    Instrument = Form1.Tool.Line;
                    break;
                case "Curve":
                    Instrument = Form1.Tool.Curve;
                    break;
                case "Ellipse":
                    Instrument = Form1.Tool.Ellipse;
                    break;
                case "FillEllipse":
                    Instrument = Form1.Tool.FillEllipse;
                    break;
                case "Rect":
                    Instrument = Form1.Tool.Rect;
                    break;
                case "FillRect":
                    Instrument = Form1.Tool.FillRect;
                    break;
                default:
                    Instrument = Form1.Tool.Line;
                    break;
            }
            return Instrument;
        }

        public List<Point> Zvezda(Point a, Point b)
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
        public List<Point> Zvezda2(Point a, Point b)
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
        public Rectangle Calculator9000(Point a, Point b)
        {
            int x1, y1, x2, y2;
            if(a.X > b.X)
            {
                x1 = b.X;
                x2 = a.X;
            }
            else
            {
                x1 = a.X;
                x2 = b.X;
            }
            if(a.Y > b.Y)
            {
                y1 = b.Y;
                y2 = a.Y;
            }
            else
            {
                y1 = a.Y;
                y2 = b.Y;
            }
            int width = x2 - x1;
            int height = y2 - y1;
            return new Rectangle(x1, y1, width, height);
        }
    }
}

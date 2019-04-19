using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_2._0
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        public static Bitmap bitmap;
        public static Pen pen, oshirgish;
        public Rectangle r;
        public Secretar Vasek;
        public Point a, b;
        public List<Point> CurvaPoints;
        public Tool Instrument;
        public CurvaState curvastate;
        public enum Tool
        {
            Pencil,
            Oshirgish,
            Line,
            Curve,
            Ellipse,
            FillEllipse,
            Rect,
            FillRect,
            Star5,
            Star4
        }
        public enum CurvaState
        {
            NoCurva,
            Line,
            _1,
            _2
        }

        public Tool KakoiInstrum(string name)
        {
            Tool Instrument;
            switch (name)
            {
                case "Pencil":
                    Instrument = Tool.Pencil;
                    break;
                case "Oshirgish":
                    Instrument = Tool.Oshirgish;
                    break;
                case "Line":
                    Instrument = Tool.Line;
                    break;
                case "Curve":
                    Instrument = Tool.Curve;
                    break;
                case "Ellipse":
                    Instrument = Tool.Ellipse;
                    break;
                case "FillEllipse":
                    Instrument = Tool.FillEllipse;
                    break;
                case "Rect":
                    Instrument = Tool.Rect;
                    break;
                case "FillRect":
                    Instrument = Tool.FillRect;
                    break;
                case "Star5":
                    Instrument = Tool.Star5;
                    break;
                case "Star4":
                    Instrument = Tool.Star4;
                    break;
                default:
                    Instrument = Tool.Line;
                    break;
            }
            return Instrument;
        }


        public Rectangle Rectangulator(Point a, Point b)
        {
            int x1, y1, x2, y2;
            x1 = Math.Min(a.X, b.X);
            x2 = Math.Max(a.X, b.X);
            y1 = Math.Min(a.Y, b.Y);
            y2 = Math.Max(a.Y, b.Y);
            int width = x2 - x1;
            int height = y2 - y1;
            return new Rectangle(x1, y1, width, height);
        }


        public Point[] Zvezda4(Point a, Point b)
        {
            List<Point> list = new List<Point>();
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list.Add(new Point(a.X + width / 2, a.Y));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 2));
            list.Add(new Point(b.X, a.Y + height / 2));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X + width / 2, b.Y));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X, a.Y + height / 2));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 2));
            return list.ToArray();
        }


        public Point[] Zvezda5(Point a, Point b)
        {
            List<Point> list = new List<Point>();
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list.Add(new Point(a.X + width / 2, a.Y));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 2));
            list.Add(new Point(b.X, a.Y + (height / 5) * 2));
            list.Add(new Point(a.X + (width / 3) * 2, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X + (width / 5) * 4, b.Y));
            list.Add(new Point(a.X + width / 2, a.Y + (height / 5) * 4));
            list.Add(new Point(a.X + width / 5, b.Y));
            list.Add(new Point(a.X + width / 3, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X, a.Y + (height / 5) * 2));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 2));
            return list.ToArray();
        }
    }
}

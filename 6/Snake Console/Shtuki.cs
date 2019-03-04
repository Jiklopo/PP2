using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Snake_Console
{
    public class Shtuki
    {
        public List<Point> Chel= new List<Point>();
        public Color color;
        public char sign;

        public Shtuki(Point p, Color color, char sign)
        {
            Chel.Add(p);
            this.color = color;
            this.sign = sign;
        }
        public void Draw()
        {
            foreach(Point p in Chel)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public bool Boom(Shtuki DrugoyChel, int a = 0)
        {
            for(int i = a; i < DrugoyChel.Chel.Count; i++)
            {
                if (DrugoyChel.Chel[i].x == Chel[0].x && DrugoyChel.Chel[i].y == Chel[0].y)
                    return true;
            }
            return false;
        }
    }
}

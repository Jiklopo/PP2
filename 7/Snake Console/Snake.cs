using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace SuperSnake
{
    public class Snake:Shtuki
    {
        int R = 230;
        public Snake(Point p, Color color, char sign) : base(p, color, sign)
        {
        }

        public void ChangeLevel()
        {
            Chel.Clear();
            Chel.Add(new Point(1, 1));
        }

        new public void Draw()
        {
            R = 30;
            Console.SetCursorPosition(Chel[0].x, Chel[0].y);
            Console.Write("@", Color.FromArgb(0, 255, 0));
            for (int i=1; i< Chel.Count; i++)
            {
                R = 20 * i;
                Console.SetCursorPosition(Chel[i].x, Chel[i].y);
                Console.Write(sign + "", Color.FromArgb(R % 255, 255 , R % 255));
            }
        }

        public void Move(Direction dir)
        {
            for (int i = Chel.Count - 1; i > 0; --i)
            {
                Chel[i].x = Chel[i - 1].x;
                Chel[i].y = Chel[i - 1].y;
            }
            Chel[0].x += dir.x;
            Chel[0].y += dir.y;
            if (Chel[0].x > 39)
                Chel[0].x = 0;
            else if (Chel[0].x < 0)
                Chel[0].x = 39;
            if (Chel[0].y >= 19)
                Chel[0].y = 0;
            else if (Chel[0].y < 0)
                Chel[0].y = 19;
        }
    }
}

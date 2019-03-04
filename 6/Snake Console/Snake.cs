using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Snake_Console
{
    class Snake:Shtuki
    {
        int R = 230;
        int G = 255;
        int B = 255;
        public Snake(Point p, Color color, char sign) : base(p, color, sign)
        {
        }

        new public void Draw()
        {
            G = 255;
            Console.SetCursorPosition(Chel[0].x, Chel[0].y);
            Console.Write("@", Color.FromArgb(R, G, B));
            for (int i=1; i< Chel.Count; i++)
            {
                G -= 10;
                Console.SetCursorPosition(Chel[i].x, Chel[i].y);
                Console.Write(sign + "", Color.FromArgb(R, G, B));
            }
        }

        public void Move(ConsoleKeyInfo key)
        {
            int dx = 0;
            int dy = 0;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    dy = 1;
                    break;
                case ConsoleKey.RightArrow:
                    dx = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    dx = -1;
                    break;
            }
            Console.SetCursorPosition(Chel[Chel.Count - 1].x, Chel[Chel.Count - 1].y);
            Console.ResetColor();
            Console.Write(" ");
            for (int i = Chel.Count - 1; i > 0; --i)
            {
                Chel[i].x = Chel[i - 1].x;
                Chel[i].y = Chel[i - 1].y;
            }
            Chel[0].x += dx;
            Chel[0].y += dy;
            if (Chel[0].x > 39)
                Chel[0].x = 0;
            else if (Chel[0].x < 0)
                Chel[0].x = 39;
            if (Chel[0].y > 19)
                Chel[0].y = 0;
            else if (Chel[0].y < 0)
                Chel[0].y = 19;

        }

    }
}

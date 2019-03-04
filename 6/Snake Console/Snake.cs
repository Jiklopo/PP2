using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Snake_Console
{
    public class Snake:Shtuki
    {
        ConsoleKeyInfo previous = new ConsoleKeyInfo();
        int R = 230;
        public Snake(Point p, Color color, char sign) : base(p, color, sign)
        {
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

        public void Move(ConsoleKeyInfo key)
        {
            int dx = 0;
            int dy = 0;
            bool MoveMade = false;
            if (key.Key == ConsoleKey.DownArrow && previous.Key != ConsoleKey.UpArrow)
            {
                MoveMade = true;
                previous = key;
                dy = 1;
            }
            else if (key.Key == ConsoleKey.UpArrow && previous.Key != ConsoleKey.DownArrow)
            {
                MoveMade = true;
                previous = key;
                dy = -1;
            }
            else if (key.Key == ConsoleKey.RightArrow && previous.Key != ConsoleKey.LeftArrow)
            {
                MoveMade = true;
                previous = key;
                dx = 1;
            }
            else if (key.Key == ConsoleKey.LeftArrow && previous.Key != ConsoleKey.RightArrow)
            {
                MoveMade = true;
                previous = key;
                dx = -1;
            }
            if (MoveMade)
            {
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
                if (Chel[0].y >= 19)
                    Chel[0].y = 0;
                else if (Chel[0].y < 0)
                    Chel[0].y = 19;
            }
        }
    }
}

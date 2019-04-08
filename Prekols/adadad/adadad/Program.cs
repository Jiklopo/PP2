using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adadad
{
    public class Direction
    {
        public int dx;
        public int dy;

        public Direction(int dx = 0, int dy = 0)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public void ChangeDir(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                dx = 0;
                dy = -1;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                dx = 0;
                dy = 1;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                dx = 1;
                dy = 0;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                dx = -1;
                dy = 0;
            }
        }
    }
    class Chelik
    {
        public int x;
        public int y;
        Direction dir = new Direction();
        public Chelik()
        {
            x = 0;
            y = 0;
        }
        public void Move(Direction dir)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x += dir.dx;
            if (x == 40)
                x = 0;
            else if (x < 0)
                x = 39;
            y += dir.dy;
            if (y == 20)
                y = 0;
            else if (y < 0)
                y = 19;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }

        public void Move1()
        {
            bool IsTop = y - 1 < 0;
            bool IsBottom = y + 1 == 19;
            bool IsRight = x + 1 == 40;
            bool IsLeft = x - 1 < 0;
            if(IsTop && !IsRight)
            {
                dir.dx = 1;
                dir.dy = 0;
            }
            else if(IsRight && !IsBottom)
            {
                dir.dx = 0;
                dir.dy = 1;
            }
            else if (IsBottom && !IsLeft)
            {
                dir.dx = -1;
                dir.dy = 0;
            }
            else if(IsLeft && !IsTop)
            {
                dir.dx = 0;
                dir.dy = -1;
            }
            Move(dir);
        }

        
    }

    class Program
    {
        public static Chelik chelik = new Chelik();
        public static Direction dir = new Direction();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);
            Timer timer = new Timer(50);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            while (true)
            {
                dir.ChangeDir(Console.ReadKey());
            }
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            chelik.Move1();
        }
    }
}

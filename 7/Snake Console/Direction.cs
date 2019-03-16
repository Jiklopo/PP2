using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSnake
{
    public class Direction
    {
        public int x;
        public int y;

        public Direction()
        {
            x = y = 0;
        }

        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            if(keyInfo.Key == ConsoleKey.UpArrow && y != 1)
            {
                x = 0;
                y = -1;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && y != -1)
            {
                x = 0;
                y = 1;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow && x != -1)
            {
                x = 1;
                y = 0;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow && x != 1)
            {
                x = -1;
                y = 0;
            }
        }
    }
}

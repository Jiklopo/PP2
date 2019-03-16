using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace SuperSnake
{
    public class Scoreboard
    {
        public int score;
        public Scoreboard()
        {
            score = 0;
        }
        public void Draw()
        {
            Console.SetCursorPosition(0, 19);
            Console.Write("Score: " + score, System.Drawing.Color.White);
        }
    }
}

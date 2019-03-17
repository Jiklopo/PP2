using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace SuperSnake
{
    public class Scoreboard
    {
        public Timer timer = new Timer(1000);
        public int score;
        int sec, min;
        string time;
        public Scoreboard()
        {
            timer.Elapsed += Timer_Elapsed;
            score = 0;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
        }

        public void Draw()
        {
            time = " Time: " + min + ":";
            if (sec < 10)
                time += "0";
            time += sec;
            Console.SetCursorPosition(0, 19);
            Console.Write("Score: " + score + time, System.Drawing.Color.White);
        }
    }
}

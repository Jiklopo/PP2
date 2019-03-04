using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Snake_Console
{
    public class Food:Shtuki
    {
        public Food(Point p, Color color, char sign) : base(p, color, sign)
        {
        }

        public void Spawn()
        {
            Random random = new Random();
            Chel[0].x = random.Next(1, 39);
            Chel[0].y = random.Next(1, 19);
            Draw();
        }
    }
}

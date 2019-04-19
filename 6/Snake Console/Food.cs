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

        public void CorrectGoodSpots(Shtuki shtuka)
        {
            foreach(Point point in shtuka.Chel)
            {
                GoodSpots.Remove(point);
            }
        }

        public void Spawn(List<Point> GoodPoints, List<Point> BadPoints)
        {
            Random random = new Random();
            Chel[0] = GoodPoints[random.Next(0, GoodPoints.Count - 1)];
            Draw();
        }
    }
}

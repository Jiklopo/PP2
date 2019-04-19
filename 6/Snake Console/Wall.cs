using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake_Console
{
    public class Wall:Shtuki
    {
        public Wall(Point p, System.Drawing.Color color, char sign):base(p, color, sign)
        {
            LoadLevel();
        }
        
        public void LoadLevel(int lvl = 1)
        {
            Console.Clear();
            Chel.Clear();
            GoodSpots.Clear();
            if (lvl > 3)
                lvl = 1;
            string[] level = File.ReadAllText(@"levels\level" + lvl + ".txt").Split('\n');
            for(int i=0; i<level.Length; i++)
            {
                for(int j=0; j < level[i].Length; j++)
                {
                    if (level[i][j] == '#')
                    {
                        Chel.Add(new Point(j, i));
                    }
                    else if(level[i][j] == '.')
                    {
                        GoodSpots.Add(new Point(j, i));
                    }
                    
                }
            }
        }
    }
}

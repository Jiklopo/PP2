using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Firework
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rows = 21;
            int Columns = Rows * 2 - 1;
            List<Tuple<int, int>> ok_tuples = new List<Tuple<int, int>>();
            ok_tuples.Add(new Tuple < int, int >(Rows - 1, Rows - 1));
            Console.CursorVisible = false;
            bool[,] Firework = new bool[Rows, Columns];
            foreach (Tuple<int, int> t in ok_tuples)
            {
                Firework[t.Item1, t.Item2] = true;
            }
            while (true)
            {
                
                for (int i=0; i<Rows; i++)       
                {
                    for(int j=0; j<Columns; j++)
                    {
                        if (Firework[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(i, Columns / 2);
                            Console.Write("*");
                            if (i > Rows / 2)
                            {
                                Firework[i - 1, j] = true;
                                Firework[i - 2, j] = true;
                                //
                            }

                        }
                        else
                        {
                        //    Console.ResetColor();
                          //  Console.Write(" ");
                        }
                    }
                }
                Thread.Sleep(20);
            }

        }
    }
}

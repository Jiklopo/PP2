using System;
using System.Timers;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Console = Colorful.Console;

namespace SuperSnake
{
    class Game
    {
        SoundPlayer eat = new SoundPlayer(@"Sounds\food.wav");
        SoundPlayer Death = new SoundPlayer(@"Sounds\death.wav");
        Timer Drawer9000 = new Timer(300);
        ConsoleKeyInfo key;
        bool IAmAlive = true;
        Snake snake;
        Food food;
        Wall wall;
        Scoreboard scoreboard;
        Direction dir;
        int lvl = 1;

        public Game()
        {
            snake = new Snake(new Point(10, 10), Color.White, 'O');
            wall = new Wall(new Point(1, 1), Color.BlueViolet, '#');
            food = new Food(new Point(15, 15), Color.Yellow, '$');
            scoreboard = new Scoreboard();
            dir = new Direction();
        }

        public void Start()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);
            Drawer9000.Elapsed += Drawer5000;
            Drawer9000.Start();
            wall.Draw();
            while(IAmAlive && key.Key != ConsoleKey.Escape)
            {
                dir.ChangeDirection(key);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.P)
                    Pause();
                if (!scoreboard.timer.Enabled)
                    scoreboard.timer.Start();
            }
        }

        void Drawer5000(object sender, EventArgs e)
        {
            //while (IAmAlive && key.Key != ConsoleKey.Escape)
            {
                Point tail = new Point(snake.Chel[snake.Chel.Count - 1].x, snake.Chel[snake.Chel.Count - 1].y);
                Console.SetCursorPosition(tail.x, tail.y);
                Console.Write(" ");
                food.Draw();
                snake.Move(dir);
                snake.Draw();
                scoreboard.Draw();
                if (snake.Boom(food))
                {
                    eat.Play();
                    scoreboard.score += 10;
                    scoreboard.Draw();
                    if (scoreboard.score % 50 == 0)
                    {
                        lvl++;
                        Drawer9000.Interval = 300 / lvl;
                        snake.ChangeLevel();
                        wall.LoadLevel(lvl);
                        wall.Draw();
                        dir = new Direction();
                        scoreboard.timer.Stop();
                    }
                    food.Spawn(wall.GoodSpots, snake.Chel);
                    snake.Chel.Add(new Point(30, 19));
                }
                else if ((snake.Chel.Count > 2 && snake.Boom(snake, 1)) || snake.Boom(wall))
                {
                    IAmAlive = false;
                    GameOver();
                }
            }
        }

        public void Pause()
        {
            Drawer9000.Stop();
            scoreboard.timer.Stop();
            ConsoleKeyInfo p = Console.ReadKey();
            while(p.Key != ConsoleKey.P)
                p = Console.ReadKey();
            Console.Clear();
            wall.Draw();
            Drawer9000.Start();
            scoreboard.timer.Start();
        }

        public Color ColorConsole()
        {
            int A;
            A = 0;
            //A = 0 + Console.CursorTop * 12;
            return Color.FromArgb(255, A % 255, A % 255);
        }


        public void GameOver()
        {
            Death.Play();
            Drawer9000.Stop();
            scoreboard.timer.Stop();
            Console.ResetColor();
            Console.Clear();
            
            //G
            for(int i = 4; i < 7; i++)
            {
                Console.SetCursorPosition(8, i);
                Console.Write("*", ColorConsole());
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("*", ColorConsole());
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write("*", ColorConsole());
            }
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(i, 6);
                Console.Write("*", ColorConsole());
            }
            Console.SetCursorPosition(9, 7);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(9, 3);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(13, 3);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(13, 7);
            Console.Write("*", ColorConsole());

            //A
            for (int i = 16; i < 19; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 5);
                Console.Write("*", ColorConsole());
            }
            for (int i = 3; i < 9; i++)
            {
                Console.SetCursorPosition(15, i);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(19, i);
                Console.Write("*", ColorConsole());
            }

            //M
            for (int i = 2; i < 9; i++)
            {
                Console.SetCursorPosition(21, i);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(27, i);
                Console.Write("*", ColorConsole());
            }
            Console.SetCursorPosition(22, 3);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(26, 3);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(23, 4);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(25, 4);
            Console.Write("*", ColorConsole());
            Console.SetCursorPosition(24, 5);
            Console.Write("*", ColorConsole());

            //E
            for (int i = 30; i < 34; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 5);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 8);
                Console.Write("*", ColorConsole());
            }
            for (int i = 2; i < 9; i++)
            {
                Console.SetCursorPosition(29, i);
                Console.Write("*", ColorConsole());
            }

            //O
            for (int i = 11; i < 16; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(14, i);
                Console.Write("*", ColorConsole());
            }
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 16);
                Console.Write("*", ColorConsole());
            }

            //V
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(16, i);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(20, i);
                Console.Write("*", ColorConsole());
            }
            for (int i = 13; i < 16; i++)
            {
                Console.SetCursorPosition(17, i);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(19, i);
                Console.Write("*", ColorConsole());
            }
            Console.SetCursorPosition(18, 16);
            Console.Write("*", ColorConsole());

            //E
            for (int i = 22; i < 26; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 13);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 16);
                Console.Write("*", ColorConsole());
            }
            for (int i = 10; i < 17; i++)
            {
                Console.SetCursorPosition(22, i);
                Console.Write("*", ColorConsole());
            }

            //R
            for (int i = 10; i < 17; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write("*", ColorConsole());
            }
            for (int i = 27; i < 30; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write("*", ColorConsole());
                Console.SetCursorPosition(i, 13);
                Console.Write("*", ColorConsole());
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.Write("*", ColorConsole());
            }
            for (int i = 14; i < 17; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.Write("*", ColorConsole());
            }
            System.Threading.Thread.Sleep(3000);
        }
    }

}

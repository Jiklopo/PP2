using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Console = Colorful.Console;

namespace Snake_Console
{
    class Game
    {
        ConsoleKeyInfo key;
        bool IAmAlive = true;
        Snake snake;
        Food food;
        Wall wall;
        Scoreboard scoreboard;

        public Game()
        {
            snake = new Snake(new Point(10, 10), Color.White, 'O');
            wall = new Wall(new Point(1, 1), Color.BlueViolet, '#');
            food = new Food(new Point(15, 15), Color.Yellow, '$');
            scoreboard = new Scoreboard();
        }

        public void Start()
        {
            //GameOver();
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);
            
            while (IAmAlive && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey();
                wall.Draw();
                snake.Move(key);
                food.Draw();
                snake.Draw();
                scoreboard.Draw();
                if (snake.Boom(food))
                {
                    SoundPlayer eat = new SoundPlayer(@"Sounds\food.wav");
                    eat.Play();
                    scoreboard.score += 10;
                    food.Spawn(wall.GoodSpots);
                    snake.Chel.Add(new Point(0, 0));
                }
                else if ((snake.Chel.Count > 2 && snake.Boom(snake, 1)) || snake.Boom(wall))
                {
                    IAmAlive = false;
                    GameOver();
                }
            }
        }


        public void ColorConsole()
        {
            int A;
            A = 0;
            //A = 0 + Console.CursorTop * 12;
            Console.ForegroundColor = Color.FromArgb(255, A % 255, A % 255);
        }


        public void GameOver()
        {
            SoundPlayer Death = new SoundPlayer(@"Sounds\death.wav");
            Death.Play();
            Console.ResetColor();
            Console.Clear();
            
            //G
            for(int i = 4; i < 7; i++)
            {
                Console.SetCursorPosition(8, i);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(i, 2);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(i, 8);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(i, 6);
                ColorConsole();
                Console.Write("*");
            }
            Console.SetCursorPosition(9, 7);
            ColorConsole();
            Console.Write("*");
            Console.SetCursorPosition(9, 3);
            ColorConsole();
            Console.Write("*");
            Console.SetCursorPosition(13, 3);
            Console.Write("*");
            Console.SetCursorPosition(13, 7);
            ColorConsole();
            Console.Write("*");

            //A
            for (int i = 16; i < 19; i++)
            {
                Console.SetCursorPosition(i, 2);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 5);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 3; i < 9; i++)
            {
                Console.SetCursorPosition(15, i);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(19, i);
                Console.Write("*");
            }

            //M
            for (int i = 2; i < 9; i++)
            {
                Console.SetCursorPosition(21, i);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(27, i);
                Console.Write("*");
            }
            Console.SetCursorPosition(22, 3);
            ColorConsole();
            Console.Write("*");
            Console.SetCursorPosition(26, 3);
            Console.Write("*");
            Console.SetCursorPosition(23, 4);
            ColorConsole();
            Console.Write("*");
            Console.SetCursorPosition(25, 4);
            Console.Write("*");
            Console.SetCursorPosition(24, 5);
            ColorConsole();
            Console.Write("*");

            //E
            for (int i = 30; i < 34; i++)
            {
                Console.SetCursorPosition(i, 2);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 5);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 8);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 2; i < 9; i++)
            {
                Console.SetCursorPosition(29, i);
                ColorConsole();
                Console.Write("*");
            }

            //O
            for (int i = 11; i < 16; i++)
            {
                Console.SetCursorPosition(10, i);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(14, i);
                Console.Write("*");
            }
            for (int i = 11; i < 14; i++)
            {
                Console.SetCursorPosition(i, 10);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 16);
                ColorConsole();
                Console.Write("*");
            }

            //V
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(16, i);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(20, i);
                Console.Write("*");
            }
            for (int i = 13; i < 16; i++)
            {
                Console.SetCursorPosition(17, i);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(19, i);
                Console.Write("*");
            }
            Console.SetCursorPosition(18, 16);
            Console.Write("*");

            //E
            for (int i = 22; i < 26; i++)
            {
                Console.SetCursorPosition(i, 10);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 13);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 16);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 10; i < 17; i++)
            {
                Console.SetCursorPosition(22, i);
                ColorConsole();
                Console.Write("*");
            }

            //R
            for (int i = 10; i < 17; i++)
            {
                Console.SetCursorPosition(27, i);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 27; i < 30; i++)
            {
                Console.SetCursorPosition(i, 10);
                ColorConsole();
                Console.Write("*");
                Console.SetCursorPosition(i, 13);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 10; i < 13; i++)
            {
                Console.SetCursorPosition(30, i);
                ColorConsole();
                Console.Write("*");
            }
            for (int i = 14; i < 17; i++)
            {
                Console.SetCursorPosition(30, i);
                ColorConsole();
                Console.Write("*");
            }
            System.Threading.Thread.Sleep(3000);
            Console.ReadKey();
        }
    }

}

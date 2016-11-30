using System;
using System.Collections.Generic;
using System.Threading;

namespace TestLab3 {
    class Program {

        const int width = 60;
        const int height = 20;

        static int score = 0;
        static int [,] plansza;

        static int vel_X = 1, vel_Y = 0;

        static int [,] snake;
        static int [] food_position;

        static Random rand;

        static void GameInit() {

            Console.CursorVisible = false;

            plansza = new int[width, height];
            snake = new int[width * height, 2];
            food_position = new int[2];

            rand = new Random();

            food_position[0] = rand.Next(width);
            food_position[1] = rand.Next(height);

            Console.SetCursorPosition(food_position[0] + 1, food_position[1] + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");

            #region ramka
            for (int x = 0; x != plansza.GetLength(0) + 2; x++) {
                Console.BackgroundColor = ConsoleColor.White;

                Console.SetCursorPosition(x, 0);
                Console.Write(" ");

                Console.SetCursorPosition(x, height + 1);
                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.Black;
            }

            for (int y = 0; y != plansza.GetLength(1) + 2; y++) {
                Console.BackgroundColor = ConsoleColor.White;

                Console.SetCursorPosition(0, y);
                Console.Write(" ");

                Console.SetCursorPosition(width + 1, y);
                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.Black;
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(width + 3, 0);
            Console.Write("Score: ");
            Console.SetCursorPosition(width + 3, 1);
            Console.Write("{0,6}", score);
        }

        static bool GameUpdate() {

            if (snake[0, 0] == food_position[0] && snake[0, 1] == food_position[1]) {

                food_position[0] = rand.Next(width);
                food_position[1] = rand.Next(height);

                Console.SetCursorPosition(food_position[0] + 1, food_position[1] + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("o");

                score++;

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(width + 3, 0);
                Console.Write("Score: ");
                Console.SetCursorPosition(width + 3, 1);
                Console.Write("{0,6}", score);
            }

            #region strzałki
            if (Console.KeyAvailable == true) {
                ConsoleKeyInfo press = Console.ReadKey(true);

                if (press.Key == ConsoleKey.UpArrow) {
                    vel_X = 0;
                    vel_Y = -1;
                }

                if (press.Key == ConsoleKey.DownArrow) {
                    vel_X = 0;
                    vel_Y = 1;
                }

                if (press.Key == ConsoleKey.LeftArrow) {
                    vel_X = -1;
                    vel_Y = 0;
                }

                if (press.Key == ConsoleKey.RightArrow) {
                    vel_X = 1;
                    vel_Y = 0;
                }

            }
            #endregion

            for(int i=0; i<= score; i++) {

                Console.SetCursorPosition(snake[i, 0] + 1, snake[i, 1] + 1);
                Console.Write("x");
            }

            /*
            for (int x = 0; x != plansza.GetLength(0); x++) {
                for (int y = 0; y != plansza.GetLength(1); y++) {

                    Console.SetCursorPosition(x + 1, y + 1);

                    if (snake[0, 0] == x && snake[0, 1] == y) {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("x");
                    }
                    else if (food_position[0] == x && food_position[1] == y) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("o");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
            }
            */

            if (snake[0, 0] == -1 || snake[0, 1] == -1 || snake[0, 0] == width || snake[0, 1] == height) {
                Console.Clear();
                Console.WriteLine("You lost!");
                Console.WriteLine("Score: {0}", score);
                return false;
            }

            for (int i = 1; i < score; i++) {
                snake[i - 1, 0] = snake[i, 0];
                snake[i - 1, 1] = snake[i, 1];
            }

            snake[0, 0] += vel_X;
            snake[0, 1] += vel_Y;

            return true;
        }

        static void Main(string[] args) {

            GameInit();

            while (true) {

                if (!GameUpdate()) {
                    break;
                }
                Thread.Sleep(100);
            }

        }
    }
}

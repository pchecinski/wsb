using System;
using System.Threading;


namespace TestLab2 {
    class Program {
        const int width = 60;
        const int height = 20;


        struct vector {
            public int x, y;
        }

        static void Main(string[] args) {
            Console.CursorVisible = false;

            Console.CursorSize = 1;

            int[,] plansza = new int[width, height];

            int wonsz_x = 0, wonsz_y = 0, vel_x = 1, vel_y = 0;
            int score = 0;

            Random rand = new Random();
            int mniam_x = rand.Next(width);
            int mniam_y = rand.Next(height);

            #region ramka
            for (int x = 0; x != plansza.GetLength(0) + 2; x++) {
                Console.BackgroundColor = ConsoleColor.White;

                Console.SetCursorPosition(x, 0);
                Console.Write(" ");

                Console.SetCursorPosition(x, height+1);
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

            while (true) {

                if(mniam_x == wonsz_x && mniam_y == wonsz_y) {
                    mniam_x = rand.Next(width);
                    mniam_y = rand.Next(height);

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

                    if(press.Key == ConsoleKey.UpArrow) {
                        vel_x = 0;
                        vel_y = -1;
                    }

                    if (press.Key == ConsoleKey.DownArrow) {
                        vel_x = 0;
                        vel_y = 1;
                    }

                    if (press.Key == ConsoleKey.LeftArrow) {
                        vel_x = -1;
                        vel_y = 0;
                    }

                    if (press.Key == ConsoleKey.RightArrow) {
                        vel_x = 1;
                        vel_y = 0;
                    }

                }
                #endregion

                for (int x = 0; x != plansza.GetLength(0); x++) {
                    for (int y = 0; y != plansza.GetLength(1); y++) {

                        Console.SetCursorPosition(x + 1, y + 1);

                        if(wonsz_x == x && wonsz_y == y) {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("x");
                        }
                        else if (mniam_x == x && mniam_y == y) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("o");
                        }
                        else {
                            Console.Write(" ");
                        }

                        


                    }
                }

                wonsz_x = wonsz_x + vel_x;
                wonsz_y = wonsz_y + vel_y;

                if(wonsz_x == -1 || wonsz_y == -1 || wonsz_x == width || wonsz_y == height) {
                    Console.Clear();
                    Console.WriteLine("You lost!");
                    Console.WriteLine("Score: {0}", score);
                    break;
                }

                Thread.Sleep(33);
            }

            Console.ReadKey();
        }
    }
}

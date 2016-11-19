using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluffyChampion {
    class Program {
        static void Main(string[] args) {

            // var Champions = new List<string>(Champions_array); // List<string> list_postaci = new List<string>(postaci);
            var Champions = new List<string>(
                new string[] {
                //"Thresh", "Karma", "Bard", "Morgana",
                //"Leona", "Braum", "Zyra", "Taric",
                //"Annie", "Zielean", "Nautilus", "Tahm Kench",
                //"Alistar"
                    "Karma", "Bard", "Leona", "Braum", "Ahri", "Lux", "Zyra", "Taric"

                }
            );

            int i, randID;
            Random rand = new Random();
            ConsoleKeyInfo inputKey;

            do {
                Console.Clear();
                Champions.Sort();

                if (Champions.Count == 0) {
                    Console.WriteLine("Niczym nie zagrasz głupi kocie :(");
                    Console.ReadKey();
                    break;
                }


                randID = rand.Next(Champions.Count);
                i = 0;

                Console.WriteLine("Aktualna lista postaci w programie:");
                foreach (string el in Champions) {
                    if(i == randID) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0} ", el);
                        Console.ResetColor();
                    }
                    else {
                        Console.Write("{0} ", el);
                    }

                    if (++i % 5 == 0) {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();


                Console.Write("Wylosowałem dla ciebie: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Champions[randID]);
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1/A. Dodaj postać");
                Console.WriteLine("2/N. Usuń wylosowaną postać z listy");
                Console.WriteLine("Dowolny klawisz - kolene losowanie");
                Console.WriteLine();
                Console.WriteLine("Aby opuścić program naciśnij {0}", ConsoleKey.Enter);

                inputKey = Console.ReadKey(true);
                switch (inputKey.Key) {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.Write("Podaj nazwę postaci jaką mam dodać do losowania: ");
                        Champions.Add(Console.ReadLine());
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.N:
                        Champions.Remove(Champions[randID]);
                        break;

                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        return;
                }
            }
            while (inputKey.Key != ConsoleKey.Escape);
        }
    }
}

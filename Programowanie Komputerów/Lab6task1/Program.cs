using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6task1 {
    class Program {
        enum MetodyCalkowania {
            Prostokatow = 1,
            Trapezow = 2
        }

        static void Main(string[] args) {

            MetodyCalkowania metoda = MetodyCalkowania.Prostokatow;

            Char c;
            double a = 0, b = 1;
            int n = 1;

            do {

                // Menu
                Console.Clear();
                Console.WriteLine("Przedział całkowania: <{0}; {1}>", a, b);
                Console.WriteLine("Liczba podziałów: {0}", n);
                Console.WriteLine("Metoda całkownia: {0}", metoda);
                Console.WriteLine("A - Zmiana przedziału");
                Console.WriteLine("B - Zmiana liczby podziałów");
                Console.WriteLine("C - Zmiana metody całkowania");
                Console.WriteLine("D - Oblicz całkę");
                Console.WriteLine("X - Koniec");

                c = Char.ToLower(Console.ReadKey(true).KeyChar);

                // Polecenia
                switch (c) {
                    case 'a': // przedział
                        do {
                            Console.Clear();

                            if (a > b) {
                                Console.WriteLine("Początek musi być mniejszy od końca!");
                            }

                            Console.Write("Podaj początek przedziału: ");
                            Double.TryParse(Console.ReadLine(), out a);

                            Console.Write("Podaj koniec przedziału: ");
                            Double.TryParse(Console.ReadLine(), out b);
                        }
                        while (a > b);
                        break;

                    case 'b': // liczba podziałów
                        do {
                            Console.Clear();
                            Console.Write("Podaj liczbę podziałów: ");
                            Int32.TryParse(Console.ReadLine(), out n);
                        }
                        while (n == 0);

                        break;

                    case 'c': // metoda

                        int m = 1;
                        do {
                            Console.Clear();

                            if (m != 1) {
                                Console.WriteLine("Ogarnij się, 1 lub 2!");
                            }

                            Console.WriteLine("Wybierz metodę całkowania:");
                            Console.WriteLine("1 - Metoda prostokątów");
                            Console.WriteLine("2 - Metoda trapezów");

                            Int32.TryParse(Console.ReadLine(), out m);
                        }
                        while (!(m == 1 || m == 2));
                        metoda = (MetodyCalkowania)m; // rzutowanie typu
                        break;

                    case 'd': // wypisanie wyniku

                        double suma = 0;
                        double dx = (b - a) / n;
                        double x = a;

                        switch (metoda) {
                            case MetodyCalkowania.Prostokatow:
                                for (int i = 0; i < n; i++) {
                                    x += dx;
                                    suma += Math.Pow(x, 4) + Math.Pow(x, 3) + 2;
                                }
                                suma *= dx;

                                break;

                            case MetodyCalkowania.Trapezow:
                                for (int i = 1; i < n; i++) {
                                    x += dx;
                                    suma += Math.Pow(x, 4) + Math.Pow(x, 3) + 2;
                                }
                                suma += (a * a * a * (a + 1) + b * b * b * (b + 1) + 4) / 2;
                                suma *= dx;
                                break;
                        }

                        Console.WriteLine("To coś wynosi: {0}", suma);
                        Console.ReadKey();
                        break;
                }
            }
            while (c != 'x');

        }
    }
}

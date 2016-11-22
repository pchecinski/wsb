using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabX {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("MENU:");
            Console.WriteLine();
            Console.WriteLine("1. obliczanie objętości graniastosłupa");
            Console.WriteLine("2. prostokąt z gwiazdek");
            Console.WriteLine("3. pobieranie liczb do tablicy");
            Console.WriteLine("4. suma aż 0");
            Console.WriteLine("5. suma cyfr w podanej liczbie:");
            Console.WriteLine("6. konwersja systemów");
            Console.WriteLine("7. trójki pitagorejskie");


            char c = Console.ReadKey(true).KeyChar;
            
            // Czyści konsole i podaje numer programu, estatyka
            Console.Clear();
            Console.WriteLine("Wybrano program {0}", c);

            switch (c) {
                /*
                 Zadanie 1: Pole ostrosłupa 1/3 * PP * H
                 (uwaga: polecam w kodzie mieć użyte 3.0 lub typ double, inaczej wychodzą liczby całkowite czyli bzdury!)
                 */
                case '1': {
                        double a = 0, b = 0, h = 0;

                        Console.Write("Podaj a: ");
                        Double.TryParse(Console.ReadLine(), out a);

                        Console.Write("Podaj b: ");
                        Double.TryParse(Console.ReadLine(), out b);

                        Console.Write("Podaj h: ");
                        Double.TryParse(Console.ReadLine(), out h);

                        Console.WriteLine("Objętość ostrosłupa: {0}", a * b * h / 3.0);
                        break;
                    }
                    
                /*
                 Zadanie 2: Wypisanie prostokąta z gwiazdek i kółek
                 */
                case '2': {
                        int a = 0, b = 0;

                        do {
                            Console.Write("Podaj a: ");
                            Int32.TryParse(Console.ReadLine(), out a);

                            Console.Write("Podaj b: ");
                            Int32.TryParse(Console.ReadLine(), out b);
                        }
                        while (a <= 0 || b <= 0);

                        for (int x = 0; x < a; x++) {
                            for (int y = 0; y < b; y++) {

                                if (x == 0 || x == a - 1 || y == 0 || y == b - 1) {
                                    Console.Write("*"); // ramka
                                }
                                else {
                                    Console.Write("o"); // wnętrze
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    }

                /*
                 Zadanie 3: Pobieranie N-liczb do tablicy, sprawdzenie czy liczby są dodatnie oraz parzyste
                 */
                case '3': {

                        int n = 0;

                        do {
                            Console.Write("Podaj n: ");
                            Int32.TryParse(Console.ReadLine(), out n);
                        }
                        while (n <= 0 || n >= 1000);

                        int[] liczby = new int[n];

                        // Wczytywanie n liczb całkowitych
                        for (int s = 0; s != n; s++) {
                            Console.WriteLine("Podajesz liczbę {0} z {1}", s + 1, n);
                            Int32.TryParse(Console.ReadLine(), out liczby[s]);
                        }

                        int parzyste = 0, ujemne = 0;
                        foreach (int element in liczby) {
                            if (element % 2 == 0) {
                                parzyste++;
                            }

                            if (element < 0) {
                                ujemne++;
                            }
                        }
                        Console.WriteLine("Podałeś {0} liczb parzystych oraz {1} liczb ujemnych", parzyste, ujemne);
                        break;
                    }

                /*
                 Zadanie 4: Suma podanych liczb dopóki użytkownik nie poda 0

                 */
                case '4': {

                        int suma = 0, podana = 0;
                        do {
                            Int32.TryParse(Console.ReadLine(), out podana);

                            suma += podana;
                        }
                        while (podana != 0);
                        Console.WriteLine("Suma podanych liczb wynosi: {0}", suma);

                        break;
                    }

                /*
                 Zadanie 5: Wypisanie sumy cyfr w podanej liczbie, korzystam z rozbicia stringu na tablicę charów 
                            oraz z tablicy ascii 0 -> 48, 1 -> 49
                 */
                case '5': {
                        string linia = Console.ReadLine();
                        char[] tablica = linia.ToArray();
                        int Suma = 0;

                        for (int C = 0; C != linia.Length; C++) {
                            Suma += (int)tablica[C] - 48;
                        }

                        Console.WriteLine("Suma cyfr w podanej liczbie: {0}", Suma);
                        break;
                    }

                /*
                 Zadanie 6: Konwersja sytemu 10 na 16. Algorytm trochę oszukańczy ale bazowałem się na:
                            http://www.programuj.com/artykuly/rozne/sysliczb.php
                            i = 8 bo int ogranicza nas do 2^32 czyli 16^8 :)
                            uint bo dla ujemnych i tak wychodzą pierdoły
                 */
                case '6': {
                        uint n = 0;
                        UInt32.TryParse(Console.ReadLine(), out n);

                        for (int i = 8; i >= 0; i--) {
                            uint x = n / (uint)Math.Pow(16, i);
                            switch (x) {
                                case 10:
                                    Console.Write("A");
                                    break;

                                case 11:
                                    Console.Write("B");
                                    break;

                                case 12:
                                    Console.Write("C");
                                    break;

                                case 13:
                                    Console.Write("D");
                                    break;

                                case 14:
                                    Console.Write("E");
                                    break;

                                case 15:
                                    Console.Write("F");
                                    break;

                                default:
                                    Console.Write(x);
                                    break;
                            }
                            
                            n = n % (uint)Math.Pow(16, i);
                        }
                        
                        break;
                    }
                  
                /*
                 Zadanie 7: Wypisanie trójek pitagorejskich dla których x^2 + y^2 = z^2 x,y,z są Całkowite.
                            Z = Pierwiastek ( X ^ 2 + Y ^ 2)
                            Sprawdzam czy Z = zaokąglenie Z (czy liczba jest całkowita)
                 */
                case '7': {
                        for (int x = 1; x != 1000; x++) {
                            for (int y = 1; y != 1000; y++) {

                                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) == Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))) {
                                    Console.WriteLine("{0} + {1} = {2}", x, y, Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
                                }

                            }
                        }
                        break;
                    }
            }

            // Koncie programu
            Console.ReadKey();
        }
    }
}

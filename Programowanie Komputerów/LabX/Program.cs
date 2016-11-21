using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabX {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("MENU:");

            Console.WriteLine("1. obliczanie objętości graniastosłupa");
            Console.WriteLine("2. prostokąt z gwiazdek");
            Console.WriteLine("3. pobieranie liczb do tablicy");
            Console.WriteLine("4. suma aż 0");
            Console.WriteLine("5. suma cyfr w podanej liczbie:");

            char c = Console.ReadKey(true).KeyChar;

            switch (c) {

                case '1':
                    double a = 0, b = 0, h = 0;

                    Console.Write("Podaj a: ");
                    Double.TryParse(Console.ReadLine(), out a);

                    Console.Write("Podaj b: ");
                    Double.TryParse(Console.ReadLine(), out b);

                    Console.Write("Podaj h: ");
                    Double.TryParse(Console.ReadLine(), out h);

                    Console.WriteLine("Objętość ostrosłupa: {0}", a * b * h / 3.0);
                    break;

                case '2':
                    int A = 0, B = 0;

                    do {
                        Console.Write("Podaj a: ");
                        Int32.TryParse(Console.ReadLine(), out A);

                        Console.Write("Podaj b: ");
                        Int32.TryParse(Console.ReadLine(), out B);
                    }
                    while (A <= 0 || B <= 0);

                    for (int x = 0; x < A; x++) {
                        for(int y = 0; y < B; y++) {

                            if(x == 0 || x == A-1 || y == 0 || y == B-1) {
                                Console.Write("*"); // ramka
                            }
                            else {
                                Console.Write("o"); // wnętrze
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case '3':

                    int n = 0;

                    do {
                        Console.Write("Podaj n: ");
                        Int32.TryParse(Console.ReadLine(), out n);
                    }
                    while (n <= 0 || n >= 1000);

                    int[] liczby = new int[n];

                    // Wczytywanie n liczb całkowitych
                    for(int s = 0; s != n; s++) {
                        Console.WriteLine("Podajesz liczbę {0} z {1}", s+1, n);
                        Int32.TryParse(Console.ReadLine(), out liczby[s]);
                    }
                    // parzyste, ujemne

                    int parzyste = 0, ujemne = 0;
                    foreach(int element in liczby) {
                        if (element % 2 == 0) {
                            parzyste++;
                        }

                        if(element < 0) { 
                            ujemne++;
                        }
                    }
                    Console.WriteLine("Podałeś {0} liczb parzystych oraz {1} liczb ujemnych", parzyste, ujemne);
                    break;

                case '4':

                    int suma = 0, podana = 0;
                    do {
                        Int32.TryParse(Console.ReadLine(), out podana);

                        suma += podana;
                    }
                    while (podana != 0);
                    Console.WriteLine("Suma podanych liczb wynosi: {0}", suma);

                    break;

                case '5':

                    string linia = Console.ReadLine();
                    char[] tablica = linia.ToArray();
                    int Suma = 0;

                    for (int C = 0; C!= linia.Length; C++) {
                        Suma += (int)tablica[C] - 48;    
                    }

                    Console.WriteLine("Suma cyfr w podanej liczbie: {0}", Suma);
                    break;

                case '6':
                    int aaa = 0, i_forgot_how_to_dis =0; // Homework!!

                    Console.WriteLine("Podaj n: ");
                    Int32.TryParse(Console.ReadLine(), out aaa);

                    Console.WriteLine("{0}", i_forgot_how_to_dis);


                    // pobieramy n, wyświetlenie w systemie 16-kowym

                    break;

                case '7':

                    for (int AA = 1; AA != 1000; AA++) {
                        for (int BB = 1; BB != 1000; BB++) {

                            if(Math.Sqrt(Math.Pow(AA, 2) + Math.Pow(BB, 2)) == Math.Round(Math.Sqrt(Math.Pow(AA, 2) + Math.Pow(BB, 2)))) {
                                Console.WriteLine("{0} + {1} = {2}", AA, BB, Math.Sqrt(Math.Pow(AA, 2) + Math.Pow(BB, 2)));
                            }

                        }
                    }

                    break;
            }

            Console.ReadKey();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7task2 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 2
               Napisz program, który sortuje tablicę metodą przez wybieranie. Tablicę
                zainicjalizuj liczbami pseudolosowymi, korzystając z generatora liczb
                pseudolosowych.
            */

            Random rand = new Random();
            double[] liczby = new double[16];

            Console.WriteLine("Wylosowano następujące wartości:");
            for (int i = 0; i != liczby.Length; i++) {
                liczby[i] = rand.NextDouble();
                Console.Write("{0:F3}; ", liczby[i]);
            }

            int min;
            for (int i = 0; i != liczby.Length; i++) {
                
                // porównuję liczbę w indeksie I
                min = i;

                /*
                 *  min przyjmuje index najmniejszej liczby w następnych miejscach
                 *  j = i + 1 -> sprawdzanie od kolejnej do długości
                 */
                for (int j = i + 1; j != liczby.Length; j++) {
                    if(liczby[j] < liczby[min]) {
                        min = j;
                    }
                }

                // zamiana miejscami liczby[i] <-> liczby[min]
                if(min != i) {
                    double x = liczby[i];
                    liczby[i] = liczby[min];
                    liczby[min] = x;
                }
            }

            Console.WriteLine("\nElementy tablicy po sortowaniu:");
            foreach (double d in liczby) {
                Console.Write("{0:F3}; ", d);
            }

            Console.ReadKey();
        }
    }
}

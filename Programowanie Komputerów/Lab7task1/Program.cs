using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7task1 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 1
               Napisz program, który sortuje tablicę metodą przez wstawianie. Tablicę
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

            double x;
            int j;

            for(int i = 1; i < liczby.Length; i++) {
                x = liczby[i];
                for (j = i-1; j >= 0 && x < liczby[j]; j--) {
                    liczby[j + 1] = liczby[j];

                }
                liczby[j + 1] = x;
            }

            Console.WriteLine("Elementy tablicy po sortowaniu:");
            foreach(double d in liczby) {
                Console.Write("{0:F3}; ", d);
            }

            Console.ReadKey();
        }
    }
}

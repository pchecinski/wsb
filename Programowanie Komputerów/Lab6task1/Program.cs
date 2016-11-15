using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestLab {
    class Program {

        static void Main(string[] args) {
            /*
             Ćwiczenie 1
               Napisz program, który znajduje największy i najmniejszy element tablicy.
               Tablicę zainicjalizuj liczbami pseudolosowymi, korzystając z generatora liczb
               pseudolosowych:
            */

            const int min = 0;
            const int max = 100;
            Random r = new Random(); //utworzenie obiektu generatora liczb pseudolosowych


            int[] tablica = new int[15];

            for (int i = 0; i != tablica.Length; i++) {
                tablica[i] = r.Next(min, max + 1); //losowanie liczby z przedziału <0;100>
            }

            int indexMin = 0, indexMax = 0;

            Console.WriteLine("Wylosowano następujące wartości:");
            for (int i = 0; i != tablica.Length; i++) {
                Console.Write("{0} ", tablica[i]);

                if (tablica[i] > tablica[indexMax]) {
                    indexMax = i;
                }


                if (tablica[i] < tablica[indexMin]) {
                    indexMin = i;
                }

            }

            Console.WriteLine("\n\nNajwiększy element to tablica[{0}] = {1}\nNajmniejszy element to tablica[{2}] = {3}", indexMax, tablica[indexMax], indexMin, tablica[indexMin]);
            Console.ReadKey();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6task3 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 3
               Napisz program, które losuje sześć różnych liczb całkowitych z przedziału <1; 49>.
            */

            // Metoda 1 - "wykeślanie"
            Console.WriteLine("Metoda 1");
            Random generator = new Random();

            // K - ilość liczb, N - zakres 1,2..n
            int k = 6;
            int n = 49;
 
            // tablica [1, 2, 3, .., n]
            int[] numery = new int[n];
            for(int i = 0; i != n; i++) {
                numery[i] = i + 1;
            }

            // losowanie
            for(int i = 0; i != k; i++) {
                int r = generator.Next(n);

                Console.WriteLine(numery[r]);

                numery[r] = numery[n - 1];
                n--;
            }

            // Metoda 2 - "losuj dopóki"
            Console.WriteLine("Metoda 2");

            int index = 0;
            int[] wynik = new int[6];
            bool unique;

            do {
                wynik[index] = generator.Next(1, 50);
                unique = true;

                for(int i = 0; i < index; i++) {
                    if (wynik[index] == numery[i]) {
                        unique = false;
                        break;
                    }
                }

                if (unique) {
                    index++;
                }
            }
            while (index != 6);

            foreach(int i in wynik) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

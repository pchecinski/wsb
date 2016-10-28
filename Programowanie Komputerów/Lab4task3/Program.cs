using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4task3 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 3
               Napisz program obliczający sumę i iloczyn n pierwszych liczb naturalnych podzielnych przez k,
               gdzie k oraz n są dowolnymi liczbami naturalnymi.
            */


            ushort n, k;
            Console.WriteLine("Podaj n (ilość wyrazów):");
            ushort.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Podaj k (podzielne przez):");
            ushort.TryParse(Console.ReadLine(), out k);

            ulong suma = 0, iloczyn = 1;
            for (uint i = 1; i <= n; i++) {
                suma += i * k;
                checked {
                    iloczyn *= i * k;
                }
            }

            Console.WriteLine("Suma {0} liczb podzielnch przez {1} wynosi {2}", n, k, suma);
            Console.WriteLine("Iloczyn {0} liczb podzielnch przez {1} wynosi {2}", n, k, iloczyn);
            Console.ReadKey(false);
        }
    }
}

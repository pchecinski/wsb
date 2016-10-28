using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4task1 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 1
               Napisz program, który znajduje największy wspólny dzielnik (NWD) dwóch liczb naturalnych
               Problemu ten rozwiązuje algorytm Euklidesa
            */

            ulong n, m, diff;

            Console.WriteLine("Podaj n:");
            n = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Podaj m:");
            m = ulong.Parse(Console.ReadLine());

            if (n <= 0 || m <= 0) {
                Console.WriteLine("Podano nieprawidłowe wartości!");
            }
            else {
                do {
                    diff = n > m ? n - m : m - n;

                    if (n > m) {
                        n = diff;
                    }
                    else {
                        m = diff;
                    }
                }
                while (diff != 0);

                Console.WriteLine("NWD: {0}", n);
            }
            Console.ReadKey(false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3task2 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 2
               Napisz program, który oblicza wartość wyrażenia:                        x*y     dla x < 0 i y < 0
                 z =    10      dla x = 0 lub y = 0
                        x+y     dla pozostałych
            */

            double x, y, z;
            Console.Write("Podaj wartość x: ");
            Double.TryParse(Console.ReadLine(), out x);

            Console.Write("Podaj wartość y: ");
            Double.TryParse(Console.ReadLine(), out y);

            // wersja if - else if - else 
            if (x < 0 && y < 0) {
                z = x * y;
            }
            else if (x == 0 || y == 0) {
                z = 10;
            }
            else {
                z = x + y;
            }
            Console.WriteLine("Wartość z wynosi: {0}", z);

            // wersja z wyrażeniem warunkowym
            z = (x < 0 && y < 0) ? x * y : ((x == 0 || y == 0) ? 10 : x + y);
            Console.WriteLine("Wartość z wynosi: {0}", z);

            Console.ReadKey();
        }
    }
}

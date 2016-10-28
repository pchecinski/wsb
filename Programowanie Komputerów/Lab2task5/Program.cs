using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task5 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 5
               Program wyznaczający maksimum z dwóch liczb całkowitych przy pomocy wyrażenia warunkowego..
            */

            long a, b, max;

            Console.Write("Podaj wartość a: ");
            long.TryParse(Console.ReadLine(), out a);

            Console.Write("Podaj wartość b: ");
            long.TryParse(Console.ReadLine(), out b);

            max = a > b ? a : b;

            Console.WriteLine("Wartość maksymalna wynosi: {0}.", max);
            Console.ReadKey();
        }
    }
}

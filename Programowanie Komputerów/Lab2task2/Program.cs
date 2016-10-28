using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task2 { 
    class Program {  
        static void Main(string[] args) { 

            /*
             Ćwiczenie 2
                Obliczanie wartości wyrażenia v = [ 4x - y ] / [ 3 ( z^2 + 1 ) ]
            */

            double x, y, z, v;

            Console.WriteLine("Podaj wartość zmiennej x: ");
            Double.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Podaj wartość zmiennej y: ");
            Double.TryParse(Console.ReadLine(), out y);

            Console.WriteLine("Podaj wartość zmiennej z: ");
            Double.TryParse(Console.ReadLine(), out z);

            // ignoruję błędy odczytu

            v = (4 * x - y) / ( 3 * (Math.Pow(z, 2) + 1 ));

            Console.WriteLine("Wynik: {0}", v);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3task1 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 1
               Utwórz programu, który obliczy pierwiastki równania kwadratowego: ax^2+bx+c=0.
            */

            double a, b, c;
            Console.WriteLine("Podaj wartość a");
            Double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Podaj wartość b");
            Double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Podaj wartość c");
            Double.TryParse(Console.ReadLine(), out c);

            if(a == 0) {
                throw new Exception("Parametr a musi być różny od zera");
            }

            double delta = b * b - 4 * a * c, x1, x2;

            if(delta > 0) {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Równanie ma dwa pierwiastki: ");
                Console.WriteLine("\tx1 = {0}", x1);
                Console.WriteLine("\tx2 = {0}", x2);

            }
            else if(delta == 0) {
                x1 = -b / (2 * a);

                Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty: ");
                Console.WriteLine("\tx1 = {0}", x1);
            }
            else {
                Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4task2 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 2
               Utwórz programu, który oblicza przybliżoną wartość pierwiastka kwadratowego, dla dowolnie wybranej liczby nieujemnej.
            */

            const double epsilon = 0.000000001;

            double a, x = 1;

            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
                throw new Exception("a nie może być ujemne");

            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }

            Console.WriteLine("Wartością (przybliżoną) pierwiastka kwadratowego liczby {0} jest {1} (sqrt = {2}).", a, x, Math.Sqrt(a));
            Console.ReadKey();
        }
    }
}

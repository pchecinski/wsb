using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0;

            Console.WriteLine("Podaj A, B oraz C:");

            Console.Write("A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("C: ");
            C = Convert.ToDouble(Console.ReadLine());


            double delta = B * B - 4 * A * C;
            Console.WriteLine("Delta wynosi: {0}", delta);

            if (delta > 0)
            {
                Console.WriteLine("x1 = {0}\nx2 = {1}", (-B - Math.Sqrt(delta)) / 2 * A, (-B + Math.Sqrt(delta)) / 2 * A);
            }
            else if (delta == 0)
            {
                Console.WriteLine("x = {0}", -B / 2 * A);
            }
            else
            {
                Console.WriteLine("brak rozwiązań, delta ujemna");
            }

            Console.ReadKey();
        }
    }
}

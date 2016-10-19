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
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            while (input.Key != ConsoleKey.Escape)
            {
                double A = 0, B = 0, C = 0;

                Console.WriteLine("Podaj A, B oraz C:");

                Console.Write("A: ");
                try
                {
                    A = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    A = Math.PI;
                }


                Console.Write("B: ");
                try
                {
                    B = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    B = 0;
                }

                Console.Write("C: ");
                try
                {
                    C = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    C = 0;
                }


                if (A == 0)
                {
                    throw new Exception("Parametr A nie powinien wynosić 0");
                }


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

                input = Console.ReadKey();
                //input = Console.ReadKey();
                //input = Convert.ToChar(Console.ReadKey());
            }
        }
    }
}
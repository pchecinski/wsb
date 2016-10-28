using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ćwiczenie 1
                Utworzenie programu, który zamienia (wymienia) wartości dwóch zmiennych.
                Algorytm ten po angielsku nosi nazwę Swap (zamiana). Jest to jeden z
                podstawowych algorytmów używany do budowy bardziej skomplikowanych
                programów.             */

            double a=0, b=0, tmp; // predefiniowana wartość 0 bo ustawiam w try+catch

            Wczytywanie:
            try
            {
                Console.WriteLine("Podaj wartość zmiennej a: ");
                a = Double.Parse(Console.ReadLine());               // Tak też można zamiast convert

                Console.WriteLine("Podaj wartość zmiennej b: ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Podano nieprawidłową wartość zmiennych. Spróbuj jeszcze raz\n");
                goto Wczytywanie;
            }

            Console.WriteLine("Wartości:\na = {0}\nb = {1}", a, b);

            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("Wartości:\na = {0}\nb = {1}", a, b);

            Console.ReadKey();
        }
    }
}

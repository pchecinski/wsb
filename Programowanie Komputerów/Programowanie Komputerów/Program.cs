using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Ćwiczenie 1
                Utworzenie programu, który wypisuje na ekranie powitanie i czeka na reakcje
                użytkownika. Potem wypisuje "Koniec" i znów czeka na reakcję użytkownika i
                następnie kończy działanie.
             */
            Console.WriteLine("Witam Pana(ią)");
            Console.ReadKey(true);
            Console.Write("Koniec");

            Console.ReadKey(true);
        }
    }
}

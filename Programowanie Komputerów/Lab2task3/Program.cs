using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task3 { 
    class Program { 
        static void Main(string[] args) { 
        
            /*
             Ćwiczenie 3
                Program obliczający pole i obwód koła o zadanym promieniu
            */
            double a;
            Console.WriteLine("Podaj wartość a: ");

            read_a:
            if(!Double.TryParse(Console.ReadLine(), out a)) goto read_a; // Kolejna metoda na wczytywanie dopóki podany jest prawidłowy double

            Console.WriteLine("Wartość a wynosi: {0}\nPole koła o boku a: {1}\nObwód koła o boku a: {2}", a, Math.PI * Math.Pow(a, 2), 2 * Math.PI * a);
            Console.ReadKey(); 
        }
    }
}

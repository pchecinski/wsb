using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4task4 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 4
               Napisz program, grę - zgadnij liczbę. Użytkownik ma zgadnąć liczbę
                wylosowaną przez komputer. Do wylosowania liczby pseudolosowej stosuj
                następujący kod
                
                Random generator = new Random();
                int liczba = generator.Next(a, b +1);
            */
            const int a = 0;
            const int b = 200;
            Random generator = new Random();
            int liczba = generator.Next(a, b + 1);

            Console.WriteLine("Podaj wartość wylosowanej liczby. Wartość jest z przedziału <{0}, {1}>: ", a, b);
            int input, n_of_try=0;

            do {
                int.TryParse(Console.ReadLine(), out input);

                if(input > liczba)
                    Console.WriteLine("Wartość podana jest za duża");
                else if (input < liczba)
                    Console.WriteLine("Wartość podana jest za mała");

                n_of_try++;
            }
            while (input != liczba);


            Console.WriteLine("Gratulacje!!! Odgadłeś liczbę. Ilość prób: {0}", n_of_try);
            Console.ReadKey();
        }
    }
}

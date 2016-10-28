using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2task4 {
    class Program {
        static void Main(string[] args) {
            /*
             Ćwiczenie 4
               Program obliczający cenę brutto oraz podatek od podanej ceny netto..
            */

            const decimal Vat = 0.23M; // hehe 23% :)
            decimal netto, podatek, brutto;

            Console.Write("Podaj wartość netto: ");
            Decimal.TryParse(Console.ReadLine(), out netto);

            podatek = Vat * netto;
            brutto = netto + Vat;
            
            Console.WriteLine("Cena wynosi {0:C}, w tym kwota podatku: {1:C}", brutto, podatek); // {0:C} - cash
            Console.ReadKey();
        }
    }
}

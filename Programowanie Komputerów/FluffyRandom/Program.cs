using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluffyRandom {
    class Program {

        enum postac {
            Thresh = 1,
            Karma = 2,
            Bard = 3,
            Morgana = 4,
            Leona = 5,
            Braum = 6,
            Zyra = 7,
            Taric = 8,
            Annie = 9,
            Zielean = 10,
            Nautilus = 11,
            Tahm = 12,
            Alistar = 13

        }

        static void Main(string[] args) {

            Random generator = new Random();
            int liczba = generator.Next(1, 13 + 1);

            Console.WriteLine("Wylosowana postać dla Fluffy to {0}", (postac)liczba);
            Console.ReadKey();
        }
    }
}

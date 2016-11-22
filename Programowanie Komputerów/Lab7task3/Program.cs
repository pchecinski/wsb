using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7task3 {
    class Program {
        static void Main(string[] args) {

            string[] miasta = { "Poznań", "Warszawa", "Częstochowa", "Gdańsk", "Łódź", "Kraków", "Wrocław", "Białystok", "Szczecin" };

            Array.Sort(miasta);
            Console.WriteLine("Elementy tablicy po sortowaniu: ");

            foreach (string miasto in miasta) {
                Console.Write("{0}, ", miasto);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Podaj nazwę miasta: ");
            string s = Console.ReadLine();

            int lewy = 0, prawy = miasta.Length - 1;
            int srodek = (prawy + lewy) / 2;

            int compare = -1;

            while (lewy <= prawy) {

                compare = String.Compare(s, miasta[srodek]);

                if(compare == 0) {
                    break;
                }

                if (compare > 0) {
                    lewy = srodek + 1;
                }
                
                else {
                    prawy = srodek - 1;
                }

                srodek = (lewy + prawy) / 2;
            }

            if(compare == 0) {
                Console.WriteLine("Podane miasto ma w tablicy indeks {0}.", srodek);
            }
            else {
                Console.WriteLine("Tablica nie zawiera podanego miasta.");
            }

            // Prościej, ale nielegalnie

            int index = Array.BinarySearch(miasta, s);
            if (index > 0) {
                Console.WriteLine("Podane miasto ma w tablicy indeks {0}.", index);
            }
            else {
                Console.WriteLine("Tablica nie zawiera podanego miasta.");
            }

            Console.ReadKey();
        }
    }
}

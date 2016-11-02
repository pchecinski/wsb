using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestLab {
    class Program {
        static void Main(string[] args) {




        }
    }
}





/*
 * 
 *             long liczMin = 2000000000;
            long liczMax = 3000000000;
            Stopwatch sw = new Stopwatch();


            long liczba;

            long i, ogr, work;
            Boolean pierwsza;

            for (liczba = liczMin; liczba <= liczMax; liczba++) {
                pierwsza = true;
                work = 1;
                sw.Reset();
                sw.Start();

                //ogr = liczba - 1;
                //ogr = (liczba / 2) + 1;
                ogr = (long)Math.Sqrt(liczba) + 1;

                for (i = 2; (i <= ogr) && pierwsza; i++) {
                    if ((liczba % i) == 0) {
                        pierwsza = false;
                    }
                    work++;
                }
                sw.Stop();
                Console.WriteLine("{0}\t{1}\twork: {2,11}\ttime={3}", liczba, pierwsza, work, sw.Elapsed.TotalMilliseconds);

                //if ((liczba % 100) == 0) Console.WriteLine(".");
            }
            Console.WriteLine("---");
            Console.ReadKey();
*/
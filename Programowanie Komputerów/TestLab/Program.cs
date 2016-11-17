using System;
using System.Globalization;

/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
*/


namespace TestLab {
    class Program {

        static void Main(string[] args) {
            /*
             Ćwiczenie X
               Treść
               Treść
            */



            String line = Console.ReadLine();
            double x = double.Parse(line, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            Console.WriteLine(x);
            Console.ReadKey();



            /*
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = "."; // Dane wejściowe mają format 0.45 zamiast 0,45
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            */

            /*
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\u2103");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (var i = 0; i <= 1000; i++) {
                //Console.Write(Strings.ChrW(i));
                if (i % 50 == 0) { // break every 50 chars
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            */
        }

    }
}
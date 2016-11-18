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

        static double parse_bin(string s) {
            String[] t = s.Split('.');
            return Convert.ToInt32(t[0], 2) + Convert.ToInt32(t[1], 2) / Math.Pow(2.0, t[1].Length);
        }

        static void Main(string[] args) {
            /*
             Ćwiczenie X
               Treść
               Treść
            */

            Console.WriteLine(parse_bin("0.001"));
            Console.WriteLine(parse_bin("0.100"));
            Console.WriteLine(parse_bin("1.1101"));
            //


            long z = (long)1.3;
            Console.WriteLine(z);

            //Double var = 1;
            //Console.WriteLine("{0:I}", var);

            //


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
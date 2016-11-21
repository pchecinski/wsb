using System;
using System.Globalization;
using System.Numerics;

/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
*/

namespace TestLab {
    class Program {

        static double distance2D(double x1, double y1, double x2, double y2) {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }


        static BigInteger factorial(int n) {
            return n == 1 ? n : n * factorial(n - 1);
        }

        static int ack(int m, int n) {
            int ans;

            if (m == 0) ans = n + 1;
            else if (n == 0) ans = ack(m - 1, 1);
            else ans = ack(m - 1, ack(m, n - 1));

            return ans;
        }


        static double parse_bin(string s) {
            String[] t = s.Split('.');
            return Convert.ToInt32(t[0], 2) + Convert.ToInt32(t[1], 2) / Math.Pow(2.0, t[1].Length);
        }

        static void Main(string[] args) {

            Console.WriteLine(distance2D(2,5, 5,9));
            Console.ReadKey();

            return;

            int X = 8000;
            Console.WriteLine("factorial ({0}) is: {1}", X, factorial(X));

        

            Console.ReadKey();
            return;

            int sum = 0;
            for(int i = 1; i != 1000000 + 1; i++) {
                char [] arr = i.ToString().ToCharArray();

                foreach(char a in arr) {
                    sum += ((int)a - 48);
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
            return;


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
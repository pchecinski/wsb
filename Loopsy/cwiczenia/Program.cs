using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_you_even_care
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tabliczka mnożenia
            for(int x=1; x <= 10; x++)
            {
                for(int y=1; y <= 10; y++)
                {
                    Console.Write("{0,3} ", x*y);

                }
                Console.Write("\n");                
            }
            */


            /* NWD - ćwiczenie 1
            int n, m, diff;

            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj m:");
            m = Convert.ToInt32(Console.ReadLine());

            do
            {
                diff = Math.Abs(n - m);

                if(n > m)
                {
                    n = diff;
                }
                else
                {
                    m = diff;
                }
            }
            while (diff != 0);

            Console.WriteLine("NWD: {0}", n);
            */

            /* APROX SQRT - ćwiczenie 2
            const double epsilon = 0.00001;
            double a, x = 1;

            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
                throw new Exception("a nie może być ujemne");
            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }

            Console.WriteLine("Wartością (przybliżoną) pierwiastka kwadratowego liczby {0} jest {1} (sqrt = {2})." ,a, x, Math.Sqrt(a));            */

            /*  suma iloczyn - ćwiczenie 3
            long n,k;
            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj k:");
            k = Convert.ToInt32(Console.ReadLine());

            long suma = 0, iloczyn = 1;
            for(int i=1; i<=n; i++)
            {
                suma += i*k;
                iloczyn *= i*k;

            }

            Console.WriteLine("Suma {0} liczb podzielnch przez {1} wynosi {2}", n, k, suma);
            Console.WriteLine("Iloczyn {0} liczb podzielnch przez {1} wynosi {2}", n, k, iloczyn);
            */


            Random rand = new Random();
            int n = rand.Next(0, 200 + 1);
            //while ()
            //{


            //}





            Console.ReadKey();
        }
    }
}

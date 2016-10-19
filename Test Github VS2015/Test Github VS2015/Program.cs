using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Github_VS2015
{
    class Program
    {
        private static Int32 test(Int32 a)
        {
            return a + a;
        }

        static void Main(string[] args)
        {

            //Console.WriteLine(test(3));

            double r = 3.23;
            double pole = Math.PI * r * r;

            Console.WriteLine("format wyswietlania {0} {1:f3}", r, pole);

            Console.WriteLine("Nazywasz się {1} masz {0} lat(a)", 22, "Asia");

            /*
             *  { numer_zmiennej : format wyświetlania }
             */

            //Console.ReadKey();
            //return;

            //double r;
            /*
            string linia;

            linia = Console.ReadLine();

            int a = Convert.ToInt32(linia) + 2;

            Console.WriteLine(a);

            r = Convert.ToDouble(Console.ReadLine());

            string read = Console.ReadLine();
            double r = Convert.ToDouble(read);
            */

            /*
                
            Console.Write("Podaj długość promienia: ");
            r = Convert.ToDouble(Console.ReadLine());

            double pole = Math.PI * r * r;
            double obwod = 2 * Math.PI * r;

            Console.WriteLine("Pole koła o promieniu {0} wynosi: {1:f3}.", r, pole);

            Console.WriteLine("Obwód koła o promieniu {0} wynosi: {1:f3}.", r, obwod);
            Console.ReadKey();
            */

            //Console.WriteLine("Hello world!");
            //Console.ReadKey();
            Console.ReadKey();
            return;
        }
    }
}

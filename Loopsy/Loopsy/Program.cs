using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ------------------------------------------
             * 
             * PĘTLA WHILE C#
             * 
             * instrkcja; // inicjowanie
             * while(warunek)
             * {
             *      instrukcja_w_petli;
             * }
             * 
             * ------------------------------------------
             * 
             * PĘTLA FOR C#
             * 
             * instrukcja;
             * for(inicjowanie; warunek; inkrementacja)
             * {
             *      instrukcja_w_petli;
             * }
             * 
             * ------------------------------------------
             * 
             * PĘTLA DO WHILE C#
             * 
             * instrkcja; // inicjowanie
             * do
             * {
             *      instrukcja_w_petli;
             * }
             * while(warunek);
             * 
             * ------------------------------------------
             * 
             */

            while(true)
            {
                for(;;)
                {
                    while(true)
                    {
                        goto Etykieta;
                    }
                }
            }
            Etykieta:

            // ----

            while(true)
            {
                if (Math.PI > 3.14)
                {
                    break;
                }
            }


            char c;
            c = Console.ReadKey(true).KeyChar;
            

            Console.ReadKey(false);
        }
    }
}

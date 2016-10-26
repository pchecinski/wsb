using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ------------------------------------------
             * SWITCH C#
             * 
             */

            for (;
                
                ;)

                break;

            ;

            char a = '\0';
            switch(a)
            {
                case 'a':
                    goto case 'A';

                case 'A':
                    Console.WriteLine("A/a");
                    break;

                case 'b':
                case 'B':
                    Console.WriteLine("B/b");
                    goto default;

                default:
                    Console.WriteLine("Inne");
                    break;

            }
        }
    }
}

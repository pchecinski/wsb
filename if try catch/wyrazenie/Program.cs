﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyrazenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0;

            Console.Write("Podaj x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj y: ");
            y = Convert.ToDouble(Console.ReadLine());


            if (x < 0 && y < 0)
            {
                z = x * y;
            }
            else if (x == 0 || y == 0)
            {
                z = 10;
            }
            else
            {
                z = x + y;
            }

            Console.WriteLine("x = {0}\ny = {1}\nz = {2}", x, y, z);
            Console.ReadKey();
        }
    }
}

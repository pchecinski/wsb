using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestLab4 {
    class Program {

        static ConsoleKeyInfo lastKey;

        static void KeyReader () {

            while (true) {
                if (Console.KeyAvailable) {
                    lastKey = Console.ReadKey(true);
                }
            }

        }
            
        static void Main(string[] args) {

            Thread oThread = new Thread(new ThreadStart(KeyReader));

            Console.CursorVisible = false;
            oThread.Start();

            while (!oThread.IsAlive) ;

            while (true) {

                Console.SetCursorPosition(0, 0);
                Console.Write(lastKey.KeyChar);
                Thread.Sleep(50);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6task2 {
    class Program {

        // Wypisanie macierzy
        static void mwrite(int columns, int rows, double[,] matrix) {
            Console.WriteLine("{0} {1}", columns, rows);

            for (int c = 0; c != columns; c++) {
                for(int r = 0; r != rows; r++) {
                    Console.Write("{0,8:F2}", matrix[c,r]);
                }
                Console.WriteLine();
            }
        }

        // Odczyt macierzy
        static double [,] mread(int columns, int rows) {
            double [,] matrix = new double[columns, rows];

            for (int c = 0; c != columns; c++) {
                for (int r = 0; r != rows; r++) {
                    Double.TryParse(Console.ReadLine(), out matrix[c,r]);
                }
            }

            return matrix;
        }

        static void Main(string[] args) {

            int columns = 3;
            int rows = 2;
            double[,] macierz = new double[columns, rows];

            string argumenty = "a b 12 345.32 kabaczek";
            string[] tablica_arg = argumenty.Split(' ');
            

            Console.WriteLine(tablica_arg.Length);

            foreach (string s in tablica_arg) {
                Console.WriteLine(s);
            }

            //String[] substrings = Console.ReadLine().Split(' ');


            Console.ReadLine(); // 2
            Console.ReadLine(); // 2 3

            mread(columns, rows);
            mwrite(columns, rows, macierz);
            /*
                Ćwiczenie 2
                Utwórz programu, który oblicza iloczyn dwóch macierzy. Wartości elementów
                macierzy są podawane przez użytkownika. 
            */
            

            /*            double[][] macierz; // dobrze, ale bez sensu
                        macierz = new double[columns][];
                        for(int c = 0; c != columns; c++) {
                            macierz[c] = new double[rows];
                        }
                */

            // TODO not done



            //mwrite()
            //Console.WriteLine(dupa(123));

            Console.ReadKey();


            /*static int dupa(int i) {
                return 2 * i;
            }*/

            int macierze = 2;
            // Int32.TryParse(Console.ReadLine(), out macierze); // wczytanie ilości macierzy


            int wierszeA = 3, kolumnyA = 2;
            double[,] macierzA = new double[wierszeA, kolumnyA];


            for (int x=0; x != wierszeA; x++) {
                for(int y=0; y != kolumnyA; y++) {
                    
                }
            }

            //            Console.ReadLine().Split(); ZROBIĘ TO ALL W OGÓLE PÓŹNIEJ :_;

            /*

                int matrices = 0;
                fscanf(stdin, "%d", &matrices);

                int R=0, C=0;
                fscanf(stdin, "%d %d", &R, &C);
                double **result = mread(stdin, &R, &C);

                while(matrices>1) {
                    int nextR=0, nextC=0;
                    fscanf(stdin, "%d %d", &nextR, &nextC);
                    double **next = mread(stdin, &nextR, &nextC);

                    result = mmult(R,C,result,nextR,nextC,next);
                    xfree(nextR,nextC,next);
                    C=nextC;

                    matrices--;
                }

                mwrite(stdout,R,C,result);
                xfree(R,C,result);
                */



        }
    }
}

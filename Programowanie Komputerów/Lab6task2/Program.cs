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

        // Wczytanie macierzy
        static double[,] mread(int columns, int rows) {
            double[,] matrix = new double[columns, rows];
            int index = 0, size = columns * rows;

            while (true) {
                foreach (String input in Console.ReadLine().Split(' ')) {
                    if (Double.TryParse(input, out matrix[index / rows, index % rows])) {
                        if (++index == size) { 
                            return matrix;
                        }
                    }
                }

            }
            
        }

        // Mnożenie macierzy
        static double[,] mmult(double[,] matrixA, double[,] matrixB, int rowA, int colA, int rowB, int colB) {
            double[,] result = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int r1 = 0; r1 != rowA; r1++) {
                for (int c2 = 0; c2 != colB; c2++) {
                    for (int r2 = 0; r2 != rowB; r2++) {
                        result[r1, c2] += matrixA[r1, r2] * matrixB[r2, c2];
                    }
                }
            }

            return result;
        }

        static void Main(string[] args) {
            /*
                Ćwiczenie 2
                Utwórz programu, który oblicza iloczyn dwóch macierzy. Wartości elementów
                macierzy są podawane przez użytkownika. 
            */

            // Ustawienia regionale danych wejściowych
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = "."; // Dane wejściowe mają format 0.45 zamiast 0,45
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Wczytanie ilości macierzy (INT)
            int macierze = int.Parse(Console.ReadLine());

            // Wczytanie rozmiaru pierwszej macierzy (INT wiersze <spacja> INT kolumny)
            String[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int columns = int.Parse(input[1]);

            // Wczytanie macierzy
            double[,] wynik = new double[rows, columns];
            wynik = mread(rows, columns);
           
            // Wymnażanie macieży dla ilości powyżej 1
            while (macierze > 1) {

                // Wczytanie rozmiaru pierwszej macierzy (INT wiersze <spacja> INT kolumny)
                String[] next_input = Console.ReadLine().Split();
                int next_rows = int.Parse(next_input[0]);
                int next_columns = int.Parse(next_input[1]);

                // Wczytanie macierzy
                double[,] next = new double[next_rows, next_columns];
                next = mread(next_rows, next_columns);

                // Mnożenie
                wynik = mmult(wynik, next, rows, columns, next_rows, next_columns);
                columns = next_columns;          
                
                macierze--;
            }

            // Wypisanie wyniku na ekran
            mwrite(rows, columns, wynik);
        }
    }
}
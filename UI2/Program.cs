using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace UI2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 1, 1, 10 };
            matrix[2] = new int[] { 2, 2, 2 };
            matrix[1] = new int[] { 3, 3, 3, 3 };
            matrix[3] = new int[] { 4, 4, 5 };

            Console.WriteLine("Массив до сортировки:");
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    Console.Write("{0, 4:D}", matrix[i][j]);
                }
                Console.WriteLine();
            }

            SortMatrixWithModes.SortMatrix(matrix, 'a', true);

            Console.WriteLine("Массив после сортировки:");
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    Console.Write("{0, 4:D}", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

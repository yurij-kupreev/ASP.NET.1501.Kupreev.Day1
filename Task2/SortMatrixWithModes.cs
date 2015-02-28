using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SortMatrixWithModes
    {
        private static int[] massive;
        private static bool bincrease;
        public static void SortMatrix(int[][] matrix, char mode, bool increase)
        {
            bincrease = increase;
            if (mode == 'a') SortAMode(matrix);
            else if (mode == 'b') SortBMode(matrix);
            else if (mode == 'c') SortCMode(matrix);
            else throw new ArgumentException();
        }

        private static void SortAMode(int[][] matrix)
        {
            massive = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    massive[i] += matrix[i][j];
                }
            }
            BubbleSort(matrix);
        }

        private static void SortBMode(int[][] matrix)
        {
            massive = new int[matrix.Length];
            int min;
            for (int i = 0; i < matrix.Length; ++i)
            {
                min = matrix[i][0];
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    if (matrix[i][j] < min) min = matrix[i][j];
                }
                massive[i] = min;
            }
            BubbleSort(matrix);
        }
        private static void SortCMode(int[][] matrix)
        {
            massive = new int[matrix.Length];
            int max;
            for (int i = 0; i < matrix.Length; ++i)
            {
                max = matrix[i][0];
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    if (matrix[i][j] > max) max = matrix[i][j];
                }
                massive[i] = max;
            }
            BubbleSort(matrix);
        }

        private static void BubbleSort(int[][] matrix)
        {
            int buffer;
            int[] matrixBuffer;
            for (int i = 0; i < massive.Length; ++i)
            {
                for (int j = i + 1; j < massive.Length; ++j)
                {
                    if ((massive[i] > massive[j] && bincrease) || (massive[i] < massive[j] && !bincrease))
                    {
                        buffer = massive[i];
                        massive[i] = massive[j];
                        massive[j] = buffer;
                        matrixBuffer = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = matrixBuffer;
                    } 
                }                
            }
        }
    }
}

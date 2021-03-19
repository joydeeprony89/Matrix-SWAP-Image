using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_SWAP_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            Rotate(matrix);
            foreach(var line in matrix)
                Console.WriteLine(string.Join(",", line));
        }

        static void Rotate(int[][] matrix)
        {
            int N = matrix.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (N / 2); j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][N - 1 - j];
                    matrix[i][N - 1 - j] = temp;
                }
            }
        }
    }
}

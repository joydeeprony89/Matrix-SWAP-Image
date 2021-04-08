using System;

namespace Matrix_SWAP_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[4][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } };
            Rotate(matrix);
            foreach(var line in matrix)
                Console.WriteLine(string.Join(",", line));
        }

        static void Rotate(int[][] matrix)
        {
            int N = matrix.Length;
            // transform
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // swap columns
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < (N / 2); j++)
            //    {
            //        int temp = matrix[i][j];
            //        matrix[i][j] = matrix[i][N - 1 - j];
            //        matrix[i][N - 1 - j] = temp;
            //    }
            //}

            for(int  i = 0; i < N; i++)
            {
                int m = 0, n = N - 1;
                while(m < n)
                {
                    int temp = matrix[i][m];
                    matrix[i][m] = matrix[i][n];
                    matrix[i][n] = temp;
                    m++; n--;
                }
            }
        }
    }
}

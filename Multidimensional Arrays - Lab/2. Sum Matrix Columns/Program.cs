using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] infoAboutMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);
            SumMatrix(matrix);
        }

        private static void SumMatrix(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}

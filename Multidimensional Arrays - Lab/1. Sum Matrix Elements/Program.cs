using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoAboutMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;

            FillMatrix(rows, cols, matrix);
            sum = SumMatrix(rows, cols, matrix, sum);
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        private static int SumMatrix(int rows, int cols, int[,] matrix, int sum)
        {
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}

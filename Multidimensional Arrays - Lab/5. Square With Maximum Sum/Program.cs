using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoAboutMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            int[,] matrix = new int[rows, cols];

            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            FillMatrix(rows, cols, matrix);

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int curSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        maxCol = col;
                        maxRow = row;
                    }
                }
            }
            for (int i = maxRow; i < maxRow + 2; i++)
            {
                for (int j = maxCol; j < maxCol + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);

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

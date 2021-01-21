using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] infoAboutMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            char[,] matrix = new char[rows, cols];

            int count = 0;

            FillMatrix(rows, cols, matrix);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1]
                        && matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j]
                        )

                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void FillMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}


using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];


            FillMatrix(n, matrix);

            string[] bombs = Console.ReadLine().Split().ToArray();

            int sum = 0;
            int countAlive = 0;
            for (int i = 0; i < bombs.Length; i++)
            {
                string[] current = bombs[i].Split(",").ToArray();
                int row = int.Parse(current[0]);
                int col = int.Parse(current[1]);

                if (IsValid(matrix, row, col))
                {
                    int bombValue = matrix[row, col];

                    if (bombValue <= 0)
                    {
                        break;
                    }

                    // left above the bomb
                    if (IsValid(matrix, row - 1, col - 1)
                        && (matrix[row - 1, col - 1] > 0))
                    {
                        matrix[row - 1, col - 1] -= bombValue;

                    }
                    // above the bomb
                    if (IsValid(matrix, row - 1, col)
                        && (matrix[row - 1, col] > 0))
                    {

                        matrix[row - 1, col] -= bombValue;
                    }
                    // right above the bomb
                    if (IsValid(matrix, row - 1, col + 1)
                        && (matrix[row - 1, col + 1] > 0))
                    {

                        matrix[row - 1, col + 1] -= bombValue;
                    }
                    // on the left of the bomb
                    if (IsValid(matrix, row, col - 1)
                        && (matrix[row, col - 1] > 0))
                    {
                        matrix[row, col - 1] -= bombValue;
                    }


                    // on the right of the bomb
                    if (IsValid(matrix, row, col + 1)
                        && (matrix[row, col + 1] > 0))
                    {
                        matrix[row, col + 1] -= bombValue;
                    }
                    // on the left under the bomb
                    if (IsValid(matrix, row + 1, col - 1)
                        && (matrix[row + 1, col - 1] > 0))
                    {
                        matrix[row + 1, col - 1] -= bombValue;
                    }
                    // under the bomb
                    if (IsValid(matrix, row + 1, col)
                        && (matrix[row + 1, col] > 0))
                    {
                        matrix[row + 1, col] -= bombValue;
                    }
                    // on the right under the bomb
                    if (IsValid(matrix, row + 1, col + 1)
                        && (matrix[row + 1, col + 1] > 0))
                    {

                        matrix[row + 1, col + 1] -= bombValue;
                    }

                    //on the bomb
                    matrix[row, col] = 0;
                }
               
            }
            countAlive = CountAlive(n, matrix, countAlive);
            Console.WriteLine($"Alive cells: { countAlive}");
            sum = SumMatrix(n, matrix, sum);
            Console.WriteLine($"Sum: {Math.Abs(sum)}");

            PrintMatrix(n, matrix);

        }

        private static int CountAlive(int n, int[,] matrix, int countAlive)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        countAlive++;

                    }

                }

            }

            return countAlive;
        }

        private static int SumMatrix(int n, int[,] matrix, int sum)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {

                        sum += matrix[row, col];
                    }

                }

            }

            return sum;
        }

        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
        private static bool IsValid(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(0);
        }
    }
}

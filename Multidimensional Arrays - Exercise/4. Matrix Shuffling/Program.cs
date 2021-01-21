using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoAboutMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            string[,] matrix = new string[rows, cols];

            FillMatrix(rows, cols, matrix);

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                if (IsValid(matrix, command))
                {

                    string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];

                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];

                    matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(string[,] matrix, string[] command)
        {
            if (command[0] == "swap" && command.Length == 5
                && int.Parse(command[1]) <= matrix.GetLength(0)
                && int.Parse(command[2]) >= 0
                && int.Parse(command[3]) <= matrix.GetLength(0)
               && int.Parse(command[4]) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}

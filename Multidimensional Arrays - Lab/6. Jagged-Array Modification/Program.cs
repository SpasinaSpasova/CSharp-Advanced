using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            FillMatrix(n, matrix);

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row < n &&
                    col >= 0 && col < n)
                {

                    if (command[0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }


                command = Console.ReadLine().Split();
            }

            PrintMatrix(n, matrix);
        }

        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
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
    }
}

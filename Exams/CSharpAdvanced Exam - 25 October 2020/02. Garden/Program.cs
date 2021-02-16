using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = data[0];
            int m = data[1];
            Queue<int> rowsAndCols = new Queue<int>();
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                string[] position = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int row = int.Parse(position[0]);
                int col = int.Parse(position[1]);

                if (!IsPositionValid(row, col, n, m))
                {
                    Console.WriteLine("Invalid coordinates.");
                    command = Console.ReadLine();
                    continue;
                }
                rowsAndCols.Enqueue(row);
                rowsAndCols.Enqueue(col);
                matrix[row, col]++;

                command = Console.ReadLine();
            }

            while (rowsAndCols.Count > 0)
            {
                int currentRow = rowsAndCols.Dequeue();
                int currentCol = rowsAndCols.Dequeue();

                for (int j = 0; j < n; j++)
                {
                    if (currentCol != j)
                    {
                        matrix[currentRow, j]++;

                    }
                }

                for (int j = 0; j < m; j++)
                {
                    if (currentRow != j)
                    {
                        matrix[j, currentCol]++;

                    }
                }

            }


            Print(matrix);
        }
        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
        private static void Print(int[,] matrix)
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
    }
}

using System;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sum = 0;

            FillMatrix(n, matrix);

            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
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

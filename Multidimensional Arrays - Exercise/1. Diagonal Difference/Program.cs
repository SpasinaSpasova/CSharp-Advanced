using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int primarySum = 0;
            int secondarySum = 0;

            FillMatrix(n, matrix);

            for (int i = 0; i < n; i++)
            {
                primarySum += matrix[i, i];
            }

            for (int row = 0; row < n; row++)
            {
                int col = n - 1;
                secondarySum += matrix[row, col - row];

            }



            Console.WriteLine(Math.Abs(primarySum - secondarySum));


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

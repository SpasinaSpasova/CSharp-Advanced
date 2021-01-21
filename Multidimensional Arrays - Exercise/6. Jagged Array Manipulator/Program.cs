using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[rows][];
           
            FillJaggedMatrix(rows, jaggedMatrix);

            //analyzing
            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    MultiplyEqualLength(jaggedMatrix, row);
                }
                else
                {
                    DivideLength(jaggedMatrix, row);

                }
            }

            while (true) // check for valid commands
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    PrintJaggedMatrix(jaggedMatrix);
                    break;
                }
                string[] arg = command.Split().ToArray();

                string currentCommand = arg[0];
                int row = int.Parse(arg[1]);
                int col = int.Parse(arg[2]);
                int value = int.Parse(arg[3]);

                if (row <= rows - 1 && row >= 0 && col >= 0 && col <= jaggedMatrix[row].Length - 1)
                {

                    if (currentCommand == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (currentCommand == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;

                    }
                }

            }
        }

        private static void DivideLength(double[][] jaggedMatrix, int row)
        {
            for (int i = 0; i < jaggedMatrix[row].Length; i++)
            {
                jaggedMatrix[row][i] = jaggedMatrix[row][i] / 2;
            }

            for (int i = 0; i < jaggedMatrix[row + 1].Length; i++)
            {
                jaggedMatrix[row + 1][i] = jaggedMatrix[row + 1][i] / 2;
            }
        }

        private static void MultiplyEqualLength(double[][] jaggedMatrix, int row)
        {
            for (int j = 0; j < jaggedMatrix[row].Length; j++)
            {
                jaggedMatrix[row][j] = jaggedMatrix[row][j] * 2;
                jaggedMatrix[row + 1][j] = jaggedMatrix[row + 1][j] * 2;
            }
        }

        private static void FillJaggedMatrix(int rows, double[][] jaggedMatrix)
        {
            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[i] = new double[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {

                    jaggedMatrix[i][j] = numbers[j];
                }
            }
        }

        private static void PrintJaggedMatrix(double[][] jaggedMatrix)
        {
            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

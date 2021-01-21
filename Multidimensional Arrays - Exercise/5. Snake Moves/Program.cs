using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoAboutMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = infoAboutMatrix[0];
            int cols = infoAboutMatrix[1];

            char[,] snakeMatrix = new char[rows, cols];

            string snakeName = Console.ReadLine();
            int currentLetter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < cols; col++)
                    {

                        snakeMatrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }


                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        snakeMatrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }

                }


            }
            PrintSnakeMatrix(rows, cols, snakeMatrix);
        }

        private static void PrintSnakeMatrix(int rows, int cols, char[,] snakeMatrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(snakeMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

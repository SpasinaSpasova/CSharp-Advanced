using System;
using System.Collections.Generic;
using System.Linq;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToList();
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                matrix[playerCol, playerCol] = '-';
                playerRow = MoveRow(playerRow, command);
                playerCol = MoveCol(playerCol, command);

                if (IsPositionValid(playerRow, playerCol, n, n))
                {
                    if (char.IsLetter(matrix[playerRow, playerCol]))
                    {
                        text.Add(matrix[playerRow, playerCol]);
                        matrix[playerRow, playerCol] = '-';
                    }
                }
                else
                {
                    if (text.Count > 0)
                    {
                        text.RemoveAt(text.Count - 1);

                    }

                    if (command == "up")
                    {
                        playerRow++;
                    }
                    else if (command == "down")
                    {
                        playerRow--;
                    }
                    else if (command == "left")
                    {
                        playerCol++; ;
                    }
                    else if (command == "right")
                    {
                        playerCol--;
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("",text));
            matrix[playerRow, playerCol] = 'P';

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
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

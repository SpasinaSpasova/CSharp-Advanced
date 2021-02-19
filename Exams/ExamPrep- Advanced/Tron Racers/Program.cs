using System;
using System.Linq;

namespace Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int firstRow = -1;
            int firstCol = -1;

            int secondRow = -1;
            int secondCol = -1;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        firstRow = row;
                        firstCol = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondRow = row;
                        secondCol = col;
                    }


                }

            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string firstMovement = commands[0];
                string secondMovement = commands[1];

                //firstMove
                firstRow = MoveRow(firstRow, firstMovement);
                firstCol = MoveCol(firstCol, firstMovement);
                if (IsPositionValid(firstRow,firstCol,n,n))
                {
                    if (matrix[firstRow,firstCol]=='*')
                    {
                        matrix[firstRow, firstCol] = 'f';
                    }
                    else if (matrix[firstRow, firstCol] == 's')
                    {
                        matrix[firstRow, firstCol] = 'x';
                            break;
                    }
                }
                else
                {
                    ForNonValidPos(n, ref firstRow, ref firstCol, firstMovement);
                }
                //second

                secondRow = MoveRow(secondRow, secondMovement);
                secondCol = MoveCol(secondCol, secondMovement);
                if (IsPositionValid(secondRow, secondCol, n, n))
                {
                    if (matrix[secondRow, secondCol] == '*')
                    {
                        matrix[secondRow, secondCol] = 's';
                    }
                    else if (matrix[secondRow, secondCol] == 'f')
                    {
                        matrix[secondRow, secondCol] = 'x';
                        break;
                    }
                }
                else
                {
                    ForNonValidPos(n, ref secondRow, ref secondCol, secondMovement);
                }


            }


            Print(matrix);
        }

        private static void ForNonValidPos(int n, ref int firstRow, ref int firstCol, string firstMovement)
        {
            if (firstMovement == "up")
            {
                firstRow = n - 1;
            }
            else if (firstMovement == "down")
            {
                firstRow = 0;
            }
            else if (firstMovement == "right")
            {
                firstCol = 0;
            }
            else if (firstMovement == "left")
            {
                firstCol = n - 1;
            }
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

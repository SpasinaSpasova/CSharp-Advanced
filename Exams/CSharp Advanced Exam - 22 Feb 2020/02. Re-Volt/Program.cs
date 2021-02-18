using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numOfCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }



            for (int i = 1; i <= numOfCommands; i++)
            {
                string movement = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';

                playerRow = MoveRow(playerRow, movement);
                playerCol = MoveCol(playerCol, movement);

                if (IsPositionValid(playerRow, playerCol, n, n))
                {
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        Print(matrix);
                        return;
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        MethodForT(ref playerRow, ref playerCol, movement);
                        matrix[playerRow, playerCol] = 'f';


                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        //!!!!!
                        if (movement == "down")
                        {
                            playerRow++;
                            if (!IsPositionValid(playerRow, playerCol, n, n))
                            {
                                NonValid(n, ref playerRow, ref playerCol, movement);
                            }
                        }
                        else if (movement == "up")
                        {
                            playerRow--;
                            if (!IsPositionValid(playerRow, playerCol, n, n))
                            {
                                NonValid(n, ref playerRow, ref playerCol, movement);
                            }

                        }
                        else if (movement == "right")
                        {
                            playerCol++;
                            if (!IsPositionValid(playerRow, playerCol, n, n))
                            {
                                NonValid(n, ref playerRow, ref playerCol, movement);
                            }

                        }
                        else if (movement == "left")
                        {
                            playerCol--;
                            if (!IsPositionValid(playerRow, playerCol, n, n))
                            {

                                NonValid(n, ref playerRow, ref playerCol, movement);
                            }

                        }


                    }
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        Print(matrix);
                        return;
                    }
                    matrix[playerRow, playerCol] = 'f';

                }
                else
                {
                    NonValid(n, ref playerRow, ref playerCol, movement);
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        Print(matrix);
                        return;
                    }

                    matrix[playerRow, playerCol] = 'f';


                }



            }
            Console.WriteLine("Player lost!");
            Print(matrix);

        }

        private static void MethodForT(ref int playerRow, ref int playerCol, string movement)
        {
            if (movement == "down")
            {
                playerRow--;

            }
            else if (movement == "up")
            {
                playerRow++;

            }
            else if (movement == "right")
            {
                playerCol--;

            }
            else if (movement == "left")
            {
                playerCol++;

            }
        }

        private static void NonValid(int n, ref int playerRow, ref int playerCol, string movement)
        {
            if (movement == "up")
            {
                playerRow = n - 1;
            }
            else if (movement == "down")
            {
                playerRow = 0;

            }
            else if (movement == "left")
            {

                playerCol = n - 1;
            }
            else if (movement == "right")
            {
                playerCol = 0;
            }
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
    }
}

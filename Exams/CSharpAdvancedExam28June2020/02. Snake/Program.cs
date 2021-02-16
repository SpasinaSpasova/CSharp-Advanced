using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];


            int snakeRow = -1;
            int snakeCol = -1;

            int firstBurrowRow = -1;
            int firstBurrowCol = -1;

            int secondBurrowRow = -1;
            int secondBurrowCol = -1;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (matrix[row, col] == 'B' && firstBurrowRow == -1)
                    {
                        firstBurrowRow = row;
                        firstBurrowCol = col;
                    }

                    if (matrix[row, col] == 'B' && firstBurrowRow != -1)
                    {
                        secondBurrowRow = row;
                        secondBurrowCol = col;
                    }
                }
            }
            int food = 0;

            while (true)
            {
                string command = Console.ReadLine();

                matrix[snakeRow, snakeCol] = '.';



                snakeRow = MoveRow(snakeRow, command);
                snakeCol = MoveCol(snakeCol, command);

                if (!IsPositionValid(snakeRow, snakeCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {food}");
                    Print(matrix);

                    return;
                }


                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food++;
                }
                if (food == 10)
                {
                    matrix[snakeRow, snakeCol] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {food}");
                    Print(matrix);

                    return;
                }
                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';

                    if (snakeRow == firstBurrowRow)
                    {
                        snakeRow = secondBurrowRow;
                        snakeCol = secondBurrowCol;
                    }
                    else if (snakeRow == secondBurrowRow)
                    {
                        snakeRow = firstBurrowRow;
                        snakeCol = firstBurrowCol;
                    }

                }
                matrix[snakeRow, snakeCol] = 'S';


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

    }
}

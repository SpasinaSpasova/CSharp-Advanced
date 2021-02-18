using System;

namespace _02._Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int sellerRow = -1;
            int sellerCol = -1;


            int firstPillarRow = -1;
            int firstPillarCol = -1;

            int secondPillarRow = -1;
            int secondPillarCol = -1;

            int money = 0;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        sellerRow = row;
                        sellerCol = col;
                    }

                    if (matrix[row, col] == 'O' && firstPillarRow == -1)
                    {
                        firstPillarRow = row;
                        firstPillarCol = col;
                    }
                   if(matrix[row, col] == 'O' && firstPillarRow != -1)
                    {
                        secondPillarRow = row;
                        secondPillarCol = col;
                    }

                }
            }

            while (true)
            {
                string movement = Console.ReadLine();

                matrix[sellerRow, sellerCol] = '-';

                sellerRow = MoveRow(sellerRow, movement);
                sellerCol = MoveCol(sellerCol, movement);

                if (IsPositionValid(sellerRow, sellerCol, n, n))
                {
                    char current = matrix[sellerRow, sellerCol];

                    if (char.IsDigit(current))
                    {
                        money += int.Parse(current.ToString());

                        matrix[sellerRow, sellerCol] = 'S';
                        if (money >= 50)
                        {
                            Console.WriteLine("Good news! You succeeded in collecting enough money!");
                            Console.WriteLine($"Money: {money}");
                            Print(matrix);
                            return;
                        }

                    }
                    else if (current == 'O' && sellerRow == firstPillarRow)
                    {
                        matrix[sellerRow, sellerCol] = '-';
                        sellerRow = secondPillarRow;
                        sellerCol = secondPillarCol;
                        matrix[sellerRow, sellerCol] = 'S';

                    }
                    else if (current == 'O' && sellerRow == secondPillarRow)
                    {
                        matrix[sellerRow, sellerCol] = '-';
                        sellerRow = firstPillarRow;
                        sellerCol = firstPillarCol;
                        matrix[sellerRow, sellerCol] = 'S';

                    }
                    else
                    {
                        matrix[sellerRow, sellerCol] = 'S';

                    }


                }
                else
                {

                    Console.WriteLine("Bad news, you are out of the bakery.");
                    Console.WriteLine($"Money: {money}");
                    Print(matrix);
                    return;
                }

            }

        }

        public static void Print(char[,] matrix)
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

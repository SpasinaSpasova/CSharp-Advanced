using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentCount = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            int countAllKids = 0;
            int recieved = 0;

            int santaRow = -1;
            int santaCol = -1;
     

            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == "S")
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if (matrix[row, col] == "V")
                    {
                        countAllKids++;
                    }

                }
            }

            string command = Console.ReadLine();
            while (command != "Christmas morning")
            {
                matrix[santaRow, santaCol] = "-";
                santaRow = MoveRow(santaRow, command);
                santaCol = MoveCol(santaCol, command);

                if (matrix[santaRow, santaCol] == "X")
                {
                    matrix[santaRow, santaCol] = "S";

                }
                else if (matrix[santaRow, santaCol] == "-")
                {
                    matrix[santaRow, santaCol] = "S";

                }
                else if (matrix[santaRow, santaCol] == "V")
                {
                    recieved++;
                    presentCount--;
                    matrix[santaRow, santaCol] = "-";

                }
                else if (matrix[santaRow, santaCol] == "C")
                {

                    if (matrix[santaRow + 1, santaCol] != "-")

                    {
                        if (matrix[santaRow + 1, santaCol] == "V")
                        {
                            recieved++;

                        }
                        presentCount--;
                        matrix[santaRow + 1, santaCol] = "-";
                        if (presentCount <= 0)
                        {
                            matrix[santaRow, santaCol] = "S";

                            Console.WriteLine("Santa ran out of presents!");


                            break;
                        }
                    }
                    if (matrix[santaRow - 1, santaCol] != "-"
                       )
                    {
                        if (matrix[santaRow - 1, santaCol] == "V")
                        {
                            recieved++;

                        }
                        presentCount--;
                        matrix[santaRow - 1, santaCol] = "-";
                        if (presentCount <= 0)
                        {
                            matrix[santaRow, santaCol] = "S";

                            Console.WriteLine("Santa ran out of presents!");


                            break;
                        }
                    }
                    if (matrix[santaRow, santaCol + 1] != "-")
                    {
                        if (matrix[santaRow, santaCol + 1] == "V")
                        {

                            recieved++;
                        }
                        presentCount--;
                        matrix[santaRow, santaCol + 1] = "-";
                        if (presentCount <= 0)
                        {
                            matrix[santaRow, santaCol] = "S";

                            Console.WriteLine("Santa ran out of presents!");


                            break;
                        }
                    }
                    if (matrix[santaRow, santaCol - 1] != "-")
                    {
                        if (matrix[santaRow, santaCol - 1] == "V")
                        {
                            recieved++;

                        }
                        presentCount--;
                        matrix[santaRow, santaCol - 1] = "-";
                        if (presentCount <= 0)
                        {
                            matrix[santaRow, santaCol] = "S";

                            Console.WriteLine("Santa ran out of presents!");


                            break;
                        }
                    }
                }

                if (presentCount <= 0)
                {
                    matrix[santaRow, santaCol] = "S";

                    Console.WriteLine("Santa ran out of presents!");

                    break;
                }
                command = Console.ReadLine();
            }
            matrix[santaRow, santaCol] = "S";
            Print(matrix);

            if (countAllKids == recieved)
            {

                Console.WriteLine($"Good job, Santa! {countAllKids} happy nice kid/s.");
            }
            else if (countAllKids > recieved)
            {
                Console.WriteLine($"No presents for {countAllKids - recieved} nice kid/s.");
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
        private static void Print(string[,] matrix)
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

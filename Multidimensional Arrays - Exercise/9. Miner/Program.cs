using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            char[,] field = new char[sizeOfField, sizeOfField];

            string[] directions = Console.ReadLine().Split().ToArray();

            FillMatrix(field);
            bool findTheStart = false;
            bool flag = false;
            int allCoals = 0;
            int countCoal = 0;
            int currentRow = 0;
            int currentCol = 0;
            //find the start
            FindTheStartPosition(sizeOfField, field, ref findTheStart, ref currentRow, ref currentCol);

            //find count of all coals
            allCoals = AllCoals(sizeOfField, field, allCoals);

            for (int i = 0; i < directions.Length; i++)
            {
                string currentDirection = directions[i];

                if (currentDirection == "left"
                    && currentCol - 1 >= 0
                    && currentCol - 1 < sizeOfField)
                {

                    currentCol = currentCol - 1;

                }
                else if (currentDirection == "right"
                    && currentCol + 1 >= 0
                    && currentCol + 1 < sizeOfField)
                {

                    currentCol = currentCol + 1;

                }
                else if (currentDirection == "up"
                   && currentRow - 1 >= 0
                   && currentRow - 1 < sizeOfField)
                {
                    currentRow = currentRow - 1;

                }
                else if (currentDirection == "down"
                    && currentRow + 1 >= 0
                    && currentRow + 1 < sizeOfField)
                {
                    currentRow = currentRow + 1;

                }

                if (field[currentRow, currentCol] == 'c')
                {
                    countCoal++;
                    field[currentRow, currentCol] = '*';

                    if (countCoal == allCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        flag = true;
                        return;
                    }
                }
                else if (field[currentRow, currentCol] == 'e')
                {


                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    flag = true;
                    return;
                }

            }
            if (countCoal < allCoals && !flag)
            {
                Console.WriteLine($"{allCoals - countCoal} coals left. ({currentRow}, {currentCol})");
            }

        }

        private static void FindTheStartPosition(int sizeOfField, char[,] field, ref bool findTheStart, ref int currentRow, ref int currentCol)
        {
            for (int row = 0; row < sizeOfField; row++)
            {
                for (int col = 0; col < sizeOfField; col++)
                {
                    if (field[row, col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                        findTheStart = true;
                        break;
                    }
                }
                if (findTheStart)
                {
                    break;
                }

            }
        }

        private static int AllCoals(int sizeOfField, char[,] field, int allCoals)
        {
            for (int row = 0; row < sizeOfField; row++)
            {
                for (int col = 0; col < sizeOfField; col++)
                {
                    if (field[row, col] == 'c')
                    {
                        allCoals++;
                    }
                }

            }

            return allCoals;
        }

        private static void FillMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = data[col];
                }
            }
        }
    }
}

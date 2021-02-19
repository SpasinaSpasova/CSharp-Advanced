using System;
using System.Collections.Generic;
using System.Linq;

namespace Seashell_Treasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] beach = new char[rows][];

            Fill(rows, beach);

            string command = Console.ReadLine();

            int stollen = 0;
            List<char> seashells = new List<char>();

            while (command != "Sunset")
            {
                string[] tokens = command.Split().ToArray();

                string input = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (input == "Collect")
                {
                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= beach[row].Length - 1)
                    {
                        if (beach[row][col] == 'M'
                            || beach[row][col] == 'N'
                            || beach[row][col] == 'C')
                        {
                            seashells.Add(beach[row][col]);
                            beach[row][col] = '-';
                        }
                    }
                }
                else if (input == "Steal")
                {
                    string movement = tokens[3];

                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= beach[row].Length - 1)
                    {
                        if (beach[row][col] == 'M'
                            || beach[row][col] == 'N'
                            || beach[row][col] == 'C')
                        {
                            stollen++;
                            beach[row][col] = '-';
                        }
                    }

                    GullyMovement(ref row, ref col, movement);

                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= beach[row].Length - 1)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (beach[row][col] == 'M'
                           || beach[row][col] == 'N'
                           || beach[row][col] == 'C')
                            {
                                stollen++;
                                beach[row][col] = '-';
                            }

                            GullyMovement(ref row, ref col, movement);
                            if (!(row >= 0 && row <= rows - 1 && col >= 0 && col <= beach[row].Length - 1))
                            {
                                break ;
                            }
                        }
                    }

                }
                command = Console.ReadLine();
            }


            if (seashells.Count > 0)
            {
                Console.WriteLine($"Collected seashells: {seashells.Count} -> {string.Join(", ", seashells)}");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {seashells.Count}");
            }
            Console.WriteLine($"Stolen seashells: {stollen}");
            Print(rows, beach);
        }

        private static void GullyMovement(ref int row, ref int col, string movement)
        {
            if (movement == "up")
            {
                row--;
            }
            else if (movement == "down")
            {
                row++;
            }
            else if (movement == "left")
            {
                col--;
            }
            else if (movement == "right")
            {
                col++;
            }
        }

        private static void Fill(int rows, char[][] beach)
        {
            for (int i = 0; i < rows; i++)
            {
                beach[i] = Console.ReadLine().Split().Select(char.Parse).ToArray();
            }
        }

        private static void Print(int rows, char[][] beach)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }
        }
    }
}

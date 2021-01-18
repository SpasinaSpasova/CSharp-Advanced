using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(nums);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "add")
                {
                    int first = int.Parse(tokens[1]);
                    int second = int.Parse(tokens[2]);
                    numbers.Push(first);
                    numbers.Push(second);
                }
                else if (action == "remove")
                {
                    int len = int.Parse(tokens[1]);
                    if (len <= numbers.Count)
                    {


                        for (int i = 0; i < len; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: " + numbers.Sum());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numOfQueries; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0]=="1")
                {
                    int numToPush = int.Parse(input[1].ToString());
                    stack.Push(numToPush);
                }
                else if (input[0] == "2")
                {
                    if (stack.Count>0)
                    {
                        stack.Pop();
                    }
                }
                else if (input[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (input[0] == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }

            }
            if (stack.Count > 0)
            {

                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}

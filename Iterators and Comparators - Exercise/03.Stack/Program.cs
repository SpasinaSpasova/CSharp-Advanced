using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] tokens = input.Split(new string[] {" ", ", " },StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = tokens[0];

                if (command=="Push")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        int current = int.Parse(tokens[i]);
                        myStack.Push(current);
                    }

                }
                else if(command=="Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

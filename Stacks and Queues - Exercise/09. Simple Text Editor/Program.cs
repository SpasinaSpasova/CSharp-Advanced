using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFOperation = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();

            string result = string.Empty;

            for (int i = 0; i < numOFOperation; i++)
            {
                string[] arg = Console.ReadLine().Split().ToArray();
                string command = arg[0];

                if (command == "1")
                {
                    stack.Push(result);
                    string something = arg[1];
                    result += something;
                }
                else if (command == "2")
                {
                    int count = int.Parse(arg[1]);
                    stack.Push(result);

                    result = result.Substring(0, result.Length - count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(arg[1]);
                    Console.WriteLine(result[index - 1]);


                }
                else if (command == "4")
                {
                    result=stack.Pop();
                }

            }
        }
    }
}

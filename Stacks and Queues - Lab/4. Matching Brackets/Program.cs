using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            string expression = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int index = indexes.Pop();
                    Console.WriteLine(expression.Substring(index,i-index+1));
                }


            }
        }
    }
}

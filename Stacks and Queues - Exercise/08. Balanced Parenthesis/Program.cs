using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            Stack<char> openParenthesis = new Stack<char>();
            bool isBalanced = false;
            for (int i = 0; i < sequence.Length; i++)
            {

                if (sequence[i] == '('
                    || sequence[i] == '['
                    || sequence[i] == '{')
                {
                    openParenthesis.Push(sequence[i]);
                }
                else
                {
                    if (sequence[i] == '}' && openParenthesis.Any() && openParenthesis.Pop() == '{')
                    {
                        isBalanced = true;
                    }
                    else if (sequence[i] == ')' && openParenthesis.Any() && openParenthesis.Pop() == '(')
                    {
                        isBalanced = true;

                    }
                    else if (sequence[i] == ']' && openParenthesis.Any() && openParenthesis.Pop() == '[')
                    {
                        isBalanced = true;

                    }
                    else
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");
                        break;

                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}


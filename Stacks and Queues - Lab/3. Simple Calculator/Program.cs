using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> nums = new Stack<string>(expression);

            while (nums.Count>1)
            {
                int first = int.Parse(nums.Pop());
                string sign = nums.Pop();
                int second = int.Parse(nums.Pop());

                if (sign=="+")
                {
                    nums.Push((first + second).ToString());
                }
                else if (sign == "-")
                {
                    nums.Push((first - second).ToString());

                }
            }
            Console.WriteLine(nums.Pop());

        }
    }
}

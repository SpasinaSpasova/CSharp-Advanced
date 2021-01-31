using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int start = numbers[0];
            int end = numbers[1];
            string command = Console.ReadLine();

            Func<int, bool> predicate = n => true;

            List<int> newOne = new List<int>();


            for (int i = start; i <= end; i++)
            {
                if (command == "odd")
                {
                    predicate = i => i % 2 != 0;

                }
                else
                {
                    predicate = i => i % 2 == 0;
                 
                }

                if (predicate(i))
                {
                    newOne.Add(i);

                }

            }
            Console.WriteLine(string.Join(" ",newOne));


        }
    }
}

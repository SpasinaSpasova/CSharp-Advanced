using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<int, int, bool> predicate = (num, d) => num % d == 0;
            List<int> newList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (numbers.All(d=>predicate(i,d)))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}

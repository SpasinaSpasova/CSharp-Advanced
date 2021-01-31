using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string[]> printNames = name =>
            {
                foreach (var person in name)
                {
                    Console.WriteLine($"Sir {person}");

                }

            };
            printNames(names);
        }
    }
}

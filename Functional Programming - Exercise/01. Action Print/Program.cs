using System;
using System.Linq;

namespace _01._Action_Print
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
                    Console.WriteLine(person);

                }

            };
            printNames(names);
        }


    }
}
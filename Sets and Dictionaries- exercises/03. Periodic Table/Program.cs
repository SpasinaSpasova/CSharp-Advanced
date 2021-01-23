using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < chemicalElements.Length; j++)
                {
                    elements.Add(chemicalElements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",elements));

        }
    }
}

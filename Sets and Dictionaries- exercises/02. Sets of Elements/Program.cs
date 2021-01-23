using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < info[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                first.Add(num);
            }

            for (int i = 0; i < info[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                second.Add(num);
            }

            var intersected=first.Intersect(second);

            Console.WriteLine(string.Join(" ",intersected));
        }
    }
}

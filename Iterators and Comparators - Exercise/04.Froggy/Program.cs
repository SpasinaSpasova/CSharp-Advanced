using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Lake frog = new Lake(stones);

            Console.WriteLine(string.Join(", ",frog));

        }
    }
}

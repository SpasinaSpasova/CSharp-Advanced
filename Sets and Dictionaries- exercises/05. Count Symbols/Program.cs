using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!dict.ContainsKey(current))
                {
                    dict.Add(current, 0);
                }
                dict[current]++;
            }
            foreach (var letter in dict)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}

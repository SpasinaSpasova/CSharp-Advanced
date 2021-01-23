using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ").ToArray();
                string color = data[0];
                string[] items = data[1].Split(",").ToArray();

                for (int j = 0; j < items.Length; j++)
                {
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }
                    if (!wardrobe[color].ContainsKey(items[j]))
                    {
                        wardrobe[color].Add(items[j], 0);
                    }

                    
                    wardrobe[color][items[j]]++;

                }

            }
            string[] clothesLookingFor = Console.ReadLine().Split(" ").ToArray();

            string colour = clothesLookingFor[0];
            string clothes = clothesLookingFor[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var item2 in item.Value)
                {
                    Console.Write($"* {item2.Key} - {item2.Value}");
                    if (colour==item.Key&&clothes==item2.Key)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

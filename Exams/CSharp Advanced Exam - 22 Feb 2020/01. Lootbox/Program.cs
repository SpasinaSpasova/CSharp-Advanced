﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int items = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int first = firstBox.Peek();
                int second = secondBox.Peek();
                int sum = first + second;
                if (sum % 2 == 0)
                {
                    items += sum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
            if (firstBox.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (items>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {items}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {items}");
            }
        }
    }
}

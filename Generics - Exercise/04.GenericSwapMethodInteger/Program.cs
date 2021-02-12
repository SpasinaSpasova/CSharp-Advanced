using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> all = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                int command = int.Parse(Console.ReadLine());
                Box<int> current = new Box<int>(command);
                all.Add(current);
            }
            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int first = index[0];
            int second = index[1];
            Swap(all, first, second);
            foreach (Box<int> item in all)
            {
                Console.WriteLine(item);
            }
        }
        public static void Swap<T>(List<Box<T>> boxes, int first, int second)
        {
            Box<T> temp = boxes[first];
            boxes[first] = boxes[second];
            boxes[second] = temp;
        }

    }
}

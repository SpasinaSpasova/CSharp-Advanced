using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            List<Box<string>> all = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                Box<string> current = new Box<string>(command);
                all.Add(current);
            }
            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int first = index[0];
            int second = index[1];
            Swap(all, first, second);
            foreach (Box<string> item in all)
            {
                Console.WriteLine(item);
            }
        }
        public static void Swap<T>(List<Box<T>> boxes,int first,int second)
        {
            Box<T> temp = boxes[first];
            boxes[first] = boxes[second];
            boxes[second]= temp;
        }
    }
}

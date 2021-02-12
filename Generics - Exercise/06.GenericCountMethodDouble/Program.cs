using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> all = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                double command = double.Parse(Console.ReadLine());
                Box<double> current = new Box<double>(command);
                all.Add(current);
            }
            double value = double.Parse(Console.ReadLine());
            Box<double> comparer = new Box<double>(value);
            Console.WriteLine(GetCount(all, comparer));
        }
        private static int GetCount<T>(List<Box<T>> boxes, Box<T> comparer)
            where T : IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(comparer.Value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

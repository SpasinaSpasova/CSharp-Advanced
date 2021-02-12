using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> all = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                Box<string> current = new Box<string>(command);
                all.Add(current);
            }
            string value = Console.ReadLine();
            Box<string> comparer = new Box<string>(value);
            Console.WriteLine(GetCount(all, comparer));
        }
        private static int GetCount<T>(List<Box<T>> boxes,Box<T> comparer)
            where T: IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(comparer.Value)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

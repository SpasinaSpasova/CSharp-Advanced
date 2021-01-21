using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dict = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }
                string[] arguments = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict[shop] = new Dictionary<string, double>();
                }
                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop].Add(product, 0);
                }
                dict[shop][product] = price;

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"Product: {item2.Key}, Price: {string.Join(" ", item2.Value)}");
                }
            }
        }
    }
}

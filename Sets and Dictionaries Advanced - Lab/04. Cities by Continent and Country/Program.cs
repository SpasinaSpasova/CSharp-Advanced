using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string,List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string continent = information[0];
                string country = information[1];
                string city = information[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }
                dict[continent][country].Add(city);
            }
            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var grade in continent.Value)
                {
                    Console.Write($"    {grade.Key} -> ");
                    Console.WriteLine($"{string.Join(", ",grade.Value)}");
                }
                
            }
        }
    }
}

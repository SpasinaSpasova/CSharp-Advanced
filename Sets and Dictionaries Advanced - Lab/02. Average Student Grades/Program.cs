using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] information = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = information[0];
                decimal grade = decimal.Parse(information[1]);

                if (dict.ContainsKey(name))
                {
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name] = new List<decimal>();
                    dict[name].Add(grade);
                }
            }
            foreach (var item in dict)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}

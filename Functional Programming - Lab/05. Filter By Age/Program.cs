using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> peopleInfo = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                peopleInfo.Add(people[0], int.Parse(people[1]));
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string typeOfPrint = Console.ReadLine();
            Func<int, bool> Filtered = CreateFilter(filter, age);
            Action<KeyValuePair<string, int>> printer = Printer(typeOfPrint);
            PrintFilteredStudent(peopleInfo, Filtered, printer);
        }
        private static Func<int, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x < age;
            }
            else
            {
                return x => x >= age;
            }
        }
        private static Action<KeyValuePair<string, int>> Printer (string format)
        {
            if (format == "name")
            {
                return people => Console.WriteLine($"{people.Key}");
            }
            else if (format == "age")
            {
                return people => Console.WriteLine($"{people.Value}");
            }
            else
            {
                return people => Console.WriteLine($"{people.Key} - {people.Value}");
            }

        }
        private static void PrintFilteredStudent(Dictionary<string, int> dictionary, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var item in dictionary)
            {
                if (tester(item.Value))
                {
                    printer(item);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currentPerson = new Person(name, age);
                persons.Add(currentPerson);
            }
            persons = persons.Where(a=>a.Age>30).OrderBy(x => x.Name).ToList();
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name+ " - "+item.Age);
            }

        }
    }
}

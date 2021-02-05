using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                persons.Add(person);
            }
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name + "-" +item.Age);
            }
           
        }
    }
}

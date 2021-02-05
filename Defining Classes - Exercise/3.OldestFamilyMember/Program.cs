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

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }
            Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> all = new List<Person>();
            while (command != "END")
            {
                string[] tokens = command.Split(" ").ToArray();

                Person current = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
                all.Add(current);


                command = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine());
            Person person = all[index-1];

            int counter = 0;
            
            foreach (var man in all)
            {
                if (man.CompareTo(person) == 0)
                {
                    counter++;
                }
                
            }

            if (counter > 1)
            {
                int nonEqual = all.Count - counter;
                Console.WriteLine($"{counter} {nonEqual} {all.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }


        }
    }
}
